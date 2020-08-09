using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DryingHouse.Core.Domain
{
    public class ProductMatrix : Base
    {
        #region Fields
        public string Id { get; set; }
        public string PartNumber { get; set; }
        public int StepNo { get; set; }
        public float DryingTime { get; set; }
        #endregion
    }
}
