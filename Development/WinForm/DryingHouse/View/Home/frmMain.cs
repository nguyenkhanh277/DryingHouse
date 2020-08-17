using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DryingHouse.Core;
using DryingHouse.Core.Helper;
using DryingHouse.Persistence;
using DryingHouse.Persistence.Repositories;
using DryingHouse.View.Monitoring;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DryingHouse.View.Home
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        #region SkinGallery
        void InitSkinGallery()
        {
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void rgbiSkins_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {

            Properties.Settings.Default.Theme = e.Item.Value.ToString();
            Properties.Settings.Default.Save();
        }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository(_projectDataContext);
            this.Icon = Properties.Resources.icon;
            this.Text = LanguageTranslate.ChangeLanguageText(this.Text);
            Translate();
            Permission();
            ribbonControl1.SelectPage(rbpChucNang);
            if (_userRepository.CheckOperator(GlobalConstants.username, "OperatorProduction"))
            {
                btnMonitoring_ItemClick(null, null);
            }
            else if (_userRepository.CheckOperator(GlobalConstants.username, "OperatorResult"))
            {
                btnResult_ItemClick(null, null);
            }
        }

        private void Translate()
        {
            btnUsers.Caption = LanguageTranslate.ChangeLanguageText(btnUsers.Caption);
            btnChangePassword.Caption = LanguageTranslate.ChangeLanguageText(btnChangePassword.Caption);
            btnLanguageLibrary.Caption = LanguageTranslate.ChangeLanguageText(btnLanguageLibrary.Caption);
            btnSetting.Caption = LanguageTranslate.ChangeLanguageText(btnSetting.Caption);
            btnProduct.Caption = LanguageTranslate.ChangeLanguageText(btnProduct.Caption);
            btnUnit.Caption = LanguageTranslate.ChangeLanguageText(btnUnit.Caption);
            btnMonitoring.Caption = LanguageTranslate.ChangeLanguageText(btnMonitoring.Caption);
            btnScanBarcodePullOut.Caption = LanguageTranslate.ChangeLanguageText(btnScanBarcodePullOut.Caption);
            btnProductionHistory.Caption = LanguageTranslate.ChangeLanguageText(btnProductionHistory.Caption);
            btnProductReportOK.Caption = LanguageTranslate.ChangeLanguageText(btnProductReportOK.Caption);
            btnProductReportNG.Caption = LanguageTranslate.ChangeLanguageText(btnProductReportNG.Caption);
            btnReportSynthetic.Caption = LanguageTranslate.ChangeLanguageText(btnReportSynthetic.Caption);
            rbpHeThong.Text = LanguageTranslate.ChangeLanguageText(rbpHeThong.Text);
            rbpDanhMuc.Text = LanguageTranslate.ChangeLanguageText(rbpDanhMuc.Text);
            rbpChucNang.Text = LanguageTranslate.ChangeLanguageText(rbpChucNang.Text);
            rbpBaoCao.Text = LanguageTranslate.ChangeLanguageText(rbpBaoCao.Text);
            txtUser.Caption = LanguageTranslate.ChangeLanguageText("Tài khoản") + ": " + GlobalConstants.username + "  |  " + LanguageTranslate.ChangeLanguageText("Tên đầy đủ") + ": " + GlobalConstants.fullName;
        }

        private void Permission()
        {
            btnUsers.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "User", "View");
            btnLanguageLibrary.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Language", "View");
            btnSetting.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Setting", "View");
            btnProduct.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "PartNumber", "View");
            btnUnit.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Mold", "View");
            btnMonitoring.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "RegistBarcode", "View");
            btnScanBarcodePullOut.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "Result", "View");
            btnProductionHistory.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ProductionHistory", "View");
            btnProductReportOK.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "QuantityOfProductsOK", "View");
            btnProductReportNG.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "QuantityOfProductsNG", "View");
            btnReportSynthetic.Enabled = _userRepository.CheckPermission(GlobalConstants.username, "ReportSyntheticRegistBarcode", "View");
        }

        private XtraForm CheckExist(Type fType)
        {
            foreach (XtraForm f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Users.frmUsers));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Users.frmUsers f = new Users.frmUsers();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnLanguageLibrary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(LanguageLibraries.frmLanguageLibrary));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                LanguageLibraries.frmLanguageLibrary f = new LanguageLibraries.frmLanguageLibrary();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }

        private void btnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Units.frmUnit));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Units.frmUnit f = new Units.frmUnit();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnStep_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Steps.frmStep));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Steps.frmStep f = new Steps.frmStep();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Products.frmProduct));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Products.frmProduct f = new Products.frmProduct();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnProductMatrix_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(ProductMatrices.frmProductMatrix));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                ProductMatrices.frmProductMatrix f = new ProductMatrices.frmProductMatrix();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnRegistPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(RegistBarcodes.frmRegistBarcode));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                RegistBarcodes.frmRegistBarcode f = new RegistBarcodes.frmRegistBarcode();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void btnResult_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Productions.frmResult frm = new Productions.frmResult();
            //frm.ShowDialog();
        }

        private void btnProductionHistory_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = this.CheckExist(typeof(Monitoring.frmProductionHistory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Monitoring.frmProductionHistory f = new Monitoring.frmProductionHistory();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnProductReportOK_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XtraForm frm = this.CheckExist(typeof(Reports.frmProductReportOK));
            //if (frm != null)
            //{
            //    frm.Activate();
            //}
            //else
            //{
            //    Reports.frmProductReportOK f = new Reports.frmProductReportOK();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }

        private void btnProductReportNG_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XtraForm frm = this.CheckExist(typeof(Reports.frmProductReportNG));
            //if (frm != null)
            //{
            //    frm.Activate();
            //}
            //else
            //{
            //    Reports.frmProductReportNG f = new Reports.frmProductReportNG();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }

        private void btnReportSynthetic_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XtraForm frm = this.CheckExist(typeof(Reports.frmReportSynthetic));
            //if (frm != null)
            //{
            //    frm.Activate();
            //}
            //else
            //{
            //    Reports.frmReportSynthetic f = new Reports.frmReportSynthetic();
            //    f.MdiParent = this;
            //    f.Show();
            //}
        }

        private void btnMonitoring_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMonitoring frm = new frmMonitoring();
            frm.ShowDialog();
        }
    }
}
