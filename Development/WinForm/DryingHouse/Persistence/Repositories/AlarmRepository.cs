using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DryingHouse.Core;
using DryingHouse.Core.Domain;

namespace DryingHouse.Persistence.Repositories
{
    public class AlarmRepository : Repository<Alarm>
    {
        public string id = "";

        public AlarmRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Alarm alarm)
        {
            if (String.IsNullOrEmpty(alarm.Id))
            {
                alarm.Id = GetAutoID();
                alarm.CreatedAt = DateTime.Now;
                alarm.CreatedBy = GlobalConstants.username;
                Add(alarm);
                id = alarm.Id;
            }
            else
            {
                Update(alarm);
            }
        }

        public void Update(Alarm alarm)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(alarm.Id));
                if (raw != null)
                {
                    raw.CollectInformation(alarm);
                    raw.EditedAt = DateTime.Now;
                    raw.EditedBy = GlobalConstants.username;
                    this.id = raw.Id;
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
