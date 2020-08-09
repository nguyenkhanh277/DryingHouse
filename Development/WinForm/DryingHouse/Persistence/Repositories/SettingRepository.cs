using DryingHouse.Core.Domain;
using DryingHouse.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.Persistence.Repositories
{
    public class SettingRepository : Repository<Setting>
    {
        public string id = "";

        public SettingRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Setting setting)
        {
            if (String.IsNullOrEmpty(setting.Id))
            {
                setting.Id = GetAutoID();
                setting.CreatedAt = DateTime.Now;
                setting.CreatedBy = GlobalConstants.username;
                Add(setting);
                id = setting.Id;
            }
            else
            {
                Update(setting);
            }
        }

        public void Update(Setting setting)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(setting.Id));
                if (raw != null)
                {
                    raw.CollectInformation(setting);
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