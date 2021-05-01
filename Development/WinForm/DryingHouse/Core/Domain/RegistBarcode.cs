using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DryingHouse.Core.Domain
{
    public class RegistBarcode : Base
    {
        #region Fields
        public string Id { get; set; }
        public DateTime RegistDate { get; set; }
        public string PartNumber { get; set; }
        public string SEQ { get; set; }
        public string LOT { get; set; }
        public string Quantity { get; set; }
        public string Barcode { get; set; }
        public string UserID { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
