using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DryingHouse.Core.Domain
{
    public class StockOut : Base
    {
        #region Fields
        public string Id { get; set; }
        public DateTime ScanDate { get; set; }
        public string PartNumber { get; set; }
        public string Barcode { get; set; }
        public string UserID { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
