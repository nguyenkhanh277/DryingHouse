using DryingHouse.Core.Domain;
using DryingHouse.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using DryingHouse.Core;
using DryingHouse.Core.Helper;
using System.Threading;
using System.Data;

namespace DryingHouse.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public string id = "";

        public ProductRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(Product product)
        {
            if (String.IsNullOrEmpty(product.Id))
            {
                product.Id = GetAutoID();
                product.CreatedAt = DateTime.Now;
                product.CreatedBy = GlobalConstants.username;
                Add(product);
                id = product.Id;
            }
            else
            {
                Update(product);
            }
        }

        public void Update(Product product)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(product.Id));
                if (raw != null)
                {
                    raw.CollectInformation(product);
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

        public List<Product> GetList()
        {
            var query = from x in ProjectDataContext.Products
                        join y in ProjectDataContext.Units on x.UnitId equals y.Id
                        select new { x, y };

            List<Product> products = new List<Product>();
            Product product = new Product();
            if (query.Any())
            {
                foreach (var item in query)
                {
                    product = new Product();
                    product.Id = item.x.Id;
                    product.PartNumber = item.x.PartNumber;
                    product.ProductName = item.x.ProductName;
                    product.UnitId = item.x.UnitId;
                    product.UnitName = item.y.UnitName;
                    product.NumberOfLOT = item.x.NumberOfLOT;
                    product.Note = item.x.Note;
                    product.Status = item.x.Status;
                    products.Add(product);
                }
            }
            return products;
        }

        public List<Product> GetListCombobox()
        {
            var query = from x in ProjectDataContext.Products
                        join y in ProjectDataContext.Units on x.UnitId equals y.Id
                        select new { x, y };

            List<Product> products = new List<Product>();
            Product product = new Product();
            if (query.Any())
            {
                foreach (var item in query)
                {
                    product = new Product();
                    product.Id = item.x.Id;
                    product.PartNumber = item.x.PartNumber + " - " + item.x.ProductName;
                    product.ProductName = item.x.ProductName;
                    product.UnitId = item.x.UnitId;
                    product.UnitName = item.y.UnitName;
                    product.NumberOfLOT = item.x.NumberOfLOT;
                    product.Note = item.x.Note;
                    product.Status = item.x.Status;
                    products.Add(product);
                }
            }
            return products;
        }
    }
}