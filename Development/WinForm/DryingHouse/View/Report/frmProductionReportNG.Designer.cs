namespace DryingHouse.View.Report
{
    partial class frmProductionReportNG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxGroupData = new System.Windows.Forms.CheckBox();
            this.btnExpandData = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.PartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StepNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Limit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DryingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResultStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompletedStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Reason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbxGroupData);
            this.panelControl1.Controls.Add(this.btnExpandData);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Controls.Add(this.btnRefresh);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1480, 62);
            this.panelControl1.TabIndex = 1;
            // 
            // cbxGroupData
            // 
            this.cbxGroupData.AutoSize = true;
            this.cbxGroupData.Location = new System.Drawing.Point(810, 20);
            this.cbxGroupData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxGroupData.Name = "cbxGroupData";
            this.cbxGroupData.Size = new System.Drawing.Size(101, 21);
            this.cbxGroupData.TabIndex = 8;
            this.cbxGroupData.Text = "Group Data";
            this.cbxGroupData.UseVisualStyleBackColor = true;
            this.cbxGroupData.CheckedChanged += new System.EventHandler(this.cbxGroupData_CheckedChanged);
            // 
            // btnExpandData
            // 
            this.btnExpandData.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExpandData.Appearance.Options.UseFont = true;
            this.btnExpandData.Enabled = false;
            this.btnExpandData.Location = new System.Drawing.Point(929, 5);
            this.btnExpandData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExpandData.Name = "btnExpandData";
            this.btnExpandData.Size = new System.Drawing.Size(125, 49);
            this.btnExpandData.TabIndex = 7;
            this.btnExpandData.Text = "ExpandData";
            this.btnExpandData.Click += new System.EventHandler(this.ExpandData_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dtpFromDate);
            this.panelControl2.Controls.Add(this.dtpToDate);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(205, 6);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(443, 49);
            this.panelControl2.TabIndex = 5;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(84, 9);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(133, 32);
            this.dtpFromDate.TabIndex = 7;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(301, 9);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(133, 32);
            this.dtpToDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(225, 14);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 23);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Đến ngày";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 14);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 23);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Từ ngày";
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Location = new System.Drawing.Point(5, 6);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(93, 49);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel (F4)";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Location = new System.Drawing.Point(105, 6);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 49);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Lọc (F5)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(1374, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 49);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDuLieu.Location = new System.Drawing.Point(0, 62);
            this.dgvDuLieu.MainView = this.viewDuLieu;
            this.dgvDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit1});
            this.dgvDuLieu.Size = new System.Drawing.Size(1480, 503);
            this.dgvDuLieu.TabIndex = 4;
            this.dgvDuLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDuLieu});
            // 
            // viewDuLieu
            // 
            this.viewDuLieu.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.viewDuLieu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseForeColor = true;
            this.viewDuLieu.ColumnPanelRowHeight = 49;
            this.viewDuLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.PartNumber,
            this.Barcode,
            this.StepNo,
            this.ScanIn,
            this.ScanOut,
            this.Limit,
            this.DryingTime,
            this.ResultStatus,
            this.CompletedStatus,
            this.Reason});
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 47;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.viewDuLieu.OptionsView.RowAutoHeight = true;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 49;
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceHeader.Options.UseFont = true;
            this.Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.Caption = "Id";
            this.Id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Id.FieldName = "Id";
            this.Id.MinWidth = 23;
            this.Id.Name = "Id";
            this.Id.Width = 117;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // PartNumber
            // 
            this.PartNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PartNumber.AppearanceCell.Options.UseFont = true;
            this.PartNumber.AppearanceCell.Options.UseTextOptions = true;
            this.PartNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNumber.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PartNumber.AppearanceHeader.Options.UseFont = true;
            this.PartNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNumber.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNumber.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber.Caption = "Mã sản phẩm";
            this.PartNumber.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNumber.FieldName = "PartNumber";
            this.PartNumber.MaxWidth = 150;
            this.PartNumber.MinWidth = 150;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Visible = true;
            this.PartNumber.VisibleIndex = 0;
            this.PartNumber.Width = 150;
            // 
            // Barcode
            // 
            this.Barcode.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Barcode.AppearanceCell.Options.UseFont = true;
            this.Barcode.AppearanceCell.Options.UseTextOptions = true;
            this.Barcode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Barcode.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Barcode.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Barcode.AppearanceHeader.Options.UseFont = true;
            this.Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Barcode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Barcode.Caption = "Mã Lô sản phẩm";
            this.Barcode.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Barcode.FieldName = "Barcode";
            this.Barcode.MaxWidth = 199;
            this.Barcode.MinWidth = 199;
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 1;
            this.Barcode.Width = 199;
            // 
            // StepNo
            // 
            this.StepNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StepNo.AppearanceCell.Options.UseFont = true;
            this.StepNo.AppearanceCell.Options.UseTextOptions = true;
            this.StepNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StepNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.StepNo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.StepNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.StepNo.AppearanceHeader.Options.UseFont = true;
            this.StepNo.AppearanceHeader.Options.UseTextOptions = true;
            this.StepNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StepNo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.StepNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.StepNo.Caption = "Bước";
            this.StepNo.FieldName = "StepNo";
            this.StepNo.MaxWidth = 120;
            this.StepNo.MinWidth = 120;
            this.StepNo.Name = "StepNo";
            this.StepNo.Visible = true;
            this.StepNo.VisibleIndex = 2;
            this.StepNo.Width = 120;
            // 
            // ScanIn
            // 
            this.ScanIn.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScanIn.AppearanceCell.Options.UseFont = true;
            this.ScanIn.AppearanceCell.Options.UseTextOptions = true;
            this.ScanIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanIn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanIn.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanIn.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ScanIn.AppearanceHeader.Options.UseFont = true;
            this.ScanIn.AppearanceHeader.Options.UseTextOptions = true;
            this.ScanIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanIn.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanIn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanIn.Caption = "Thời gian vào";
            this.ScanIn.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ScanIn.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.ScanIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ScanIn.FieldName = "ScanIn";
            this.ScanIn.MaxWidth = 160;
            this.ScanIn.MinWidth = 160;
            this.ScanIn.Name = "ScanIn";
            this.ScanIn.Visible = true;
            this.ScanIn.VisibleIndex = 3;
            this.ScanIn.Width = 160;
            // 
            // ScanOut
            // 
            this.ScanOut.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScanOut.AppearanceCell.Options.UseFont = true;
            this.ScanOut.AppearanceCell.Options.UseTextOptions = true;
            this.ScanOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanOut.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanOut.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanOut.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ScanOut.AppearanceHeader.Options.UseFont = true;
            this.ScanOut.AppearanceHeader.Options.UseTextOptions = true;
            this.ScanOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanOut.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanOut.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanOut.Caption = "Thời gian ra";
            this.ScanOut.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ScanOut.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.ScanOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ScanOut.FieldName = "ScanOut";
            this.ScanOut.MaxWidth = 160;
            this.ScanOut.MinWidth = 160;
            this.ScanOut.Name = "ScanOut";
            this.ScanOut.Visible = true;
            this.ScanOut.VisibleIndex = 4;
            this.ScanOut.Width = 160;
            // 
            // Limit
            // 
            this.Limit.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Limit.AppearanceCell.Options.UseFont = true;
            this.Limit.AppearanceCell.Options.UseTextOptions = true;
            this.Limit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Limit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Limit.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Limit.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Limit.AppearanceHeader.Options.UseFont = true;
            this.Limit.AppearanceHeader.Options.UseTextOptions = true;
            this.Limit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Limit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Limit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Limit.Caption = "Thời gian sản xuất (Master)";
            this.Limit.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Limit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Limit.FieldName = "Limit";
            this.Limit.MaxWidth = 120;
            this.Limit.MinWidth = 120;
            this.Limit.Name = "Limit";
            this.Limit.Visible = true;
            this.Limit.VisibleIndex = 5;
            this.Limit.Width = 120;
            // 
            // DryingTime
            // 
            this.DryingTime.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DryingTime.AppearanceCell.Options.UseFont = true;
            this.DryingTime.AppearanceCell.Options.UseTextOptions = true;
            this.DryingTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DryingTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DryingTime.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DryingTime.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DryingTime.AppearanceHeader.Options.UseFont = true;
            this.DryingTime.AppearanceHeader.Options.UseTextOptions = true;
            this.DryingTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DryingTime.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DryingTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DryingTime.Caption = "Thời gian sản xuất";
            this.DryingTime.ColumnEdit = this.repositoryItemMemoEdit1;
            this.DryingTime.FieldName = "DryingTime";
            this.DryingTime.MaxWidth = 120;
            this.DryingTime.MinWidth = 120;
            this.DryingTime.Name = "DryingTime";
            this.DryingTime.Visible = true;
            this.DryingTime.VisibleIndex = 6;
            this.DryingTime.Width = 120;
            // 
            // ResultStatus
            // 
            this.ResultStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ResultStatus.AppearanceCell.Options.UseFont = true;
            this.ResultStatus.AppearanceCell.Options.UseTextOptions = true;
            this.ResultStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ResultStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ResultStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ResultStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ResultStatus.AppearanceHeader.Options.UseFont = true;
            this.ResultStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.ResultStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ResultStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ResultStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ResultStatus.Caption = "Kết quả sản xuất";
            this.ResultStatus.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ResultStatus.FieldName = "ResultStatus";
            this.ResultStatus.MaxWidth = 150;
            this.ResultStatus.MinWidth = 150;
            this.ResultStatus.Name = "ResultStatus";
            this.ResultStatus.Visible = true;
            this.ResultStatus.VisibleIndex = 7;
            this.ResultStatus.Width = 150;
            // 
            // CompletedStatus
            // 
            this.CompletedStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CompletedStatus.AppearanceCell.Options.UseFont = true;
            this.CompletedStatus.AppearanceCell.Options.UseTextOptions = true;
            this.CompletedStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompletedStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CompletedStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CompletedStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.CompletedStatus.AppearanceHeader.Options.UseFont = true;
            this.CompletedStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.CompletedStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompletedStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CompletedStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CompletedStatus.Caption = "Hoàn thành";
            this.CompletedStatus.ColumnEdit = this.repositoryItemMemoEdit1;
            this.CompletedStatus.FieldName = "CompletedStatus";
            this.CompletedStatus.MaxWidth = 150;
            this.CompletedStatus.MinWidth = 150;
            this.CompletedStatus.Name = "CompletedStatus";
            this.CompletedStatus.Visible = true;
            this.CompletedStatus.VisibleIndex = 8;
            this.CompletedStatus.Width = 150;
            // 
            // Reason
            // 
            this.Reason.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Reason.AppearanceCell.Options.UseFont = true;
            this.Reason.AppearanceCell.Options.UseTextOptions = true;
            this.Reason.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Reason.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Reason.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Reason.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Reason.AppearanceHeader.Options.UseFont = true;
            this.Reason.AppearanceHeader.Options.UseTextOptions = true;
            this.Reason.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Reason.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Reason.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Reason.Caption = "Lý do dừng";
            this.Reason.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Reason.FieldName = "Reason";
            this.Reason.MinWidth = 24;
            this.Reason.Name = "Reason";
            this.Reason.Visible = true;
            this.Reason.VisibleIndex = 9;
            this.Reason.Width = 341;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // frmProductionReportNG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 565);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductionReportNG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductionHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnExpandData;
        private System.Windows.Forms.CheckBox cbxGroupData;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn StepNo;
        private DevExpress.XtraGrid.Columns.GridColumn ScanIn;
        private DevExpress.XtraGrid.Columns.GridColumn ScanOut;
        private DevExpress.XtraGrid.Columns.GridColumn Limit;
        private DevExpress.XtraGrid.Columns.GridColumn DryingTime;
        private DevExpress.XtraGrid.Columns.GridColumn ResultStatus;
        private DevExpress.XtraGrid.Columns.GridColumn CompletedStatus;
        private DevExpress.XtraGrid.Columns.GridColumn Reason;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}