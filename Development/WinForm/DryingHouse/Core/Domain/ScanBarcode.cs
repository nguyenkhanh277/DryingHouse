using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DryingHouse.Core.Domain
{
    public class ScanBarcode : Base
    {
        #region Fields
        public string Id { get; set; }
        public string Barcode { get; set; }
        public string PartNumber { get; set; }
        public int StepNo { get; set; }
        public DateTime ScanIn { get; set; }
        public DateTime? Limit { get; set; }
        public DateTime? ScanOut { get; set; }
        public float DryingTime { get; set; }
        public GlobalConstants.ResultStatusValue ResultStatus { get; set; }
        public GlobalConstants.CompletedStatusValue CompletedStatus { get; set; }
        public string Reason { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
