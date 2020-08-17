using DryingHouse.Core.Domain;
using DryingHouse.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.Persistence.Repositories
{
    public class StockOutRepository : Repository<StockOut>
    {
        public string id = "";

        public StockOutRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(StockOut stockOut)
        {
            if (String.IsNullOrEmpty(stockOut.Id))
            {
                stockOut.Id = GetAutoID();
                stockOut.CreatedAt = DateTime.Now;
                stockOut.CreatedBy = GlobalConstants.username;
                Add(stockOut);
                id = stockOut.Id;
            }
            else
            {
                Update(stockOut);
            }
        }

        public void Update(StockOut stockOut)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(stockOut.Id));
                if (raw != null)
                {
                    raw.CollectInformation(stockOut);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    id = raw.Id;
                }
            }
            catch (Exception ex)
            {
                error = true;
                errorMessage = ex.ToString();
            }
        }

        public string GetAutoID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}