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
using DryingHouse.Core.Helper;
using DryingHouse.Persistence;
using DryingHouse.Persistence.Repositories;
using System.Linq.Expressions;
using DryingHouse.Core.Domain;
using DevExpress.XtraGrid.Views.Grid;
using DryingHouse.Core;
using DevExpress.XtraGrid.Columns;

namespace DryingHouse.View.Report
{
    public partial class frmReportSynthetic : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext;
        ScanBarcodeRepository _scanBarcodeRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs e = new KeyEventArgs(keyData);

            if (e.KeyCode == Keys.F4)
            {
                btnExcel_Click(null, null);
                return true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public frmReportSynthetic()
        {
            InitializeComponent();
        }
        private void frmProductionHistory_Load(object sender, EventArgs e)
        {
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            btnRefresh_Click(null, null);
        }
        private void Search()
        {
            _projectDataContext = new ProjectDataContext();
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);

            DateTime fromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd 00:00:00"));
            DateTime toDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd 23:59:59"));

            var Step1 = _scanBarcodeRepository.GetFirstStep(fromDate, toDate);
            List<string> lstBarcode = Step1.Select(s => s.Barcode).ToList();

            List<ScanBarcode> Step2 = _scanBarcodeRepository.GetListProdctionByStep(lstBarcode, 2).ToList();
            List<ScanBarcode> Step3 = _scanBarcodeRepository.GetListProdctionByStep(lstBarcode,3).ToList();
            List<ScanBarcode> Step4 = _scanBarcodeRepository.GetListProdctionByStep(lstBarcode,4).ToList();
            List<ScanBarcode> Step5 = _scanBarcodeRepository.GetListProdctionByStep(lstBarcode,5).ToList();
            List<ScanBarcode> LastData = _scanBarcodeRepository.GetLastProduction(lstBarcode).ToList();

            var Result = (from s1 in Step1
                          join p2 in Step2 on s1.Barcode equals p2.Barcode into grp2
                          join p3 in Step3 on s1.Barcode equals p3.Barcode into grp3
                          join p4 in Step4 on s1.Barcode equals p4.Barcode into grp4
                          join p5 in Step5 on s1.Barcode equals p5.Barcode into grp5
                          join p6 in LastData on s1.Barcode equals p6.Barcode
                          from s2 in grp2.DefaultIfEmpty()
                          from s3 in grp3.DefaultIfEmpty()
                          from s4 in grp4.DefaultIfEmpty()
                          from s5 in grp5.DefaultIfEmpty()
                          select new
                          {
                              PartNumber = s1.PartNumber,
                              Barcode = s1.Barcode,
                              ScanIn = s1.ScanIn,
                              LastScanOut = p6.ScanOut,
                              MaxStep = p6.StepNo,
                              Step1 = s1.ResultStatus,
                              Drying1 = s1.DryingTime,
                              Step2 = (s2 == null ? (GlobalConstants.ResultStatusValue?)null : s2.ResultStatus),
                              Drying2 = (s2 == null ? (float?)null : s2.DryingTime),
                              Step3 = (s3 == null ? (GlobalConstants.ResultStatusValue?)null : s3.ResultStatus),
                              Drying3 = (s3 == null ? (float?)null : s3.DryingTime),
                              Step4 = (s4 == null ? (GlobalConstants.ResultStatusValue?)null : s4.ResultStatus),
                              Drying4 = (s4 == null ? (float?)null : s4.DryingTime),
                              Step5 = (s5 == null ? (GlobalConstants.ResultStatusValue?)null : s5.ResultStatus),
                              Drying5 = (s5 == null ? (float?)null : s5.DryingTime),
                              CompletedStatus = p6.CompletedStatus
                          }).OrderByDescending(o=>o.ScanIn).ToList();

            dgvDuLieu.DataSource = Result;
            Control();

        }
        private void Control()
        {
            btnExcel.Enabled = (viewDuLieu.RowCount > 0);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            GeneralHelper.ExportExcel(dgvDuLieu);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Search();
            if (cbxGroupData.Checked)
            {
                GroupData();
                viewDuLieu.ExpandAllGroups();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewDuLieu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;

                if (e.Column.FieldName == "CompletedStatus")
                {
                    int Result = Convert.ToInt16(View.GetRowCellValue(e.RowHandle, View.Columns["CompletedStatus"]));
                    if (Result == (int)GlobalConstants.CompletedStatusValue.OK)
                    {
                        e.Appearance.BackColor = Color.ForestGreen;
                        e.Appearance.ForeColor = Color.White;
                    }
                    if (Result == (int)GlobalConstants.CompletedStatusValue.NG)
                    {
                        e.Appearance.BackColor = Color.Red;
                        e.Appearance.ForeColor = Color.White;
                    }

                }
                else
                {
                    for (int i = 1; i < 6; i++)
                    {
                        if (e.Column.FieldName == "Step" + i  || e.Column.FieldName == "Drying" + i)  //&& e.Column.FieldName == "Drying" + i
                        {
                            string StepNo = Convert.ToString( View.GetRowCellValue(e.RowHandle, View.Columns["Step" + i]));
                            //int StepNo = Convert.ToInt16();
                            if (StepNo == GlobalConstants.ResultStatusValue.OK.ToString())
                            {
                                e.Appearance.BackColor = Color.LightGreen;
                            }
                            else if (StepNo == GlobalConstants.ResultStatusValue.Timeout.ToString())
                            {
                                e.Appearance.BackColor = Color.Orange;
                            }
                            else if (StepNo == GlobalConstants.ResultStatusValue.Timeless.ToString())
                            {
                                e.Appearance.BackColor = Color.Yellow;
                            }
                            else if (StepNo == GlobalConstants.ResultStatusValue.Processing.ToString())
                            {
                                e.Appearance.BackColor = Color.DeepSkyBlue;
                            }
                            
                        }

                    }
                }

            }
        }

        private void ExpandData_Click(object sender, EventArgs e)
        {
            if(btnExpandData.Text == "ExpandData")
            {
                viewDuLieu.ExpandAllGroups();
                btnExpandData.Text = "CollapseData";
            }
            else
            {
                viewDuLieu.CollapseAllGroups();
                btnExpandData.Text = "ExpandData";
            }
            
        }

        private void cbxGroupData_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxGroupData.Checked)
            {
                btnExpandData.Enabled = true;
                GroupData();
            }
            else
            {
                btnExpandData.Enabled = false;
                viewDuLieu.ClearGrouping();
                btnExpandData.Text = "ExpandData";
            }
        }
        private void GroupData()
        {
            GridColumn colPartNumber = viewDuLieu.Columns["PartNumber"];
            GridColumn colBarcode = viewDuLieu.Columns["Barcode"];
            viewDuLieu.BeginSort();
            try
            {
                viewDuLieu.ClearGrouping();
                colPartNumber.GroupIndex = 0;
                colBarcode.GroupIndex = 1;
            }
            finally
            {
                viewDuLieu.EndSort();
            }
        }
        private void viewDuLieu_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private void viewDuLieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (viewDuLieu.RowCount > 0)
            {
                if (e.Control && e.KeyCode == Keys.C)
                {
                    Clipboard.SetText(viewDuLieu.GetRowCellValue(viewDuLieu.FocusedRowHandle, viewDuLieu.FocusedColumn.Name).ToString());
                    e.Handled = true;
                }
            }
        }

    }
}