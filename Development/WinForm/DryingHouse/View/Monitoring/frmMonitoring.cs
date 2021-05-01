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
using System.IO.Ports;
using DryingHouse.Core.Domain;
using DryingHouse.Persistence.Repositories;
using DryingHouse.Core.Helper;
using DryingHouse.Core;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace DryingHouse.View.Monitoring
{
    public partial class frmMonitoring : DevExpress.XtraEditors.XtraForm
    {
        public frmMonitoring()
        {
            InitializeComponent();
        }
        ProjectDataContext _projectDataContext;
        ScanBarcodeRepository _scanBarcodeRepository;
        AlarmRepository _alarmRepository;
        StepRepository _stepRepository;
        SerialPort _serialPort;
        int timer = 0;
        int _countOK = 0;
        int _countTimeOut = 0;
        int _countWarning = 0;
        int _countProduction = 0;
        List<Step> _step;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
            ControlDevice(GlobalConstants.ControlSerialData.Off);
            _serialPort.Dispose();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Close();
            Dispose();
        }

        private void frmMonitoring_Load(object sender, EventArgs e)
        {
            //LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageForm(this);
            LanguageTranslate.ChangeLanguageGridView(viewDuLieu);
            LanguageTranslate.ChangeLanguageGridView(ViewDataComplete);
            _projectDataContext = new ProjectDataContext();
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
            _serialPort = new SerialPort();
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            Control.CheckForIllegalCrossThreadCalls = false;
            if (GlobalConstants.controlAlarmDevice == true)
            {
                ClosePortCOM(GlobalConstants.portCOM);
                OpenPortCOM(GlobalConstants.portCOM, 9600);
                ControlDevice(GlobalConstants.ControlSerialData.Reset);
                RemoveAllAlarm();
            }
           
            GetStepName();
            GetDataMonitor();
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer++;
            
            if (GlobalConstants.controlAlarmDevice  == true)
            {
                GetAlarmData();
            }
            
            if (timer >= GlobalConstants.countTimeReset)
            {
                GetDataMonitor();
                timer = 0;
            }
        }
        private void GetStepName()
        {
            _step = new List<Step>();
            _projectDataContext = new ProjectDataContext();
            _stepRepository = new StepRepository(_projectDataContext);
            _step = _stepRepository.GetAll().ToList();
        }
        private void GetDataMonitor()
        {
            _projectDataContext = new ProjectDataContext();
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
            var ScanData = _scanBarcodeRepository.GetScanBarcodesMonitoring(GlobalConstants.countTimeMonitor)
                .Where(w=>w.CompletedStatus == GlobalConstants.CompletedStatusValue.None);


            var DataMonitor = (from _ in ScanData
                               join p in _step on _.StepNo equals p.StepNo into grp
                               from p2 in grp.DefaultIfEmpty()
                               select new
                               {
                                   StepName = (p2 == null?  string.Empty : p2.StepName), 
                                   PartNumber = _.PartNumber,
                                   Barcode = _.Barcode,
                                   StepNo = _.StepNo,
                                   ScanIn = _.ScanIn,
                                   Limit = _.Limit,
                                   RemainingTime = (((TimeSpan)(_.Limit - DateTime.Now)) < TimeSpan.Zero ? "-" : "") + ((TimeSpan)(_.Limit - DateTime.Now)).ToString("hh\\:mm\\:ss"),
                                   ResultStatus = _.ResultStatus
                               }).OrderBy(o => TimeSpan.Parse(o.RemainingTime)).ToList();

            _countOK = DataMonitor.Where(w => w.StepNo == 5 && TimeSpan.Parse(w.RemainingTime).TotalSeconds <= 0).Count();
            _countTimeOut = DataMonitor.Where(w => TimeSpan.Parse(w.RemainingTime).TotalSeconds < -5*60).Count();
            _countWarning = DataMonitor.Where(
                w => TimeSpan.Parse(w.RemainingTime).TotalSeconds > 0 && 
                TimeSpan.Parse(w.RemainingTime).TotalSeconds <= 600).Count();
            _countProduction = DataMonitor.Count - _countOK - _countTimeOut - _countWarning;
            dgvDuLieu.DataSource = DataMonitor;
            ControlDisplay();

            //var DataFinished = _scanBarcodeRepository.GetScanBarcodesMonitoring(Properties.Settings.Default.CountTimeMonitor)
            //    .Where(w => w.CompletedStatus == GlobalConstants.CompletedStatusValue.OK).OrderByDescending(o => o.ScanOut);
            //var DataFinished = _scanBarcodeRepository.GetScanBarcodesMonitoring(Properties.Settings.Default.CountTimeMonitor)
            //    .Where(w => w.CompletedStatus == GlobalConstants.CompletedStatusValue.OK).OrderByDescending(o => o.ScanOut);

            var DataFinished = _scanBarcodeRepository.GetScanBarcodesFinish(24)
                                    .OrderByDescending(o => o.ScanOut);


            dgvDataComplete.DataSource = DataFinished;
            
        }
        //private void GetDataFinished()
        //{
        //    _projectDataContext = new ProjectDataContext();
        //    _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
        //    var DataFinished = _scanBarcodeRepository.GetScanBarcodesFinish(Properties.Settings.Default.CountTimeMonitor);
        //    var ResultFinished = (from _ in DataFinished
        //                       select new
        //                       {
        //                           PartNumber = _.PartNumber,
        //                           Barcode = _.Barcode,
        //                           StepNo = _.StepNo,
        //                           ScanIn = _.ScanIn,
        //                           Limit = _.Limit,
        //                           RemainingTime = (_.Limit - DateTime.Now).ToString(),
        //                           ResultStatus = _.ResultStatus
        //                       }).OrderBy(o => TimeSpan.Parse(o.RemainingTime)).ToList();

            

        //    dgvDataComplete.DataSource = ResultFinished;
        //}
        private void GetAlarmData()
        {
            _projectDataContext = new ProjectDataContext();
            _alarmRepository = new AlarmRepository(_projectDataContext);
            try
            {
                var _alarmData = _alarmRepository.GetAll().OrderByDescending(o=>o.AlarmDate).FirstOrDefault();
                if (_alarmData != null)
                {
                    ControlDevice(_alarmData.AlarmStatus);
                    lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + _alarmData.Message);
                    _alarmRepository.Remove(_alarmData.Id);
                    UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                    int result = unitOfWork.Complete();
                }
            }
            catch (Exception ex)
            {
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + ex.ToString());
                GlobalConstants.log.Debug(ex.ToString());
            }
        }
        private void RemoveAllAlarm ()
        {
            _projectDataContext = new ProjectDataContext();
            _alarmRepository = new AlarmRepository(_projectDataContext);
            try
            {
                var _alarmData = _alarmRepository.GetAll();
                _alarmRepository.RemoveRange(_alarmData);
                UnitOfWork unitOfWork = new UnitOfWork(_projectDataContext);
                int result = unitOfWork.Complete();
            }
            catch (Exception ex)
            {
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + ex.ToString());
                GlobalConstants.log.Debug(ex.ToString());
            }
        }
        private void ControlDisplay()
        {
            lblOK.Text = _countOK.ToString();
            lblTimeOut.Text = _countTimeOut.ToString();
            lblWarning.Text = _countWarning.ToString();
            lblProduction.Text = _countProduction.ToString();
        }
        
        private void ClosePortCOM(string _portname)
        {
            _serialPort.PortName = _portname;
            try
            {
                if (_serialPort.IsOpen == true)
                {
                    _serialPort.Close();
                    lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + "Đóng cổng COM thành công" + "(" + _portname + "");
                    GlobalConstants.log.Debug("Dong cong COM thanh cong" + "(" + _portname + ")");
                }
            }
            catch (Exception ex)
            {
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - Đóng cổng COM thất bại");
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + ex.ToString());
                GlobalConstants.log.Debug("Dong cong COM that bai" + "(" + _portname + ")" + ex.ToString());
            }
        }
        private void OpenPortCOM(string _portname, int _baudrate)
        {
            _serialPort.PortName = _portname;
            _serialPort.BaudRate = _baudrate;
            try
            {
                if (_serialPort.IsOpen == false)
                {
                    _serialPort.Open();
                    lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + "Mở cổng COM thành công" + "(" + _portname + "");
                    GlobalConstants.log.Debug("Mo cong COM thanh cong" + "(" + _portname + ")");
                }
            }
            catch (Exception ex)
            {
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + "Mở cổng COM thất bại");
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - " + ex.ToString());
                GlobalConstants.log.Error("Mo cong COM that bai. " + ex.ToString());
            }
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _serialPort.ReadExisting();
            
            lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - DataReceived: " + data);
            GlobalConstants.log.Debug(DateTime.Now.ToString("dd/MM HH:mm:ss") + " - DataReceived: " + data);
            data = "";
        }
        private void ControlDevice(GlobalConstants.ControlSerialData _ControlDevice)
        {
            if (_serialPort.IsOpen == true)
            {
                GlobalConstants.ControlSerialData data;
                if (_ControlDevice == GlobalConstants.ControlSerialData.Reset)
                    data = GlobalConstants.ControlSerialData.Reset;
                else if (_ControlDevice == GlobalConstants.ControlSerialData.Warning)
                    data = GlobalConstants.ControlSerialData.Warning;
                else if (_ControlDevice == GlobalConstants.ControlSerialData.Error)
                    data = GlobalConstants.ControlSerialData.Error;
                else
                    data = GlobalConstants.ControlSerialData.Off;

                _serialPort.Write(((int)data).ToString());
                GlobalConstants.log.Debug(data);
            }
            else
            {
                GlobalConstants.log.Error("Khong ket noi duoc voi thiet bi");
                lsvLog.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + "Không kết nối được thiết bị ");
            }
        }

        private void viewDuLieu_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void viewDuLieu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;

                string RemainingTime = Convert.ToString(View.GetRowCellValue(e.RowHandle, View.Columns["RemainingTime"]));
                int StepNo = Convert.ToInt16(View.GetRowCellValue(e.RowHandle, View.Columns["StepNo"]));
                double RangeTime = TimeSpan.Parse(RemainingTime).TotalSeconds;
                if (StepNo == 5 && RangeTime <= 0)
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                }
                else
                {
                    if (RangeTime < -5*60)
                    {
                        e.Appearance.BackColor = Color.Red;
                    }
                    else if (RangeTime >= -5 * 60 && RangeTime <= 0)
                    {
                        e.Appearance.BackColor = Color.LightGreen;
                    }
                    else if (RangeTime > 0 && RangeTime <= 600)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                    }
                }

            }
        }

        private void btnProductionHistory_Click(object sender, EventArgs e)
        {
            Monitoring.frmProductionHistory frm = new Monitoring.frmProductionHistory();
            frm.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ControlDevice(GlobalConstants.ControlSerialData.Reset);
        }

        private void ViewDataComplete_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView View = sender as GridView;
                int ResultStatus = Convert.ToInt16(View.GetRowCellValue(e.RowHandle, View.Columns["CompletedStatus"]));
                if (ResultStatus == (int)GlobalConstants.CompletedStatusValue.OK)
                {
                    e.Appearance.BackColor = Color.GreenYellow;
                }
                else if (ResultStatus == (int)GlobalConstants.CompletedStatusValue.NG)
                {
                    e.Appearance.BackColor = Color.Tomato;
                }
            }
        }

        private string FormatTimeSpan(TimeSpan time)
        {
            return ((time < TimeSpan.Zero) ? "-" : "") + time.ToString("hh\\:mm\\:ss");
        }
    }
}