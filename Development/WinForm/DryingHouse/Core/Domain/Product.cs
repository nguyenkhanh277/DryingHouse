using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DryingHouse.Core.Domain
{
    public class Product : Base
    {
        #region Fields
        public string Id { get; set; }
        public string PartNumber { get; set; }
        public string ProductName { get; set; }
        public string UnitId { get; set; }
        [NotMapped]
        public string UnitName { get; set; }
        public int NumberOfLOT { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion
    }
}
