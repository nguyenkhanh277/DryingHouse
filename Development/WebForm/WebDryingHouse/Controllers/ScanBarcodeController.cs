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
        enum ResultStatusValue { Processing, OK, NG, Timeless }
        ConnectionManagement _connectionManagement = new ConnectionManagement();
        DbBusiness _dbBusiness = new DbBusiness();
        string _username = "";
        string _scanBarcodeId = "";
        string _placeNo = "";
        int _stepNo = -1;
        string _scanInOut = "";
        string _barcode = "";
        string _partNumber = "";
        float _dryingTime = 0;
        DateTime _timeStart = new DateTime();
        DateTime _timeEnd = new DateTime();
        float _dryingTimeActual = 0;
        int _resultStatusActual = 0;
        DataTable _productMatrixs = new DataTable();
        int _currentStep = 0;
        float _dungSai = 5;
        TimeSpan timeSpan = new TimeSpan();

        string _result = "NG";
        string _description = "";

        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Scan_Barcode")]
        public ActionResult Scan_Barcode(string username, string placeNo, string barcode, string continues)
        {
            _dungSai = _dbBusiness.GetDungSai(_connectionManagement.GetDefaultConnection());
            _username = username;
            _placeNo = placeNo;
            string[] place = _placeNo.Split('-');
            if (String.IsNullOrEmpty(placeNo) || place.Length != 2)
            {
                _description += "Khong tim thay vi tri." + Environment.NewLine;
            }
            else
            {
                _stepNo = int.Parse(place[0]);
                _scanInOut = place[1];
                _barcode = barcode;
                if (VerifyProduct())
                {
                    if (VerifyStep())
                    {
                        if (VerifyProductMatrix())
                        {
                            if (!String.IsNullOrEmpty(continues) || VerifyTime())
                            {
                                if (WriteData())
                                {
                                    if (VerifyNextStep())
                                    {
                                        _result = "OK";
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
                _description += "Khong tim thay san pham " + _barcode + "." + Environment.NewLine;
            }
            else
            {
                _partNumber = product.Rows[0]["PartNumber"].ToString();
                result = true;
            }
            return result;
        }

        private bool VerifyStep()
        {
            bool result = false;
            DataTable scanBarcode = _dbBusiness.GetCurrentStep(_barcode, _connectionManagement.GetDefaultConnection());
            if (scanBarcode.Rows.Count == 0)//Chưa sấy lần nào
            {
                _currentStep = 1;
            }
            else//Đã từng sấy
            {
                _currentStep = int.Parse(scanBarcode.Rows[0]["StepNo"].ToString());
            }
            if (_currentStep != _stepNo)//So sánh bước sấy yêu cầu và bước sấy thực tế
            {
                _description += "Khong dung buoc say." + Environment.NewLine;
                _description += "Buoc say yeu cau la " + _currentStep + "." + Environment.NewLine;
                _description += "Buoc say thuc te la " + _stepNo + "." + Environment.NewLine;
            }
            else//Khớp bước sấy
            {
                if (_scanInOut == "In")//Vị trí sấy là đầu vào
                {
                    if (scanBarcode.Rows.Count > 0 && scanBarcode.Rows[0]["ScanIn"].ToString() != "")//Kiểm tra đã scan đầu vào rồi thì không cho scan lần 2
                    {
                        _description += "San pham nay da scan vi tri nay." + Environment.NewLine;
                        _description += "Thoi gian bat dau say: " + DateTime.Parse(scanBarcode.Rows[0]["ScanIn"].ToString()).ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Buoc say tiep theo phai la " + _currentStep + "-Out." + Environment.NewLine;
                    }
                    else
                    {
                        result = true;
                    }
                }
                else//Vị trí sấy là đầu ra
                {
                    if (scanBarcode.Rows.Count == 0)//Kiểm tra chưa scan lần nào thì phải bắt đầu ở scan đầu vào
                    {
                        _description += "Khong dung vi tri." + Environment.NewLine;
                        _description += "Vi tri yeu cau la " + _currentStep + "-In." + Environment.NewLine;
                        _description += "Vi tri thuc te la " + _placeNo + "." + Environment.NewLine;
                    }
                    else if (scanBarcode.Rows[0]["ScanOut"].ToString() != "")//Kiểm tra đã scan đầu ra rồi thì không cho scan lần 2
                    {
                        _description += "San pham nay da scan vi tri nay." + Environment.NewLine;
                        _description += "Thoi gian bat dau say: " + DateTime.Parse(scanBarcode.Rows[0]["ScanIn"].ToString()).ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Thoi gian ket thuc say: " + DateTime.Parse(scanBarcode.Rows[0]["ScanOut"].ToString()).ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                        _description += "Buoc say tiep theo phai la " + (_currentStep + 1) + "-In." + Environment.NewLine;
                    }
                    else
                    {
                        _timeStart = DateTime.Parse(scanBarcode.Rows[0]["ScanIn"].ToString());
                        _timeEnd = DateTime.Now;
                        timeSpan = _timeEnd - _timeStart;
                        _dryingTimeActual = float.Parse(timeSpan.TotalMinutes.ToString("N0"));
                        _scanBarcodeId = scanBarcode.Rows[0]["Id"].ToString();
                        result = true;
                    }
                }
            }
            return result;
        }

        private bool VerifyProductMatrix()
        {
            bool result = false;
            _productMatrixs = _dbBusiness.GetProductMatrix(_partNumber, _currentStep.ToString(), _connectionManagement.GetDefaultConnection());
            if (_productMatrixs.Rows.Count == 0)
            {
                _description += "Khong tim thay buoc say cua san pham " + _partNumber + "." + Environment.NewLine;
            }
            else
            {
                _dryingTime = float.Parse(_productMatrixs.Rows[0]["DryingTime"].ToString());
                result = true;
            }
            return result;
        }

        private bool VerifyTime()
        {
            bool result = false;
            if (_scanInOut == "In")
            {
                result = true;
            }
            else
            {
                if (_dryingTime + _dungSai < _dryingTimeActual)
                {
                    _description += "San pham bi say qua thoi gian." + Environment.NewLine;
                    _description += "Thoi gian bat dau say: " + _timeStart.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                    _description += "Thoi gian ket thuc say: " + _timeEnd.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                    _description += "So thoi gian say thuc te: " + _dryingTimeActual + "." + Environment.NewLine;
                    _description += "So thoi gian yeu cau say: " + _dryingTime + "." + Environment.NewLine;
                }
                else if (_dryingTimeActual < _dryingTime - _dungSai)
                {
                    _description += "San pham bi say thieu thoi gian." + Environment.NewLine;
                    _description += "Thoi gian bat dau say: " + _timeStart.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                    _description += "Thoi gian ket thuc say: " + _timeEnd.ToString("dd/MM/yy HH:mm") + "." + Environment.NewLine;
                    _description += "So thoi gian say thuc te: " + _dryingTimeActual + "." + Environment.NewLine;
                    _description += "So thoi gian yeu cau say: " + _dryingTime + "." + Environment.NewLine;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        private bool WriteData()
        {
            bool result = false;
            if (_scanInOut == "In")//Vị trí sấy là đầu vào
            {
                if (_dbBusiness.ScanIn(_barcode, _partNumber, _currentStep.ToString(), (int)ResultStatusValue.Processing, _username, _connectionManagement.GetDefaultConnection()))
                {
                    result = true;
                }
                else
                {
                    _description += "Xac nhan san pham say that bai." + Environment.NewLine;
                }
            }
            else//Vị trí sấy là đầu ra
            {
                if (_dbBusiness.ScanOut(_scanBarcodeId, _timeEnd, _dryingTimeActual, _resultStatusActual, _username, _connectionManagement.GetDefaultConnection()))
                {
                    result = true;
                }
                else
                {
                    _description += "Xac nhan san pham say that bai." + Environment.NewLine;
                }
            }
            return result;
        }

        private bool VerifyNextStep()
        {
            return true;
        }
    }
}