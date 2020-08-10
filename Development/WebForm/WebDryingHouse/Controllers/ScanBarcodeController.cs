using WebDryingHouse.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDryingHouse.Controllers
{
    public class ScanBarcodeController : Controller
    {
        ConnectionManagement _connectionManagement = new ConnectionManagement();
        DbBusiness _dbBusiness = new DbBusiness();
        enum ResultStatusValue { Processing, OK, Timeless, Timeout }
        enum CompletedStatusValue { None, OK, NG }
        enum RequestScanValue { No, Yes }
        enum StatusValue { NoUse, Using }
        string _reason = "";
        string _username = "";
        string _barcode = "";
        string _partNumber = "";
        string _placeNo = "";
        string _scanInOut = "";
        float _dungSai = 5;

        string _scanBarcodeIdCurrent = "";
        int _stepNoCurrent = 0;
        float _dryingTimeCurrent = 0;
        DateTime _timeStartCurrent = new DateTime();
        DateTime _timeEndCurrent = new DateTime();
        TimeSpan _timeSpanCurrent = new TimeSpan();
        float _dryingTimeActualCurrent = 0;
        int _resultStatusActualCurrent = 0;

        string _scanBarcodeIdPrev = "";
        int _stepNoPrev = 0;
        float _dryingTimePrev = 0;
        DateTime _timeStartPrev = new DateTime();
        DateTime _timeEndPrev = new DateTime();
        TimeSpan _timeSpanPrev = new TimeSpan();
        float _dryingTimeActualPrev = 0;
        int _resultStatusActualPrev = 0;

        int _stepNoNext = 0;
        float _dryingTimeNext = 0;
        int _completedStatus = 0;

        string _result = "NG";
        string _description = "";

        public ActionResult Index(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult End(string username, string placeNo, string barcode, string result, string message)
        {
            ViewBag.username = username;
            ViewBag.placeNo = placeNo;
            ViewBag.barcode = barcode;
            ViewBag.result = result;
            ViewBag.message = message;
            return View();
        }

        public ActionResult Continue(string username, string placeNo, string barcode, string result, string message)
        {
            ViewBag.username = username;
            ViewBag.placeNo = placeNo;
            ViewBag.barcode = barcode;
            ViewBag.result = result;
            ViewBag.message = message;
            return View();
        }

        [ActionName("Scan_Barcode")]
        public ActionResult Scan_Barcode(string username, string placeNo, string barcode, string reason)
        {
            _dungSai = _dbBusiness.GetDungSai(_connectionManagement.GetDefaultConnection());
            _username = username;
            _placeNo = placeNo;
            _reason = reason;
            string[] place = _placeNo.Split('-');
            if (String.IsNullOrEmpty(placeNo) || place.Length != 2 || !int.TryParse(place[0], out _stepNoCurrent))
            {
                _description += "KHONG TIM THAY VI TRI." + Environment.NewLine;
            }
            else
            {
                _stepNoPrev = _stepNoCurrent - 1;
                _stepNoNext = _stepNoCurrent + 1;
                _scanInOut = place[1];
                _barcode = barcode;
                if (VerifyProduct())
                {
                    if (VerifyProductMatrixPrev())
                    {
                        if (VerifyTimePrev())
                        {
                            if (VerifyProductMatrixCurrent())
                            {
                                if (VerifyTimeCurrent())
                                {
                                    VerifyProductMatrixNext();
                                    if (WriteData())
                                    {
                                        _result = "OK";
                                        if (_scanInOut == "In")//Vị trí scan là đầu vào
                                        {
                                            _description += "Vi tri tiep theo la " + _stepNoCurrent + "-Out." + Environment.NewLine;
                                        }
                                        else//Vị trí scan là đầu ra
                                        {
                                            _description += "Vi tri tiep theo la " + _stepNoNext + "-In." + Environment.NewLine;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return Content(_result + "#" + _description);
        }

        private bool VerifyProduct()
        {
            bool result = false;
            DataTable product = _dbBusiness.GetProduct(_barcode, _connectionManagement.GetDefaultConnection());
            if (product.Rows.Count == 0)
            {
                _description += "KHONG TIM THAY SAN PHAM " + _barcode + "." + Environment.NewLine;
            }
            else
            {
                _partNumber = product.Rows[0]["PartNumber"].ToString();
                result = true;
            }
            return result;
        }

        private bool VerifyProductMatrixPrev()
        {
            bool result = true;
            if (_stepNoPrev > 0)
            {
                DataTable productMatrixPrev = _dbBusiness.GetProductMatrix(_partNumber, _stepNoPrev.ToString(), _connectionManagement.GetDefaultConnection());
                //Bước trước không yêu cầu scan thì sẽ tự động kết thúc
                if (productMatrixPrev.Rows.Count > 0 && int.Parse(productMatrixPrev.Rows[0]["RequestScanOut"].ToString()) == (int)RequestScanValue.No)
                {
                    //Lấy thời gian sấy bước trước
                    _dryingTimePrev = float.Parse(productMatrixPrev.Rows[0]["DryingTime"].ToString());
                }
                else//Bước trước yêu cầu phải scan
                {
                    DataTable scanBarcodePrev = _dbBusiness.GetScanBarcode(_barcode, "", _connectionManagement.GetDefaultConnection());
                    if (scanBarcodePrev.Rows.Count > 0 && scanBarcodePrev.Rows[0]["StepNo"].ToString() == _stepNoCurrent.ToString())
                    {

                    }
                    else
                    {
                        result = false;
                        _description += "KHONG DUNG VI TRI." + Environment.NewLine;
                        if (scanBarcodePrev.Rows.Count > 0)
                        {
                            if (scanBarcodePrev.Rows[0]["ScanOut"].ToString() != "")
                                _description += "Vi tri phai la " + (int.Parse(scanBarcodePrev.Rows[0]["StepNo"].ToString()) + 1) + "-In." + Environment.NewLine;
                            else if (scanBarcodePrev.Rows[0]["ScanOut"].ToString() == "")
                                _description += "Vi tri phai la " + scanBarcodePrev.Rows[0]["StepNo"].ToString() + "-Out." + Environment.NewLine;
                            else
                                _description += "Vi tri phai la " + scanBarcodePrev.Rows[0]["StepNo"].ToString() + "-In." + Environment.NewLine;
                        }
                        else
                            _description += "Vi tri phai la 1-In." + Environment.NewLine;
                    }
                }
            }
            return result;
        }

        private bool VerifyTimePrev()
        {
            bool result = true;
            if (_stepNoPrev > 0)
            {
                DataTable scanBarcodePrev = _dbBusiness.GetScanBarcode(_barcode, _stepNoPrev.ToString(), _connectionManagement.GetDefaultConnection());
                if (scanBarcodePrev.Rows.Count == 0)//Bước trước chưa được nhập
                {
                    result = false;
                    _description += "KHONG DUNG VI TRI." + Environment.NewLine;
                    scanBarcodePrev = _dbBusiness.GetScanBarcode(_barcode, "", _connectionManagement.GetDefaultConnection());
                    if (scanBarcodePrev.Rows.Count > 0)
                    {
                        if (scanBarcodePrev.Rows[0]["ScanOut"].ToString() != "")
                            _description += "Vi tri phai la " + (int.Parse(scanBarcodePrev.Rows[0]["StepNo"].ToString()) + 1) + "-In." + Environment.NewLine;
                        else if (scanBarcodePrev.Rows[0]["ScanOut"].ToString() == "")
                            _description += "Vi tri phai la " + scanBarcodePrev.Rows[0]["StepNo"].ToString() + "-Out." + Environment.NewLine;
                        else
                            _description += "Vi tri phai la " + scanBarcodePrev.Rows[0]["StepNo"].ToString() + "-In." + Environment.NewLine;
                    }
                    else
                        _description += "Vi tri phai la 1-In." + Environment.NewLine;
                }
                else if (scanBarcodePrev.Rows.Count > 0 && scanBarcodePrev.Rows[0]["ScanOut"].ToString() == "")//Bước trước chưa kết thúc
                {
                    //Tính thời gian sấy bước trước
                    _timeStartPrev = DateTime.Parse(scanBarcodePrev.Rows[0]["ScanIn"].ToString());
                    _timeEndPrev = DateTime.Now;
                    _timeSpanPrev = _timeEndPrev - _timeStartPrev;
                    _dryingTimeActualPrev = float.Parse(_timeSpanPrev.TotalMinutes.ToString("N0"));
                    _scanBarcodeIdPrev = scanBarcodePrev.Rows[0]["Id"].ToString();
                    //So sánh thời gian sấy thực tế > thời gian sấy yêu cầu + dung sai -> Quá thời gian
                    if (_dryingTimeActualPrev > _dryingTimePrev + _dungSai)
                    {
                        _description += "San pham say QUA thoi gian." + Environment.NewLine;
                        _description += "So thoi gian say thuc te: " + _dryingTimeActualPrev + "." + Environment.NewLine;
                        _description += "So thoi gian yeu cau say: " + _dryingTimePrev + "." + Environment.NewLine;
                        _description += "Thoi gian bat dau say: " + _timeStartPrev.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Thoi gian ket thuc say: " + _timeEndPrev.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _resultStatusActualPrev = (int)ResultStatusValue.Timeout;
                        if (String.IsNullOrEmpty(_reason))
                            result = false;
                    }
                    else if (_dryingTimeActualPrev < _dryingTimePrev - _dungSai)//So sánh thời gian sấy thực tế < thời gian sấy yêu cầu - dung sai -> Thiếu thời gian
                    {
                        _description += "San pham say THIEU thoi gian." + Environment.NewLine;
                        _description += "So thoi gian say thuc te: " + _dryingTimeActualPrev + "." + Environment.NewLine;
                        _description += "So thoi gian yeu cau say: " + _dryingTimePrev + "." + Environment.NewLine;
                        _description += "Thoi gian bat dau say: " + _timeStartPrev.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Thoi gian ket thuc say: " + _timeEndPrev.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _resultStatusActualPrev = (int)ResultStatusValue.Timeless;
                        if (String.IsNullOrEmpty(_reason))
                            result = false;
                    }
                    else
                    {
                        _resultStatusActualPrev = (int)ResultStatusValue.OK;
                    }
                }
            }
            return result;
        }

        private bool VerifyProductMatrixCurrent()
        {
            bool result = true;
            DataTable productMatrix = _dbBusiness.GetProductMatrix(_partNumber, _stepNoCurrent.ToString(), _connectionManagement.GetDefaultConnection());
            //Không tìm thấy bước hiện tại
            if (productMatrix.Rows.Count == 0)
            {
                _description += "KHONG TIM THAY BUOC SAY cua san pham " + _partNumber + "." + Environment.NewLine;
                result = false;
            }
            else
            {
                //Lấy thời gian sấy bước hiện tại
                _dryingTimeCurrent = float.Parse(productMatrix.Rows[0]["DryingTime"].ToString());
            }
            return result;
        }

        private bool VerifyTimeCurrent()
        {
            bool result = false;
            DataTable scanBarcodeCurrent = _dbBusiness.GetScanBarcode(_barcode, _stepNoCurrent.ToString(), _connectionManagement.GetDefaultConnection());
            if (_scanInOut == "In")//Vị trí scan là đầu vào
            {
                if (scanBarcodeCurrent.Rows.Count > 0 && scanBarcodeCurrent.Rows[0]["ScanIn"].ToString() != "")//Bước sấy đã được nhập rồi thì không cho scan lần 2
                {
                    _description += "KHONG DUNG VI TRI." + Environment.NewLine;
                    _description += "Vi tri phai la " + _stepNoCurrent + "-Out." + Environment.NewLine;
                }
                else
                {
                    result = true;
                }
            }
            else//Vị trí scan là đầu ra
            {
                if (scanBarcodeCurrent.Rows.Count == 0)//Bước sấy chưa được nhập
                {
                    _description += "KHONG DUNG VI TRI." + Environment.NewLine;
                    _description += "Vi tri phai la " + _stepNoCurrent + "-In." + Environment.NewLine;
                }
                else if (scanBarcodeCurrent.Rows.Count > 0 && scanBarcodeCurrent.Rows[0]["ScanOut"].ToString() != "")//Bước sấy đã được kết thúc rồi thì không cho scan lần 2
                {
                    _description += "KHONG DUNG VI TRI." + Environment.NewLine;
                    _description += "Vi tri phai la " + _stepNoNext + "-In." + Environment.NewLine;
                }
                else
                {
                    //Tính thời gian sấy bước trước
                    _timeStartCurrent = DateTime.Parse(scanBarcodeCurrent.Rows[0]["ScanIn"].ToString());
                    _timeEndCurrent = DateTime.Now;
                    _timeSpanCurrent = _timeEndCurrent - _timeStartCurrent;
                    _dryingTimeActualCurrent = float.Parse(_timeSpanCurrent.TotalMinutes.ToString("N0"));
                    _scanBarcodeIdCurrent = scanBarcodeCurrent.Rows[0]["Id"].ToString();
                    //So sánh thời gian sấy thực tế > thời gian sấy yêu cầu + dung sai -> Quá thời gian
                    if (_dryingTimeActualCurrent > _dryingTimeCurrent + _dungSai)
                    {
                        _description += "San pham bi say QUA thoi gian." + Environment.NewLine;
                        _description += "So thoi gian say thuc te: " + _dryingTimeActualCurrent + "." + Environment.NewLine;
                        _description += "So thoi gian yeu cau say: " + _dryingTimeCurrent + "." + Environment.NewLine;
                        _description += "Thoi gian bat dau say: " + _timeStartCurrent.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Thoi gian ket thuc say: " + _timeEndCurrent.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _resultStatusActualCurrent = (int)ResultStatusValue.Timeout;
                        if (!String.IsNullOrEmpty(_reason))
                            result = true;
                    }
                    else if (_dryingTimeActualCurrent < _dryingTimeCurrent - _dungSai)//So sánh thời gian sấy thực tế < thời gian sấy yêu cầu - dung sai -> Thiếu thời gian
                    {
                        _description += "San pham bi say THIEU thoi gian." + Environment.NewLine;
                        _description += "So thoi gian say thuc te: " + _dryingTimeActualCurrent + "." + Environment.NewLine;
                        _description += "So thoi gian yeu cau say: " + _dryingTimeCurrent + "." + Environment.NewLine;
                        _description += "Thoi gian bat dau say: " + _timeStartCurrent.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Thoi gian ket thuc say: " + _timeEndCurrent.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _resultStatusActualCurrent = (int)ResultStatusValue.Timeless;
                        if (!String.IsNullOrEmpty(_reason))
                            result = true;
                    }
                    else
                    {
                        _resultStatusActualCurrent = (int)ResultStatusValue.OK;
                        result = true;
                    }
                }
            }
            return result;
        }

        private void VerifyProductMatrixNext()
        {
            if (_stepNoNext > 0)
            {
                DataTable productMatrixNext = _dbBusiness.GetProductMatrix(_partNumber, _stepNoNext.ToString(), _connectionManagement.GetDefaultConnection());
                //Không còn bước sau thì sẽ kết thúc
                if (productMatrixNext.Rows.Count == 0)
                {
                    _stepNoNext = 0;
                    _completedStatus = (int)CompletedStatusValue.OK;
                }
                //Bước sau không yêu cầu scan thì sẽ tự động nhập
                else if (productMatrixNext.Rows.Count > 0 && int.Parse(productMatrixNext.Rows[0]["RequestScanIn"].ToString()) == (int)RequestScanValue.No)
                {
                    //Lấy thời gian sấy bước sau
                    _dryingTimeNext = float.Parse(productMatrixNext.Rows[0]["DryingTime"].ToString());
                    if(_stepNoNext == 5 && _dryingTimeNext == 0)
                    {
                        _stepNoNext = 0;
                        _completedStatus = (int)CompletedStatusValue.OK;
                    }
                }
                else//Bước sau yêu cầu phải scan
                {
                    _stepNoNext = 0;
                }
            }
        }

        private bool WriteData()
        {
            bool result = false;
            //int completedStatus = (int)CompletedStatusValue.None;
            if (!String.IsNullOrEmpty(_reason) && _reason.Contains("Ket thuc:"))
            {
                _completedStatus = (int)CompletedStatusValue.NG;
            }
            if (_scanInOut == "In")//Vị trí scan là đầu vào
            {
                if (_dbBusiness.ScanIn(_barcode, _partNumber, _stepNoCurrent, _dryingTimeActualCurrent, (int)ResultStatusValue.Processing, (int)CompletedStatusValue.None, (int)StatusValue.Using, _username, _scanBarcodeIdPrev, _timeEndPrev, _dryingTimeActualPrev, _resultStatusActualPrev, "Automatic", _connectionManagement.GetDefaultConnection()))
                    result = true;
                else
                    _description += "Xac nhan san pham say that bai." + Environment.NewLine;
            }
            else//Vị trí scan là đầu ra
            {
                if (!String.IsNullOrEmpty(_scanBarcodeIdCurrent) && _dbBusiness.ScanOut(_scanBarcodeIdCurrent, _timeEndCurrent, _dryingTimeActualCurrent, _resultStatusActualCurrent, _reason, _completedStatus, _username, _barcode, _partNumber, _stepNoNext, _dryingTimeNext, (int)ResultStatusValue.Processing, (int)CompletedStatusValue.None, (int)StatusValue.Using, _connectionManagement.GetDefaultConnection()))
                    result = true;
                else
                {
                    if (!String.IsNullOrEmpty(_reason) && _reason.Contains("Ket thuc:"))
                        _description += "Xac nhan ket thuc san pham say that bai." + Environment.NewLine;
                    else
                        _description += "Xac nhan san pham say that bai." + Environment.NewLine;
                }
            }
            return result;
        }
    }
}