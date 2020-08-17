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
using DryingHouse.Persistence.Repositories;
using DryingHouse.Core;
using DryingHouse.Core.Helper;
using DryingHouse.Core.Domain;
using System.Drawing.Printing;
using System.IO.Ports;

namespace DryingHouse.View.Home
{
    public partial class frmSetting : DevExpress.XtraEditors.XtraForm
    {
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

        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            LanguageTranslate.ChangeLanguageForm(this);
            LoadPrinter(); 
            LoadPortCOM();
            txtCompany.Text = Properties.Settings.Default.Company;
            txtAddress.Text = Properties.Settings.Default.Address;
            txtPhone.Text = Properties.Settings.Default.Phone;
            cbbPrinter.Text = Properties.Settings.Default.PrinterName;
            cbbPortCOM.Text = Properties.Settings.Default.PortCOM;
            chkMustUseBarcodeReader.Checked = Properties.Settings.Default.MustUseBarcodeReader;
            txtCountTimeReset.Value = Properties.Settings.Default.CountTimeReset;
            txtCountTimeMonitor.Value = Properties.Settings.Default.CountTimeMonitor;
        }

        private void LoadPrinter()
        {
            cbbPrinter.Items.Clear();
            try
            {
                cbbPrinter.Items.Add("");
                foreach (string installedPrinters in PrinterSettings.InstalledPrinters)
                {
                    cbbPrinter.Items.Add(installedPrinters);
                }
            }
            catch { }
        }

        public void LoadPortCOM()
        {
            cbbPortCOM.Items.Clear();
            try
            {
                cbbPortCOM.Items.Add("");
                foreach (string portName in SerialPort.GetPortNames())
                {
                    cbbPortCOM.Items.Add(portName);
                }
            }
            catch { }
        }

        private bool CheckData()
        {
            if (txtCompany.Text.Trim() == "")
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Chưa điền dữ liệu"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompany.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckData()) return;
            Properties.Settings.Default.Company = txtCompany.Text.Trim();
            Properties.Settings.Default.Address = txtAddress.Text.Trim();
            Properties.Settings.Default.Phone = txtPhone.Text.Trim();
            Properties.Settings.Default.PrinterName = cbbPrinter.Text.Trim();
            Properties.Settings.Default.PortCOM = cbbPortCOM.Text.Trim();
            Properties.Settings.Default.MustUseBarcodeReader = chkMustUseBarcodeReader.Checked;
            Properties.Settings.Default.CountTimeReset = (int)txtCountTimeReset.Value;
            Properties.Settings.Default.CountTimeMonitor = (int)txtCountTimeMonitor.Value;
            Properties.Settings.Default.Save();

            GlobalConstants.printerName = Properties.Settings.Default.PrinterName;
            GlobalConstants.portCOM = Properties.Settings.Default.PortCOM;
            GlobalConstants.language = Properties.Settings.Default.Language;
            GlobalConstants.mustUseBarcodeReader = Properties.Settings.Default.MustUseBarcodeReader;
            GlobalConstants.countTimeReset = Properties.Settings.Default.CountTimeReset;
            GlobalConstants.countTimeMonitor = Properties.Settings.Default.CountTimeMonitor;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}