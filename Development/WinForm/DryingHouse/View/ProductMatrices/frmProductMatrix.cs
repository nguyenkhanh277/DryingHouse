using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DryingHouse.Persistence;
using DryingHouse.Core;
using DryingHouse.Persistence.Repositories;
using DryingHouse.Core.Helper;
using DryingHouse.Core.Domain;
using System.Linq.Expressions;

namespace DryingHouse.View.ProductMatrices
{
    public partial class frmProductMatrix : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext;
        ProductRepository _productRepository;
        StepRepository _stepRepository;
        ProductMatrixRepository _productMatrixRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmProductMatrix()
        {
            InitializeComponent();
        }

        private void frmProductMatrix_Load(object sender, EventArgs e)
        {
            LanguageTranslate.ChangeLanguageForm(this);
            //LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            Search();
             
        }

        private void GenarateGrid()
        {
            dgvDuLieu.Columns.Clear();
            dgvDuLieu.Rows.Clear();
            _projectDataContext = new ProjectDataContext();
            _stepRepository = new StepRepository(_projectDataContext);
            List<Step> steps = _stepRepository.Find(_ => _.Status == GlobalConstants.StatusValue.Using).OrderBy(_ => _.StepNo).ToList();
            DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn.HeaderText = "PartNumber";
            dataGridViewTextBoxColumn.Name = "PartNumber";
            dataGridViewTextBoxColumn.ReadOnly = true;
            dataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvDuLieu.Columns.Add(dataGridViewTextBoxColumn);
            int index = 0;
            foreach (Step step in steps)
            {
                index++;
                dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
                dataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridViewTextBoxColumn.HeaderText = "Bước " + step.StepNo.ToString();
                dataGridViewTextBoxColumn.Name = "Step" + index;
                dataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridViewTextBoxColumn.Width = 150;
                dgvDuLieu.Columns.Add(dataGridViewTextBoxColumn);
            }
        }

        private void Search()
        {
            _projectDataContext = new ProjectDataContext();
            _productRepository = new ProductRepository(_projectDataContext);
            _productMatrixRepository = new ProductMatrixRepository(_projectDataContext);
            List<Product> products = _productRepository.Find(_ => _.Status == GlobalConstants.StatusValue.Using).OrderBy(_ => _.PartNumber).ToList();
            List<ProductMatrix> productMatrixs = _productMatrixRepository.GetAll().ToList();
            GenarateGrid();
            int stepNo = 0;
            foreach (Product product in products)
            {
                dgvDuLieu.Rows.Add();
                dgvDuLieu.Rows[dgvDuLieu.RowCount - 1].Cells["PartNumber"].Value = product.PartNumber;
                for (int col = 1; col < dgvDuLieu.ColumnCount; col++)
                {
                    stepNo = int.Parse(dgvDuLieu.Columns[col].HeaderText.Replace("Bước ", ""));
                    dgvDuLieu.Rows[dgvDuLieu.RowCount - 1].Cells[col].Value = productMatrixs.Where(_ => _.PartNumber.Equals(product.PartNumber) && _.StepNo.Equals(stepNo)).Select(_ => _.DryingTime).FirstOrDefault();
                }
            }
            //Control();
        }

        private void Control()
        {
            if(dgvDuLieu.Rows.Count > 0)
            {
                _productMatrixRepository = new ProductMatrixRepository(_projectDataContext);
                List<ProductMatrix> productMatrixs = _productMatrixRepository.GetAll().ToList();
                for (int i = 0; i < dgvDuLieu.RowCount; i++)
                {
                    string partnumber = dgvDuLieu.Rows[i].Cells["PartNumber"].Value.ToString();
                    for (int j = 1; j < dgvDuLieu.ColumnCount; j++)
                    {
                        int dyringtime = Convert.ToInt16(dgvDuLieu.Rows[i].Cells[j].Value.ToString());
                        //string id = productMatrixs.Where(_ => _.PartNumber == partnumber && _.StepNo == j).Select(_=>_.Id).FirstOrDefault();
                        ProductMatrix data = productMatrixs.Where(_ => _.PartNumber == partnumber && _.StepNo == j ).FirstOrDefault();
                        if(data != null)
                        {
                            if (data.DryingTime != dyringtime)
                            {
                                ProductMatrix _productMatrix = new ProductMatrix();
                                _productMatrix.Id = data.Id;
                                _productMatrix.PartNumber = partnumber;
                                _productMatrix.StepNo = j;
                                _productMatrix.DryingTime = dyringtime;
                                _productMatrixRepository.Save(_productMatrix);
                                UnitOfWork productOfWork = new UnitOfWork(_projectDataContext);
                                int result = productOfWork.Complete();
                            }
                        }
                        else
                        {
                            ProductMatrix _productMatrix = new ProductMatrix();
                            _productMatrix.Id = null;
                            _productMatrix.PartNumber = partnumber;
                            _productMatrix.StepNo = j;
                            _productMatrix.DryingTime = dyringtime;
                            _productMatrixRepository.Save(_productMatrix);
                            UnitOfWork productOfWork = new UnitOfWork(_projectDataContext);
                            int result = productOfWork.Complete();
                        }
                        
                        
                    }
                }
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Control();
            Search();
        }
    }
}