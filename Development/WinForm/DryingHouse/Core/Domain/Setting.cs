using System;
using System.Collections.ObjectModel;

namespace DryingHouse.Core.Domain
{
    public class Setting : Base
    {
        #region Fields
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public float DungSai { get; set; }
        #endregion
    }
}
