﻿using System;
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
    public partial class frmProductionReportOK : DevExpress.XtraEditors.XtraForm
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
        public frmProductionReportOK()
        {
            InitializeComponent();
        }
        private void frmProductionHistory_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(null, null);
        }
        private void Search()
        {
            _projectDataContext = new ProjectDataContext();
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
            List<Expression<Func<ScanBarcode, bool>>> expressions = new List<Expression<Func<ScanBarcode, bool>>>();
            DateTime fromDate = DateTime.Parse(dtpFromDate.Value.ToString("yyyy-MM-dd 00:00:00"));
            DateTime toDate = DateTime.Parse(dtpToDate.Value.ToString("yyyy-MM-dd 23:59:59"));
            expressions.Add(_ => _.ScanOut >= fromDate && _.ScanOut <= toDate);
            expressions.Add(_ => _.CompletedStatus == GlobalConstants.CompletedStatusValue.OK);
            //expressions.Add(_ => _.ResultStatus == GlobalConstants.ResultStatusValue.OK 
            //|| _.ResultStatus == GlobalConstants.ResultStatusValue.Timeout 
            //|| _.ResultStatus == GlobalConstants.ResultStatusValue.Timeless );
            expressions.Add(_ => _.Status == GlobalConstants.StatusValue.Using);
            dgvDuLieu.DataSource = _scanBarcodeRepository.Find(expressions).OrderBy(_ => _.ScanOut);
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

        private void viewDuLieu_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void viewDuLieu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    GridView View = sender as GridView;

            //    int Result = Convert.ToInt16(View.GetRowCellValue(e.RowHandle, View.Columns["CompletedStatus"]));
            //    int StepNo = Convert.ToInt16(View.GetRowCellValue(e.RowHandle, View.Columns["StepNo"]));
               
            //    if (Result == (int)GlobalConstants.CompletedStatusValue.OK)
            //    {
            //        e.Appearance.BackColor = Color.LightGreen;
            //    }
            //    else if(Result == (int)GlobalConstants.CompletedStatusValue.NG)
            //    {
            //        e.Appearance.BackColor = Color.Tomato;
            //    }
            //}
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

        
    }
}