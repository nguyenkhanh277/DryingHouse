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
        SerialPort _serialPort;
        int timer = 0;
        int _countOK = 0;
        int _countTimeOut = 0;
        int _countWarning = 0;
        int _countProduction = 0;

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            _projectDataContext.Dispose();
            _serialPort.Dispose();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMonitoring_Load(object sender, EventArgs e)
        {
            //LanguageTranslate.ChangeLanguageForm(this);
            _projectDataContext = new ProjectDataContext();
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
            _serialPort = new SerialPort();
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            Control.CheckForIllegalCrossThreadCalls = false;
            ClosePortCOM(GlobalConstants.portCOM);
            OpenPortCOM(GlobalConstants.portCOM, 9600);
            GetDataMonitor();
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer++;
            GetAlarmData();
            if (timer >= GlobalConstants.countTimeReset)
            {
                GetDataMonitor();
                timer = 0;
            }
        }
        private void GetDataMonitor()
        {
            _projectDataContext = new ProjectDataContext();
            _scanBarcodeRepository = new ScanBarcodeRepository(_projectDataContext);
            var ScanData = _scanBarcodeRepository.GetScanBarcodesMonitoring(Properties.Settings.Default.CountTimeMonitor)
                .Where(w=>w.CompletedStatus == GlobalConstants.CompletedStatusValue.None);

            var DataMonitor = (from _ in ScanData
                               select new
                               {
                                   PartNumber = _.PartNumber,
                                   Barcode = _.Barcode,
                                   StepNo = _.StepNo,
                                   ScanIn = _.ScanIn,
                                   Limit = _.Limit,
                                   RemainingTime = (_.Limit - DateTime.Now).ToString(),
                                   ResultStatus = _.ResultStatus
                               }).OrderBy(o => TimeSpan.Parse(o.RemainingTime)).ToList();

            _countOK = DataMonitor.Where(w => w.StepNo == 5 && TimeSpan.Parse(w.RemainingTime).TotalSeconds <= 0).Count();
            _countTimeOut = DataMonitor.Where(w => TimeSpan.Parse(w.RemainingTime).TotalSeconds < 0).Count();
            _countWarning = DataMonitor.Where(
                w => TimeSpan.Parse(w.RemainingTime).TotalSeconds > 60 && 
                TimeSpan.Parse(w.RemainingTime).TotalSeconds <= 600).Count();
            _countProduction = DataMonitor.Count - _countOK - _countTimeOut - _countWarning;
            dgvDuLieu.DataSource = DataMonitor;
            ControlDisplay();


            var DataFinished = _scanBarcodeRepository.GetScanBarcodesMonitoring(Properties.Settings.Default.CountTimeMonitor)
                .Where(w => w.CompletedStatus == GlobalConstants.CompletedStatusValue.OK).OrderByDescending(o => o.ScanOut);

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
                var _alarmData = _alarmRepository.GetAll().SingleOrDefault();
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
                else
                    data = GlobalConstants.ControlSerialData.Error;

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
                //string RemainingTime = Convert.ToString(View.GetRowCellDisplayText(e.RowHandle, View.Columns["RemainingTime"]));
                //int StepNo = Convert.ToInt16(View.GetRowCellDisplayText(e.RowHandle, View.Columns["StepNo"]));

                string RemainingTime = Convert.ToString(View.GetRowCellValue(e.RowHandle, View.Columns["RemainingTime"]));
                int StepNo = Convert.ToInt16(View.GetRowCellValue(e.RowHandle, View.Columns["StepNo"]));
                double RangeTime = TimeSpan.Parse(RemainingTime).TotalSeconds;
                if (StepNo == 5 && RangeTime <= 0)
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
                else
                {
                    if (RangeTime < 0)
                    {
                        e.Appearance.BackColor = Color.Red;
                    }
                    //else if (RangeTime >= 0 && RangeTime <= 60)
                    //{
                    //    e.Appearance.BackColor = Color.LightGreen;
                    //}
                    else if (RangeTime > 0 && RangeTime <= 600)
                    {
                        e.Appearance.BackColor = Color.Orange;
                    }
                }

            }
        }

        private void btnProductionHistory_Click(object sender, EventArgs e)
        {
            Monitoring.frmProductionHistory frm = new Monitoring.frmProductionHistory();
            frm.ShowDialog();
        }
    }
}