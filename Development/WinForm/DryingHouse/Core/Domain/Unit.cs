using System;
using System.Collections.ObjectModel;

namespace DryingHouse.Core.Domain
{
    public class Unit : Base
    {
        #region Fields
        public string Id { get; set; }
        public string UnitName { get; set; }
        public string Note { get; set; }
        public GlobalConstants.StatusValue Status { get; set; }
        #endregion

        #region FK
        public Unit()
        {
            products = new ObservableCollection<Product>();
        }

        public virtual ObservableCollection<Product> products { get; set; }
        #endregion
    }
}
