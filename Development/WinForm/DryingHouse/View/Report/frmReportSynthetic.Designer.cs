namespace DryingHouse.View.Report
{
    partial class frmReportSynthetic
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
            this.PartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastScanOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Step1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Drying1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Step2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Drying2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Step3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Drying3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Step4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Drying4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Step5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Drying5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompletedStatus = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.cbxGroupData.Location = new System.Drawing.Point(798, 22);
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
            this.btnExpandData.Location = new System.Drawing.Point(917, 7);
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
            this.PartNumber,
            this.Barcode,
            this.ScanIn,
            this.LastScanOut,
            this.Step1,
            this.Drying1,
            this.Step2,
            this.Drying2,
            this.Step3,
            this.Drying3,
            this.Step4,
            this.Drying4,
            this.Step5,
            this.Drying5,
            this.CompletedStatus});
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 47;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ColumnAutoWidth = false;
            this.viewDuLieu.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.viewDuLieu.OptionsView.ShowAutoFilterRow = true;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 49;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            this.viewDuLieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewDuLieu_KeyDown);
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
            this.PartNumber.Caption = "PartNumber";
            this.PartNumber.ColumnEdit = this.repositoryItemMemoEdit1;
            this.PartNumber.FieldName = "PartNumber";
            this.PartNumber.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.PartNumber.MaxWidth = 150;
            this.PartNumber.MinWidth = 150;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Visible = true;
            this.PartNumber.VisibleIndex = 0;
            this.PartNumber.Width = 150;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
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
            this.Barcode.Caption = "Mã vạch";
            this.Barcode.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Barcode.FieldName = "Barcode";
            this.Barcode.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Barcode.MinWidth = 10;
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 1;
            this.Barcode.Width = 199;
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
            this.ScanIn.MaxWidth = 140;
            this.ScanIn.MinWidth = 140;
            this.ScanIn.Name = "ScanIn";
            this.ScanIn.Visible = true;
            this.ScanIn.VisibleIndex = 2;
            this.ScanIn.Width = 140;
            // 
            // LastScanOut
            // 
            this.LastScanOut.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LastScanOut.AppearanceCell.Options.UseFont = true;
            this.LastScanOut.AppearanceCell.Options.UseTextOptions = true;
            this.LastScanOut.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LastScanOut.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LastScanOut.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LastScanOut.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LastScanOut.AppearanceHeader.Options.UseFont = true;
            this.LastScanOut.AppearanceHeader.Options.UseTextOptions = true;
            this.LastScanOut.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LastScanOut.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.LastScanOut.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LastScanOut.Caption = "Thời gian ra";
            this.LastScanOut.ColumnEdit = this.repositoryItemMemoEdit1;
            this.LastScanOut.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
            this.LastScanOut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.LastScanOut.FieldName = "LastScanOut";
            this.LastScanOut.MaxWidth = 140;
            this.LastScanOut.MinWidth = 140;
            this.LastScanOut.Name = "LastScanOut";
            this.LastScanOut.Visible = true;
            this.LastScanOut.VisibleIndex = 3;
            this.LastScanOut.Width = 140;
            // 
            // Step1
            // 
            this.Step1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Step1.AppearanceCell.Options.UseFont = true;
            this.Step1.AppearanceCell.Options.UseTextOptions = true;
            this.Step1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Step1.AppearanceHeader.Options.UseFont = true;
            this.Step1.AppearanceHeader.Options.UseTextOptions = true;
            this.Step1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step1.Caption = "Bước 1";
            this.Step1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Step1.FieldName = "Step1";
            this.Step1.MaxWidth = 90;
            this.Step1.MinWidth = 90;
            this.Step1.Name = "Step1";
            this.Step1.Visible = true;
            this.Step1.VisibleIndex = 4;
            this.Step1.Width = 90;
            // 
            // Drying1
            // 
            this.Drying1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Drying1.AppearanceCell.Options.UseFont = true;
            this.Drying1.AppearanceCell.Options.UseTextOptions = true;
            this.Drying1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Drying1.AppearanceHeader.Options.UseFont = true;
            this.Drying1.AppearanceHeader.Options.UseTextOptions = true;
            this.Drying1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying1.Caption = "Thời gian sản xuất 1";
            this.Drying1.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Drying1.FieldName = "Drying1";
            this.Drying1.MaxWidth = 110;
            this.Drying1.MinWidth = 110;
            this.Drying1.Name = "Drying1";
            this.Drying1.Visible = true;
            this.Drying1.VisibleIndex = 5;
            this.Drying1.Width = 110;
            // 
            // Step2
            // 
            this.Step2.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Step2.AppearanceCell.Options.UseFont = true;
            this.Step2.AppearanceCell.Options.UseTextOptions = true;
            this.Step2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Step2.AppearanceHeader.Options.UseFont = true;
            this.Step2.AppearanceHeader.Options.UseTextOptions = true;
            this.Step2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step2.Caption = "Bước 2";
            this.Step2.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Step2.FieldName = "Step2";
            this.Step2.MaxWidth = 90;
            this.Step2.MinWidth = 90;
            this.Step2.Name = "Step2";
            this.Step2.Visible = true;
            this.Step2.VisibleIndex = 6;
            this.Step2.Width = 90;
            // 
            // Drying2
            // 
            this.Drying2.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Drying2.AppearanceCell.Options.UseFont = true;
            this.Drying2.AppearanceCell.Options.UseTextOptions = true;
            this.Drying2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying2.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Drying2.AppearanceHeader.Options.UseFont = true;
            this.Drying2.AppearanceHeader.Options.UseTextOptions = true;
            this.Drying2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying2.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying2.Caption = "Thời gian sản xuất 2";
            this.Drying2.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Drying2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Drying2.FieldName = "Drying2";
            this.Drying2.MaxWidth = 110;
            this.Drying2.MinWidth = 110;
            this.Drying2.Name = "Drying2";
            this.Drying2.Visible = true;
            this.Drying2.VisibleIndex = 7;
            this.Drying2.Width = 110;
            // 
            // Step3
            // 
            this.Step3.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Step3.AppearanceCell.Options.UseFont = true;
            this.Step3.AppearanceCell.Options.UseTextOptions = true;
            this.Step3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step3.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Step3.AppearanceHeader.Options.UseFont = true;
            this.Step3.AppearanceHeader.Options.UseTextOptions = true;
            this.Step3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step3.Caption = "Bước 3";
            this.Step3.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Step3.FieldName = "Step3";
            this.Step3.MaxWidth = 90;
            this.Step3.MinWidth = 90;
            this.Step3.Name = "Step3";
            this.Step3.Visible = true;
            this.Step3.VisibleIndex = 8;
            this.Step3.Width = 90;
            // 
            // Drying3
            // 
            this.Drying3.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Drying3.AppearanceCell.Options.UseFont = true;
            this.Drying3.AppearanceCell.Options.UseTextOptions = true;
            this.Drying3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying3.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying3.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Drying3.AppearanceHeader.Options.UseFont = true;
            this.Drying3.AppearanceHeader.Options.UseTextOptions = true;
            this.Drying3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying3.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying3.Caption = "Thời gian sản xuất 3";
            this.Drying3.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Drying3.FieldName = "Drying3";
            this.Drying3.MaxWidth = 110;
            this.Drying3.MinWidth = 110;
            this.Drying3.Name = "Drying3";
            this.Drying3.Visible = true;
            this.Drying3.VisibleIndex = 9;
            this.Drying3.Width = 110;
            // 
            // Step4
            // 
            this.Step4.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Step4.AppearanceCell.Options.UseFont = true;
            this.Step4.AppearanceCell.Options.UseTextOptions = true;
            this.Step4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step4.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Step4.AppearanceHeader.Options.UseFont = true;
            this.Step4.AppearanceHeader.Options.UseTextOptions = true;
            this.Step4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step4.Caption = "Bước 4";
            this.Step4.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Step4.FieldName = "Step4";
            this.Step4.MaxWidth = 90;
            this.Step4.MinWidth = 90;
            this.Step4.Name = "Step4";
            this.Step4.Visible = true;
            this.Step4.VisibleIndex = 10;
            this.Step4.Width = 90;
            // 
            // Drying4
            // 
            this.Drying4.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Drying4.AppearanceCell.Options.UseFont = true;
            this.Drying4.AppearanceCell.Options.UseTextOptions = true;
            this.Drying4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying4.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying4.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Drying4.AppearanceHeader.Options.UseFont = true;
            this.Drying4.AppearanceHeader.Options.UseTextOptions = true;
            this.Drying4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying4.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying4.Caption = "Thời gian sản xuất 4";
            this.Drying4.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Drying4.FieldName = "Drying4";
            this.Drying4.MaxWidth = 110;
            this.Drying4.MinWidth = 110;
            this.Drying4.Name = "Drying4";
            this.Drying4.Visible = true;
            this.Drying4.VisibleIndex = 11;
            this.Drying4.Width = 110;
            // 
            // Step5
            // 
            this.Step5.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Step5.AppearanceCell.Options.UseFont = true;
            this.Step5.AppearanceCell.Options.UseTextOptions = true;
            this.Step5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step5.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Step5.AppearanceHeader.Options.UseFont = true;
            this.Step5.AppearanceHeader.Options.UseTextOptions = true;
            this.Step5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Step5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Step5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Step5.Caption = "Bước 5";
            this.Step5.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Step5.FieldName = "Step5";
            this.Step5.MaxWidth = 90;
            this.Step5.MinWidth = 90;
            this.Step5.Name = "Step5";
            this.Step5.Visible = true;
            this.Step5.VisibleIndex = 12;
            this.Step5.Width = 90;
            // 
            // Drying5
            // 
            this.Drying5.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Drying5.AppearanceCell.Options.UseFont = true;
            this.Drying5.AppearanceCell.Options.UseTextOptions = true;
            this.Drying5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying5.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Drying5.AppearanceHeader.Options.UseFont = true;
            this.Drying5.AppearanceHeader.Options.UseTextOptions = true;
            this.Drying5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Drying5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Drying5.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Drying5.Caption = "Thời gian sản xuất 5";
            this.Drying5.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Drying5.FieldName = "Drying5";
            this.Drying5.MaxWidth = 120;
            this.Drying5.MinWidth = 120;
            this.Drying5.Name = "Drying5";
            this.Drying5.Visible = true;
            this.Drying5.VisibleIndex = 13;
            this.Drying5.Width = 120;
            // 
            // CompletedStatus
            // 
            this.CompletedStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CompletedStatus.AppearanceCell.Options.UseFont = true;
            this.CompletedStatus.AppearanceCell.Options.UseTextOptions = true;
            this.CompletedStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompletedStatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CompletedStatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CompletedStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CompletedStatus.AppearanceHeader.Options.UseFont = true;
            this.CompletedStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.CompletedStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompletedStatus.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CompletedStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CompletedStatus.Caption = "Hoàn thành";
            this.CompletedStatus.ColumnEdit = this.repositoryItemMemoEdit1;
            this.CompletedStatus.FieldName = "CompletedStatus";
            this.CompletedStatus.MaxWidth = 90;
            this.CompletedStatus.MinWidth = 90;
            this.CompletedStatus.Name = "CompletedStatus";
            this.CompletedStatus.Visible = true;
            this.CompletedStatus.VisibleIndex = 14;
            this.CompletedStatus.Width = 90;
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
            // frmReportSynthetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 565);
            this.Controls.Add(this.dgvDuLieu);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReportSynthetic";
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
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn Step1;
        private DevExpress.XtraGrid.Columns.GridColumn ScanIn;
        private DevExpress.XtraGrid.Columns.GridColumn LastScanOut;
        private DevExpress.XtraGrid.Columns.GridColumn Drying2;
        private DevExpress.XtraGrid.Columns.GridColumn Drying1;
        private DevExpress.XtraGrid.Columns.GridColumn Step2;
        private DevExpress.XtraGrid.Columns.GridColumn CompletedStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Step3;
        private DevExpress.XtraGrid.Columns.GridColumn Step4;
        private DevExpress.XtraGrid.Columns.GridColumn Step5;
        private DevExpress.XtraGrid.Columns.GridColumn Drying3;
        private DevExpress.XtraGrid.Columns.GridColumn Drying4;
        private DevExpress.XtraGrid.Columns.GridColumn Drying5;
    }
}