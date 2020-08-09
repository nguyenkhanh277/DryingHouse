using DryingHouse.Core.Domain;
using DryingHouse.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using DryingHouse.Core;
using DryingHouse.Core.Helper;

namespace DryingHouse.Persistence.Repositories
{
    public class StepRepository : Repository<Step>
    {
        public string id = "";

        public StepRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Step step)
        {
            if (String.IsNullOrEmpty(step.Id))
            {
                step.Id = GetAutoID();
                step.CreatedAt = DateTime.Now;
                step.CreatedBy = GlobalConstants.username;
                Add(step);
                id = step.Id;
            }
            else
            {
                Update(step);
            }
        }

        public void Update(Step step)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(step.Id));
                if (raw != null)
                {
                    raw.CollectInformation(step);
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