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
using DryingHouse.Core.Domain;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.View.Steps
{
    public partial class frmStepAddEdit : DevExpress.XtraEditors.XtraForm
    {
        ProjectDataContext _projectDataContext = new ProjectDataContext();
        StepRepository _stepRepository;

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

        public frmStepAddEdit()
        {
            InitializeComponent();
        }

        public frmStepAddEdit(bool quickAdd)
        {
            InitializeComponent();
            _quickAdd = quickAdd;
        }

        public frmStepAddEdit(string id)
        {
            InitializeComponent();
            _id = id;
        }

        private void frmStepAddEdit_Load(object sender, EventArgs e)
        {
            _stepRepository = new StepRepository(_projectDataContext);
            LanguageTranslate.ChangeLanguageForm(this);
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
            txtStepNo.Value = txtStepNo.Value + 1;
            txtStepName.Text = "";
            txtNote.Text = "";
            chkRequestScanInYes.Checked = true;
            chkRequestScanOutYes.Checked = true;
            chkUsing.Checked = true;
            txtStepNo.Focus();
        }

        private void GetData()
        {
            //Get Data Table Step
            Step step = _stepRepository.Get(_id);
            txtStepNo.Value = step.StepNo;
            txtStepName.Text = step.StepName;
            txtNote.Text = step.Note;
            chkUsing.Checked = (step.Status == GlobalConstants.StatusValue.Using);
        }

        private bool CheckData()
        {
            int stepNo = (int)txtStepNo.Value;
            Step step = _stepRepository.FirstOrDefault(_ => _.StepNo.Equals(stepNo));
            if (step != null &&
                (
                    String.IsNullOrEmpty(_id) ||
                    (!String.IsNullOrEmpty(_id) && stepNo != step.StepNo)
                ))
            {
                XtraMessageBox.Show(LanguageTranslate.ChangeLanguageText("Dữ liệu đã tồn tại"), LanguageTranslate.ChangeLanguageText("Thông báo"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStepNo.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckData()) return;
                //Table Step
                Step step = new Step();
                step.Id = _id;
                step.StepNo = (int)txtStepNo.Value;
                step.StepName = txtStepName.Text.Trim();
                step.RequestScanIn = (chkRequestScanInYes.Checked ? GlobalConstants.RequestScanValue.Yes : GlobalConstants.RequestScanValue.No);
                step.RequestScanOut = (chkRequestScanOutYes.Checked ? GlobalConstants.RequestScanValue.Yes : GlobalConstants.RequestScanValue.No);
                step.Note = txtNote.Text.Trim();
                step.Status = (chkUsing.Checked ? GlobalConstants.StatusValue.Using : GlobalConstants.StatusValue.NoUse);
                _stepRepository.Save(step);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
                if (result > 0)
                {
                    if (String.IsNullOrEmpty(_id))
                    {
                        if (_quickAdd)
                        {
                            this.Tag = txtStepNo.Text.Trim();
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
    }
}