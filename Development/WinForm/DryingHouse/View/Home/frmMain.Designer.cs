using DevExpress.XtraBars;

namespace DryingHouse.View.Home
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.txtUser = new DevExpress.XtraBars.BarStaticItem();
            this.btnLanguageLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnMonitoring = new DevExpress.XtraBars.BarButtonItem();
            this.btnScanBarcodePullOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnit = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductionHistory = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductReportOK = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductReportNG = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportSynthetic = new DevExpress.XtraBars.BarButtonItem();
            this.btnSetting = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegistPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnStep = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductMatrix = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnShipment = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barStaticItem1);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnUsers,
            this.btnChangePassword,
            this.txtUser,
            this.btnLanguageLibrary,
            this.rgbiSkins,
            this.btnMonitoring,
            this.btnScanBarcodePullOut,
            this.btnUnit,
            this.btnProduct,
            this.btnProductionHistory,
            this.btnProductReportOK,
            this.btnProductReportNG,
            this.btnReportSynthetic,
            this.btnSetting,
            this.btnRegistPrint,
            this.btnStep,
            this.btnProductMatrix,
            this.barButtonItem1,
            this.btnShipment});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 49;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.txtUser);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpDanhMuc,
            this.rbpChucNang,
            this.rbpBaoCao});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1183, 178);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Copyright by Datatech.vn - Phone: 08 8822 2329 - Email: contact@datatech.vn";
            this.barStaticItem1.Id = 42;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Quản lý người dùng";
            this.btnUsers.Id = 11;
            this.btnUsers.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.Users;
            this.btnUsers.LargeWidth = 100;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 12;
            this.btnChangePassword.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ChangePassword;
            this.btnChangePassword.LargeWidth = 100;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // txtUser
            // 
            this.txtUser.Caption = "     ";
            this.txtUser.Id = 18;
            this.txtUser.Name = "txtUser";
            // 
            // btnLanguageLibrary
            // 
            this.btnLanguageLibrary.Caption = "Ngôn ngữ";
            this.btnLanguageLibrary.Id = 19;
            this.btnLanguageLibrary.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.Translate;
            this.btnLanguageLibrary.LargeWidth = 100;
            this.btnLanguageLibrary.Name = "btnLanguageLibrary";
            this.btnLanguageLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLanguageLibrary_ItemClick);
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Skins";
            // 
            // 
            // 
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = true;
            this.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rgbiSkins.Id = 13;
            this.rgbiSkins.Name = "rgbiSkins";
            this.rgbiSkins.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiSkins_GalleryItemClick);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Caption = "Giám sát trạng thái";
            this.btnMonitoring.Id = 26;
            this.btnMonitoring.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.Machine;
            this.btnMonitoring.LargeWidth = 100;
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonitoring_ItemClick);
            // 
            // btnScanBarcodePullOut
            // 
            this.btnScanBarcodePullOut.Caption = "Quét mã vạch xuất kho SP sấy";
            this.btnScanBarcodePullOut.Id = 27;
            this.btnScanBarcodePullOut.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ScanBarcode;
            this.btnScanBarcodePullOut.LargeWidth = 100;
            this.btnScanBarcodePullOut.Name = "btnScanBarcodePullOut";
            this.btnScanBarcodePullOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResult_ItemClick);
            // 
            // btnUnit
            // 
            this.btnUnit.Caption = "Danh sách ĐVT";
            this.btnUnit.Id = 32;
            this.btnUnit.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.Mold;
            this.btnUnit.LargeWidth = 115;
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnit_ItemClick);
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Quản lý sản phẩm";
            this.btnProduct.Id = 34;
            this.btnProduct.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ScanBarcodeOK;
            this.btnProduct.LargeWidth = 100;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnProductionHistory
            // 
            this.btnProductionHistory.Caption = "Lịch sử sản xuất";
            this.btnProductionHistory.Id = 35;
            this.btnProductionHistory.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ProductionHistory;
            this.btnProductionHistory.LargeWidth = 100;
            this.btnProductionHistory.Name = "btnProductionHistory";
            this.btnProductionHistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductionHistory_ItemClick);
            // 
            // btnProductReportOK
            // 
            this.btnProductReportOK.Caption = "Thống kê sản phẩm OK";
            this.btnProductReportOK.Id = 36;
            this.btnProductReportOK.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ScanBarcodeOK;
            this.btnProductReportOK.LargeWidth = 100;
            this.btnProductReportOK.Name = "btnProductReportOK";
            this.btnProductReportOK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductReportOK_ItemClick);
            // 
            // btnProductReportNG
            // 
            this.btnProductReportNG.Caption = "Thống kê sản phẩm NG";
            this.btnProductReportNG.Id = 37;
            this.btnProductReportNG.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ScanBarcodeNG;
            this.btnProductReportNG.LargeWidth = 100;
            this.btnProductReportNG.Name = "btnProductReportNG";
            this.btnProductReportNG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductReportNG_ItemClick);
            // 
            // btnReportSynthetic
            // 
            this.btnReportSynthetic.Caption = "Báo cáo tổng hợp";
            this.btnReportSynthetic.Id = 38;
            this.btnReportSynthetic.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.ReportSyntheticRegistBarcode;
            this.btnReportSynthetic.LargeWidth = 100;
            this.btnReportSynthetic.Name = "btnReportSynthetic";
            this.btnReportSynthetic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportSynthetic_ItemClick);
            // 
            // btnSetting
            // 
            this.btnSetting.Caption = "Cấu hình";
            this.btnSetting.Id = 41;
            this.btnSetting.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ImageOptions.LargeImage")));
            this.btnSetting.LargeWidth = 100;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSetting_ItemClick);
            // 
            // btnRegistPrint
            // 
            this.btnRegistPrint.Caption = "In mã vạch";
            this.btnRegistPrint.Id = 43;
            this.btnRegistPrint.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.RegistBarcode;
            this.btnRegistPrint.LargeWidth = 100;
            this.btnRegistPrint.Name = "btnRegistPrint";
            this.btnRegistPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegistPrint_ItemClick);
            // 
            // btnStep
            // 
            this.btnStep.Caption = "Bước sấy";
            this.btnStep.Id = 44;
            this.btnStep.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.Step;
            this.btnStep.LargeWidth = 100;
            this.btnStep.Name = "btnStep";
            this.btnStep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStep_ItemClick);
            // 
            // btnProductMatrix
            // 
            this.btnProductMatrix.Caption = "Quản lý giờ sấy";
            this.btnProductMatrix.Id = 45;
            this.btnProductMatrix.ImageOptions.LargeImage = global::DryingHouse.Properties.Resources.Matrix;
            this.btnProductMatrix.LargeWidth = 100;
            this.btnProductMatrix.Name = "btnProductMatrix";
            this.btnProductMatrix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductMatrix_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 46;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnShipment
            // 
            this.btnShipment.Caption = "Lịch sử xuất hàng";
            this.btnShipment.Id = 48;
            this.btnShipment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShipment.ImageOptions.Image")));
            this.btnShipment.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShipment.ImageOptions.LargeImage")));
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShipment_ItemClick);
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLanguageLibrary);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSetting);
            this.ribbonPageGroup1.ItemLinks.Add(this.rgbiSkins);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rbpDanhMuc
            // 
            this.rbpDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpDanhMuc.Name = "rbpDanhMuc";
            this.rbpDanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnUnit);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnStep);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnProductMatrix);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rbpChucNang
            // 
            this.rbpChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbpChucNang.Name = "rbpChucNang";
            this.rbpChucNang.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRegistPrint);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMonitoring);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProductionHistory);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnShipment);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductReportOK);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductReportNG);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReportSynthetic);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 466);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Chương trình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem btnUsers;
        private BarButtonItem btnChangePassword;
        private BarStaticItem txtUser;
        private BarButtonItem btnLanguageLibrary;
        private RibbonGalleryBarItem rgbiSkins;
        private BarButtonItem btnMonitoring;
        private BarButtonItem btnScanBarcodePullOut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem btnUnit;
        private BarButtonItem btnProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private BarButtonItem btnProductionHistory;
        private BarButtonItem btnProductReportOK;
        private BarButtonItem btnProductReportNG;
        private BarButtonItem btnReportSynthetic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private BarButtonItem btnSetting;
        private BarStaticItem barStaticItem1;
        private BarButtonItem btnRegistPrint;
        private BarButtonItem btnStep;
        private BarButtonItem btnProductMatrix;
        private BarButtonItem barButtonItem1;
        private BarButtonItem btnShipment;
    }
}

