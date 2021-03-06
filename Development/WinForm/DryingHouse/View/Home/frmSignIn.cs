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
using DryingHouse.Persistence;
using DryingHouse.Persistence.Repositories;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.View.Home
{
    public partial class frmSignIn : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        UserRepository _userRepository;
        LanguageLibraryRepository _languageLibraryRepository;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
        }

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            _userRepository = new UserRepository(_projectDataContext);
            _languageLibraryRepository = new LanguageLibraryRepository(_projectDataContext);
            LoadLanguage(GlobalConstants.language);
            LanguageTranslate.ChangeLanguageForm(this);
            chkKeepMeSignedIn.Checked = Properties.Settings.Default.KeepMeSignedIn;
            if (chkKeepMeSignedIn.Checked)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
       

        private bool CheckData()
        {
            if(!_projectDataContext.CheckConnection(_projectDataContext))
            {  
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Kết nối tới máy chủ thất bại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtUsername.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            _userRepository.CheckSecurity(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (_userRepository.error)
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText(_userRepository.errorMessage), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;
            GlobalConstants.printerName = Properties.Settings.Default.PrinterName;
            GlobalConstants.portCOM = Properties.Settings.Default.PortCOM;
            GlobalConstants.languageLibrarys = _languageLibraryRepository.GetAll().ToList();
            GlobalConstants.language = Properties.Settings.Default.Language;
            GlobalConstants.controlAlarmDevice = Properties.Settings.Default.controlAlarmDevice;
            GlobalConstants.countTimeReset = Properties.Settings.Default.CountTimeReset;
            GlobalConstants.countTimeMonitor = Properties.Settings.Default.CountTimeMonitor;
            GlobalConstants.countLOT = Properties.Settings.Default.CountLOT;
            Properties.Settings.Default.KeepMeSignedIn = chkKeepMeSignedIn.Checked;
            if (chkKeepMeSignedIn.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text.Trim();
                Properties.Settings.Default.Password = txtPassword.Text.Trim();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
            }
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignIn_Click(null, null);
            }
        }

        private void LoadLanguage(int language)
        {
            GlobalConstants.language = language;
            Properties.Settings.Default.Language = GlobalConstants.language;
            Properties.Settings.Default.Save();
            if (language == (int)GlobalConstants.LanguageValue.English)
            {
                picEnglish.BackColor = Color.Yellow;
                picVietnamese.BackColor = Color.Transparent;
            }
            else
            {
                picVietnamese.BackColor = Color.Yellow;
                picEnglish.BackColor = Color.Transparent;
            }
        }

        private void picVietnamese_Click(object sender, EventArgs e)
        {
            LoadLanguage((int)GlobalConstants.LanguageValue.Vietnamese);
            LanguageTranslate.switchLanguage = true;
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.switchLanguage = false;
        }

        private void picEnglish_Click(object sender, EventArgs e)
        {
            LoadLanguage((int)GlobalConstants.LanguageValue.English);
            LanguageTranslate.switchLanguage = true;
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.switchLanguage = false;
        }
    }
}