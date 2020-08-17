namespace DryingHouse.View.Monitoring
{
    partial class frmMonitoring
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
            this.components = new System.ComponentModel.Container();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.lblProduction = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblTimeNow = new DevExpress.XtraEditors.LabelControl();
            this.lblWarning = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lblTimeOut = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.lblOK = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.btnProductionHistory = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDuLieu = new DevExpress.XtraGrid.GridControl();
            this.viewDuLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.PartNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StepNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Limit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RemainingTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResultStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lsvLog = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDataComplete = new DevExpress.XtraGrid.GridControl();
            this.ViewDataComplete = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.PartNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StepNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanIn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ScanOut1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DryingTime1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompletedStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.lblProduction);
            this.pnControl.Controls.Add(this.labelControl2);
            this.pnControl.Controls.Add(this.lblTimeNow);
            this.pnControl.Controls.Add(this.lblWarning);
            this.pnControl.Controls.Add(this.labelControl13);
            this.pnControl.Controls.Add(this.lblTimeOut);
            this.pnControl.Controls.Add(this.labelControl17);
            this.pnControl.Controls.Add(this.lblOK);
            this.pnControl.Controls.Add(this.labelControl15);
            this.pnControl.Controls.Add(this.btnProductionHistory);
            this.pnControl.Controls.Add(this.btnClose);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1376, 50);
            this.pnControl.TabIndex = 1;
            // 
            // lblProduction
            // 
            this.lblProduction.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblProduction.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblProduction.Appearance.Options.UseBackColor = true;
            this.lblProduction.Appearance.Options.UseFont = true;
            this.lblProduction.Appearance.Options.UseTextOptions = true;
            this.lblProduction.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblProduction.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblProduction.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblProduction.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProduction.Location = new System.Drawing.Point(840, 2);
            this.lblProduction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblProduction.Name = "lblProduction";
            this.lblProduction.Size = new System.Drawing.Size(130, 46);
            this.lblProduction.TabIndex = 26;
            this.lblProduction.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl2.Location = new System.Drawing.Point(728, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 46);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Sản xuất";
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTimeNow.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTimeNow.Appearance.Options.UseBackColor = true;
            this.lblTimeNow.Appearance.Options.UseFont = true;
            this.lblTimeNow.Appearance.Options.UseTextOptions = true;
            this.lblTimeNow.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTimeNow.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTimeNow.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTimeNow.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTimeNow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTimeNow.Location = new System.Drawing.Point(837, 2);
            this.lblTimeNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(261, 46);
            this.lblTimeNow.TabIndex = 25;
            this.lblTimeNow.Text = "0";
            // 
            // lblWarning
            // 
            this.lblWarning.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWarning.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWarning.Appearance.Options.UseBackColor = true;
            this.lblWarning.Appearance.Options.UseFont = true;
            this.lblWarning.Appearance.Options.UseTextOptions = true;
            this.lblWarning.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWarning.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWarning.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblWarning.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWarning.Location = new System.Drawing.Point(598, 2);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(130, 46);
            this.lblWarning.TabIndex = 23;
            this.lblWarning.Text = "0";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.BackColor = System.Drawing.Color.Orange;
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseBackColor = true;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl13.Location = new System.Drawing.Point(486, 2);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(112, 46);
            this.labelControl13.TabIndex = 24;
            this.labelControl13.Text = "Cảnh báo";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTimeOut.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTimeOut.Appearance.Options.UseBackColor = true;
            this.lblTimeOut.Appearance.Options.UseFont = true;
            this.lblTimeOut.Appearance.Options.UseTextOptions = true;
            this.lblTimeOut.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTimeOut.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTimeOut.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTimeOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTimeOut.Location = new System.Drawing.Point(356, 2);
            this.lblTimeOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(130, 46);
            this.lblTimeOut.TabIndex = 21;
            this.lblTimeOut.Text = "0";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.BackColor = System.Drawing.Color.Red;
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl17.Appearance.Options.UseBackColor = true;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Appearance.Options.UseTextOptions = true;
            this.labelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl17.Location = new System.Drawing.Point(244, 2);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(112, 46);
            this.labelControl17.TabIndex = 22;
            this.labelControl17.Text = "Quá thời gian";
            // 
            // lblOK
            // 
            this.lblOK.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblOK.Appearance.Options.UseBackColor = true;
            this.lblOK.Appearance.Options.UseFont = true;
            this.lblOK.Appearance.Options.UseTextOptions = true;
            this.lblOK.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblOK.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOK.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOK.Location = new System.Drawing.Point(114, 2);
            this.lblOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblOK.Name = "lblOK";
            this.lblOK.Size = new System.Drawing.Size(130, 46);
            this.lblOK.TabIndex = 19;
            this.lblOK.Text = "0";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl15.Appearance.Options.UseBackColor = true;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl15.Location = new System.Drawing.Point(2, 2);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(112, 46);
            this.labelControl15.TabIndex = 20;
            this.labelControl15.Text = "Chờ Hoàn thành";
            // 
            // btnProductionHistory
            // 
            this.btnProductionHistory.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.btnProductionHistory.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProductionHistory.Appearance.Options.UseBackColor = true;
            this.btnProductionHistory.Appearance.Options.UseFont = true;
            this.btnProductionHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProductionHistory.Location = new System.Drawing.Point(1098, 2);
            this.btnProductionHistory.Name = "btnProductionHistory";
            this.btnProductionHistory.Size = new System.Drawing.Size(196, 46);
            this.btnProductionHistory.TabIndex = 8;
            this.btnProductionHistory.Text = "Lịch sử sản xuất";
            this.btnProductionHistory.Click += new System.EventHandler(this.btnProductionHistory_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1294, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 46);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng (ESC)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuLieu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDuLieu.Location = new System.Drawing.Point(0, 0);
            this.dgvDuLieu.MainView = this.viewDuLieu;
            this.dgvDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1});
            this.dgvDuLieu.Size = new System.Drawing.Size(1098, 503);
            this.dgvDuLieu.TabIndex = 2;
            this.dgvDuLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewDuLieu});
            // 
            // viewDuLieu
            // 
            this.viewDuLieu.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.viewDuLieu.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseBackColor = true;
            this.viewDuLieu.Appearance.FocusedCell.Options.UseForeColor = true;
            this.viewDuLieu.ColumnPanelRowHeight = 40;
            this.viewDuLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.PartNumber,
            this.Barcode,
            this.StepNo,
            this.ScanIn,
            this.Limit,
            this.RemainingTime,
            this.ResultStatus});
            this.viewDuLieu.DetailHeight = 284;
            this.viewDuLieu.GridControl = this.dgvDuLieu;
            this.viewDuLieu.IndicatorWidth = 40;
            this.viewDuLieu.Name = "viewDuLieu";
            this.viewDuLieu.OptionsBehavior.Editable = false;
            this.viewDuLieu.OptionsCustomization.AllowQuickHideColumns = false;
            this.viewDuLieu.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.viewDuLieu.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.viewDuLieu.OptionsView.ShowGroupPanel = false;
            this.viewDuLieu.RowHeight = 40;
            this.viewDuLieu.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.viewDuLieu_CustomDrawRowIndicator);
            this.viewDuLieu.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.viewDuLieu_RowCellStyle);
            // 
            // Id
            // 
            this.Id.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceCell.Options.UseFont = true;
            this.Id.AppearanceCell.Options.UseTextOptions = true;
            this.Id.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Id.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Id.AppearanceHeader.Options.UseFont = true;
            this.Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id.Caption = "Id";
            this.Id.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // PartNumber
            // 
            this.PartNumber.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PartNumber.AppearanceCell.Options.UseFont = true;
            this.PartNumber.AppearanceCell.Options.UseTextOptions = true;
            this.PartNumber.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNumber.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PartNumber.AppearanceHeader.Options.UseFont = true;
            this.PartNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
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
            this.Barcode.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Barcode.AppearanceCell.Options.UseFont = true;
            this.Barcode.AppearanceCell.Options.UseTextOptions = true;
            this.Barcode.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Barcode.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Barcode.AppearanceHeader.Options.UseFont = true;
            this.Barcode.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Barcode.Caption = "Mã Lô sản phẩm";
            this.Barcode.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Barcode.FieldName = "Barcode";
            this.Barcode.MinWidth = 200;
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = true;
            this.Barcode.VisibleIndex = 1;
            this.Barcode.Width = 250;
            // 
            // StepNo
            // 
            this.StepNo.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.StepNo.AppearanceCell.Options.UseFont = true;
            this.StepNo.AppearanceCell.Options.UseTextOptions = true;
            this.StepNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StepNo.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.StepNo.AppearanceHeader.Options.UseFont = true;
            this.StepNo.AppearanceHeader.Options.UseTextOptions = true;
            this.StepNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StepNo.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.StepNo.Caption = "Bước";
            this.StepNo.FieldName = "StepNo";
            this.StepNo.MaxWidth = 150;
            this.StepNo.MinWidth = 150;
            this.StepNo.Name = "StepNo";
            this.StepNo.Visible = true;
            this.StepNo.VisibleIndex = 2;
            this.StepNo.Width = 150;
            // 
            // ScanIn
            // 
            this.ScanIn.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ScanIn.AppearanceCell.Options.UseFont = true;
            this.ScanIn.AppearanceCell.Options.UseTextOptions = true;
            this.ScanIn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanIn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanIn.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ScanIn.AppearanceHeader.Options.UseFont = true;
            this.ScanIn.AppearanceHeader.Options.UseTextOptions = true;
            this.ScanIn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanIn.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanIn.Caption = "Thời gian đăng ký";
            this.ScanIn.ColumnEdit = this.repositoryItemMemoEdit1;
            this.ScanIn.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.ScanIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ScanIn.FieldName = "ScanIn";
            this.ScanIn.MaxWidth = 200;
            this.ScanIn.MinWidth = 200;
            this.ScanIn.Name = "ScanIn";
            this.ScanIn.Visible = true;
            this.ScanIn.VisibleIndex = 3;
            this.ScanIn.Width = 200;
            // 
            // Limit
            // 
            this.Limit.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Limit.AppearanceCell.Options.UseFont = true;
            this.Limit.AppearanceCell.Options.UseTextOptions = true;
            this.Limit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Limit.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Limit.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Limit.AppearanceHeader.Options.UseFont = true;
            this.Limit.AppearanceHeader.Options.UseTextOptions = true;
            this.Limit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Limit.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Limit.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Limit.Caption = "Thời gian kết thúc dự kiến";
            this.Limit.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Limit.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.Limit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Limit.FieldName = "Limit";
            this.Limit.MaxWidth = 200;
            this.Limit.MinWidth = 200;
            this.Limit.Name = "Limit";
            this.Limit.Visible = true;
            this.Limit.VisibleIndex = 4;
            this.Limit.Width = 200;
            // 
            // RemainingTime
            // 
            this.RemainingTime.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.RemainingTime.AppearanceCell.Options.UseFont = true;
            this.RemainingTime.AppearanceCell.Options.UseTextOptions = true;
            this.RemainingTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainingTime.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RemainingTime.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.RemainingTime.AppearanceHeader.Options.UseFont = true;
            this.RemainingTime.AppearanceHeader.Options.UseTextOptions = true;
            this.RemainingTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RemainingTime.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RemainingTime.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RemainingTime.Caption = "Thời gian còn lại";
            this.RemainingTime.DisplayFormat.FormatString = "hh:mm:ss";
            this.RemainingTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RemainingTime.FieldName = "RemainingTime";
            this.RemainingTime.MaxWidth = 150;
            this.RemainingTime.MinWidth = 150;
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Visible = true;
            this.RemainingTime.VisibleIndex = 5;
            this.RemainingTime.Width = 150;
            // 
            // ResultStatus
            // 
            this.ResultStatus.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ResultStatus.AppearanceCell.Options.UseFont = true;
            this.ResultStatus.AppearanceCell.Options.UseTextOptions = true;
            this.ResultStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ResultStatus.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ResultStatus.AppearanceHeader.Options.UseFont = true;
            this.ResultStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.ResultStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ResultStatus.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ResultStatus.Caption = "Kết quả sản xuất";
            this.ResultStatus.FieldName = "ResultStatus";
            this.ResultStatus.MaxWidth = 150;
            this.ResultStatus.MinWidth = 150;
            this.ResultStatus.Name = "ResultStatus";
            this.ResultStatus.Visible = true;
            this.ResultStatus.VisibleIndex = 6;
            this.ResultStatus.Width = 150;
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
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lsvLog);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(1098, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 706);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông báo";
            // 
            // lsvLog
            // 
            this.lsvLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvLog.FormattingEnabled = true;
            this.lsvLog.ItemHeight = 16;
            this.lsvLog.Location = new System.Drawing.Point(2, 32);
            this.lsvLog.Name = "lsvLog";
            this.lsvLog.Size = new System.Drawing.Size(274, 672);
            this.lsvLog.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 706);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDuLieu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1098, 503);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDataComplete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1098, 203);
            this.panel2.TabIndex = 3;
            // 
            // dgvDataComplete
            // 
            this.dgvDataComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataComplete.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgvDataComplete.Location = new System.Drawing.Point(0, 0);
            this.dgvDataComplete.MainView = this.ViewDataComplete;
            this.dgvDataComplete.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataComplete.Name = "dgvDataComplete";
            this.dgvDataComplete.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemButtonEdit2,
            this.repositoryItemMemoEdit2});
            this.dgvDataComplete.Size = new System.Drawing.Size(1098, 203);
            this.dgvDataComplete.TabIndex = 3;
            this.dgvDataComplete.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewDataComplete});
            // 
            // ViewDataComplete
            // 
            this.ViewDataComplete.Appearance.FocusedCell.BackColor = System.Drawing.Color.SkyBlue;
            this.ViewDataComplete.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.ViewDataComplete.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ViewDataComplete.Appearance.FocusedCell.Options.UseForeColor = true;
            this.ViewDataComplete.ColumnPanelRowHeight = 40;
            this.ViewDataComplete.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id1,
            this.PartNumber1,
            this.Barcode1,
            this.StepNo1,
            this.ScanIn1,
            this.ScanOut1,
            this.DryingTime1,
            this.CompletedStatus1});
            this.ViewDataComplete.DetailHeight = 284;
            this.ViewDataComplete.GridControl = this.dgvDataComplete;
            this.ViewDataComplete.IndicatorWidth = 40;
            this.ViewDataComplete.Name = "ViewDataComplete";
            this.ViewDataComplete.OptionsBehavior.Editable = false;
            this.ViewDataComplete.OptionsCustomization.AllowQuickHideColumns = false;
            this.ViewDataComplete.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.ViewDataComplete.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.ViewDataComplete.OptionsView.ShowGroupPanel = false;
            this.ViewDataComplete.OptionsView.ShowViewCaption = true;
            this.ViewDataComplete.RowHeight = 40;
            this.ViewDataComplete.ViewCaption = "Sản phẩm hoàn thành";
            this.ViewDataComplete.ViewCaptionHeight = 30;
            // 
            // Id1
            // 
            this.Id1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Id1.AppearanceCell.Options.UseFont = true;
            this.Id1.AppearanceCell.Options.UseTextOptions = true;
            this.Id1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Id1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Id1.AppearanceHeader.Options.UseFont = true;
            this.Id1.AppearanceHeader.Options.UseTextOptions = true;
            this.Id1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Id1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Id1.Caption = "Id";
            this.Id1.ColumnEdit = this.repositoryItemMemoEdit2;
            this.Id1.FieldName = "Id";
            this.Id1.Name = "Id1";
            this.Id1.Width = 100;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // PartNumber1
            // 
            this.PartNumber1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PartNumber1.AppearanceCell.Options.UseFont = true;
            this.PartNumber1.AppearanceCell.Options.UseTextOptions = true;
            this.PartNumber1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.PartNumber1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.PartNumber1.AppearanceHeader.Options.UseFont = true;
            this.PartNumber1.AppearanceHeader.Options.UseTextOptions = true;
            this.PartNumber1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.PartNumber1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PartNumber1.Caption = "Mã sản phẩm";
            this.PartNumber1.ColumnEdit = this.repositoryItemMemoEdit2;
            this.PartNumber1.FieldName = "PartNumber";
            this.PartNumber1.MaxWidth = 150;
            this.PartNumber1.MinWidth = 150;
            this.PartNumber1.Name = "PartNumber1";
            this.PartNumber1.Visible = true;
            this.PartNumber1.VisibleIndex = 0;
            this.PartNumber1.Width = 150;
            // 
            // Barcode1
            // 
            this.Barcode1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Barcode1.AppearanceCell.Options.UseFont = true;
            this.Barcode1.AppearanceCell.Options.UseTextOptions = true;
            this.Barcode1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Barcode1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Barcode1.AppearanceHeader.Options.UseFont = true;
            this.Barcode1.AppearanceHeader.Options.UseTextOptions = true;
            this.Barcode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Barcode1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Barcode1.Caption = "Mã Lô sản phẩm";
            this.Barcode1.ColumnEdit = this.repositoryItemMemoEdit2;
            this.Barcode1.FieldName = "Barcode";
            this.Barcode1.MinWidth = 200;
            this.Barcode1.Name = "Barcode1";
            this.Barcode1.Visible = true;
            this.Barcode1.VisibleIndex = 1;
            this.Barcode1.Width = 250;
            // 
            // StepNo1
            // 
            this.StepNo1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.StepNo1.AppearanceCell.Options.UseFont = true;
            this.StepNo1.AppearanceCell.Options.UseTextOptions = true;
            this.StepNo1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StepNo1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.StepNo1.AppearanceHeader.Options.UseFont = true;
            this.StepNo1.AppearanceHeader.Options.UseTextOptions = true;
            this.StepNo1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StepNo1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.StepNo1.Caption = "Bước";
            this.StepNo1.FieldName = "StepNo";
            this.StepNo1.MaxWidth = 150;
            this.StepNo1.MinWidth = 150;
            this.StepNo1.Name = "StepNo1";
            this.StepNo1.Visible = true;
            this.StepNo1.VisibleIndex = 2;
            this.StepNo1.Width = 150;
            // 
            // ScanIn1
            // 
            this.ScanIn1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ScanIn1.AppearanceCell.Options.UseFont = true;
            this.ScanIn1.AppearanceCell.Options.UseTextOptions = true;
            this.ScanIn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanIn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanIn1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ScanIn1.AppearanceHeader.Options.UseFont = true;
            this.ScanIn1.AppearanceHeader.Options.UseTextOptions = true;
            this.ScanIn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanIn1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanIn1.Caption = "Thời gian đăng ký";
            this.ScanIn1.ColumnEdit = this.repositoryItemMemoEdit2;
            this.ScanIn1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.ScanIn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ScanIn1.FieldName = "ScanIn";
            this.ScanIn1.MaxWidth = 200;
            this.ScanIn1.MinWidth = 200;
            this.ScanIn1.Name = "ScanIn1";
            this.ScanIn1.Visible = true;
            this.ScanIn1.VisibleIndex = 3;
            this.ScanIn1.Width = 200;
            // 
            // ScanOut1
            // 
            this.ScanOut1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ScanOut1.AppearanceCell.Options.UseFont = true;
            this.ScanOut1.AppearanceCell.Options.UseTextOptions = true;
            this.ScanOut1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanOut1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanOut1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ScanOut1.AppearanceHeader.Options.UseFont = true;
            this.ScanOut1.AppearanceHeader.Options.UseTextOptions = true;
            this.ScanOut1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ScanOut1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ScanOut1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ScanOut1.Caption = "Thời gian kết thúc";
            this.ScanOut1.ColumnEdit = this.repositoryItemMemoEdit2;
            this.ScanOut1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.ScanOut1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ScanOut1.FieldName = "ScanOut";
            this.ScanOut1.MaxWidth = 200;
            this.ScanOut1.MinWidth = 200;
            this.ScanOut1.Name = "ScanOut1";
            this.ScanOut1.Visible = true;
            this.ScanOut1.VisibleIndex = 4;
            this.ScanOut1.Width = 200;
            // 
            // DryingTime1
            // 
            this.DryingTime1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.DryingTime1.AppearanceCell.Options.UseFont = true;
            this.DryingTime1.AppearanceCell.Options.UseTextOptions = true;
            this.DryingTime1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DryingTime1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DryingTime1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.DryingTime1.AppearanceHeader.Options.UseFont = true;
            this.DryingTime1.AppearanceHeader.Options.UseTextOptions = true;
            this.DryingTime1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DryingTime1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.DryingTime1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DryingTime1.Caption = "Thời gian sản xuất";
            this.DryingTime1.FieldName = "DryingTime";
            this.DryingTime1.MaxWidth = 150;
            this.DryingTime1.MinWidth = 150;
            this.DryingTime1.Name = "DryingTime1";
            this.DryingTime1.Visible = true;
            this.DryingTime1.VisibleIndex = 5;
            this.DryingTime1.Width = 150;
            // 
            // CompletedStatus1
            // 
            this.CompletedStatus1.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.CompletedStatus1.AppearanceCell.Options.UseFont = true;
            this.CompletedStatus1.AppearanceCell.Options.UseTextOptions = true;
            this.CompletedStatus1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompletedStatus1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.CompletedStatus1.AppearanceHeader.Options.UseFont = true;
            this.CompletedStatus1.AppearanceHeader.Options.UseTextOptions = true;
            this.CompletedStatus1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CompletedStatus1.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.CompletedStatus1.Caption = "Kết quả sản xuất";
            this.CompletedStatus1.FieldName = "CompletedStatus";
            this.CompletedStatus1.MaxWidth = 150;
            this.CompletedStatus1.MinWidth = 150;
            this.CompletedStatus1.Name = "CompletedStatus1";
            this.CompletedStatus1.Visible = true;
            this.CompletedStatus1.VisibleIndex = 6;
            this.CompletedStatus1.Width = 150;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            // 
            // frmMonitoring
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pnControl);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonitoring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDataComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraGrid.GridControl dgvDuLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView viewDuLieu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ScanIn;
        private DevExpress.XtraGrid.Columns.GridColumn StepNo;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode;
        private DevExpress.XtraGrid.Columns.GridColumn ResultStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private System.Windows.Forms.Timer RefreshTimer;
        private DevExpress.XtraGrid.Columns.GridColumn Limit;
        private DevExpress.XtraGrid.Columns.GridColumn RemainingTime;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ListBox lsvLog;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblWarning;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl lblTimeOut;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl lblOK;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SimpleButton btnProductionHistory;
        private DevExpress.XtraEditors.LabelControl lblTimeNow;
        private DevExpress.XtraEditors.LabelControl lblProduction;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl dgvDataComplete;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewDataComplete;
        private DevExpress.XtraGrid.Columns.GridColumn Id1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn PartNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn Barcode1;
        private DevExpress.XtraGrid.Columns.GridColumn StepNo1;
        private DevExpress.XtraGrid.Columns.GridColumn ScanIn1;
        private DevExpress.XtraGrid.Columns.GridColumn ScanOut1;
        private DevExpress.XtraGrid.Columns.GridColumn DryingTime1;
        private DevExpress.XtraGrid.Columns.GridColumn CompletedStatus1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
    }
}