using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DryingHouse.Core.Domain
{
    public class Alarm : Base
    {
        #region Fields
        public string Id { get; set; }
        public string Barcode { get; set; }
        public string PartNumber { get; set; }
        public int StepNo { get; set; }
        public DateTime AlarmDate { get; set; }
        public GlobalConstants.ControlSerialData AlarmStatus { get; set; }
        #endregion
    }
}
