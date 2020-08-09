using DryingHouse.Core.Domain;
using Registration.Core.License;
using System;
using System.Collections.Generic;
using System.Data;

namespace DryingHouse.Core
{
    public class GlobalConstants
    {
        #region Default Values
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger("ScanBarcode");
        public static string keySoft = "DryingHouse";
        public static string saltSoft = "O12ab88cKh@nh";
        public static kLicense license;
        public static string userID = "";
        public static string username = "";
        public static string fullName = "";
        public static string printerName = "Printer";
        public static string portCOM = "COM1";
        public static int language = 0;
        public static bool mustUseBarcodeReader = false;
        public static int timeDelay = 5;
        public static int countTimeReset = 5;
        public static List<LanguageLibrary> languageLibrarys = new List<LanguageLibrary>();
        public static int defaultSaltLength = 5;
        public static bool debugMode = true;
        public enum GenderValue { Female, Male }
        public enum StatusValue { NoUse, Using }
        public enum RequestScanValue { No, Yes }
        public enum ResultStatusValue { Processing, OK, Timeless, Timeout }
        public enum CompletedStatusValue { None, OK, NG }
        public enum LanguageValue { Vietnamese, English }
        public enum ControlSerialData { Error, Warning, Reset }
        
        #endregion
    }
}
