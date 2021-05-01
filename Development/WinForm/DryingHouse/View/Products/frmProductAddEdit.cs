using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DryingHouse.Persistence;
using DryingHouse.Persistence.Repositories;
using DryingHouse.Core.Domain;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.View.Products
{
    public partial class frmProductAddEdit : XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        ProductRepository _productRepository;
        UnitRepository _unitRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);
            if (e.KeyCode == Keys.F1)
            {
                btnSave_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        string _id = "";
        bool _quickAdd = false;

        public frmProductAddEdit()
        {
            InitializeComponent();
        }

        public frmProductAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmProductAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmProductAddEdit_Load(object sender, EventArgs e)
        {
            _productRepository = new ProductRepository(_projectDataContext);
            _unitRepository = new UnitRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
            LoadUnitData();
            if (String.IsNullOrEmpty(_id))
            {
                Clear();
            }
            else
            {
                GetData();
            }
        }

        private void Clear()
        {
            txtPartNumber.Enabled = true;
            txtPartNumber.Text = "";
            txtProductName.Text = "";
            txtGhiChu.Text = "";
            chkUsing.Checked = true;
            txtPartNumber.Focus();
        }

        private void GetData()
        {
            //Get Data Table Product
            txtPartNumber.Enabled = false;
            Product product = _productRepository.Get(_id);
            txtPartNumber.Text = product.PartNumber;
            txtProductName.Text = product.ProductName;
            cbbUnit.SelectedValue = product.UnitId;
            txtCountLOT.Value = product.CountLOT;
            txtQualityOfProduct.Value = product.Quantity;
            txtGhiChu.Text = product.Note;
            chkUsing.Checked = (product.Status == GlobalConstants.StatusValue.Using);
        }

        private void LoadUnitData()
        {
            cbbUnit.DataSource = _unitRepository.GetAll().OrderBy(_ => _.UnitName).ToList();
            cbbUnit.SelectedIndex = 0;
        }

        private bool CheckData()
        {
            if (txtPartNumber.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartNumber.Focus();
                return false;
            }
            else if (txtProductName.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }
            else if (cbbUnit.SelectedValue == null || cbbUnit.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbUnit.Focus();
                return false;
            }
            Product product = _productRepository.FirstOrDefault(_ => _.PartNumber.Equals(txtPartNumber.Text.Trim()));
            if (product != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && txtPartNumber.Text.Trim() != product.PartNumber)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartNumber.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Product
                Product product = new Product();
                product.Id = _id;
                product.PartNumber = txtPartNumber.Text.Trim();
                product.ProductName = txtProductName.Text.Trim();
                product.UnitId = cbbUnit.SelectedValue.ToString();
                product.CountLOT =(int)txtCountLOT.Value;
                product.Quantity = (int)txtQualityOfProduct.Value;
                product.Note = txtGhiChu.Text.Trim();
                product.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _productRepository.Save(product);
                UnitOfWork productOfWork = new UnitOfWork(_projectDataContext);
                int result = productOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = _id;
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thành công"), LanguageTranslate.ChangeLanguageText("Thông báo"));
                            Clear();
                        }
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Lưu thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            Units.frmUnitAddEdit frm = new Units.frmUnitAddEdit(true);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK && frm.Tag != null)
            {
                LoadUnitData();
                cbbUnit.SelectedValue = (string)frm.Tag;
            }
        }
    }
}