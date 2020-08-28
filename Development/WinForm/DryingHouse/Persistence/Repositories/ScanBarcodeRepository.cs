using DryingHouse.Core.Domain;
using DryingHouse.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System;
using DryingHouse.Core;
using DryingHouse.Core.Helper;
using System.Linq.Expressions;

namespace DryingHouse.Persistence.Repositories
{
    public class ScanBarcodeRepository : Repository<ScanBarcode>
    {
        public string id = "";

        public ScanBarcodeRepository(ProjectDataContext projectDataContext) : base(projectDataContext)
        {
        }

        public ProjectDataContext ProjectDataContext
        {
            get { return Context as ProjectDataContext; }
        }

        public void Save(ScanBarcode scanBarcode)
        {
            if (String.IsNullOrEmpty(scanBarcode.Id))
            {
                scanBarcode.Id = GetAutoID();
                scanBarcode.Status = GlobalConstants.StatusValue.Using;
                scanBarcode.CreatedAt = DateTime.Now;
                scanBarcode.CreatedBy = GlobalConstants.username;
                Add(scanBarcode);
                id = scanBarcode.Id;
            }
            else
            {
                Update(scanBarcode);
            }
        }

        public void Update(ScanBarcode scanBarcode)
        {
            error = false;
            errorMessage = "";
            try
            {
                var raw = FirstOrDefault(_ => _.Id.Equals(scanBarcode.Id));
                if (raw != null)
                {
                    raw.CollectInformation(scanBarcode);
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

        public void Cancel(string id)
        {
            error = false;
            errorMessage = "";
            try
            {
                var scanBarcode = FirstOrDefault(_ => _.Id.Equals(id));
                if (scanBarcode != null)
                {
                    scanBarcode.Status = GlobalConstants.StatusValue.NoUse;
                    scanBarcode.EditedAt = DateTime.Now;
                    scanBarcode.EditedBy = GlobalConstants.username;
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

        //public List<ScanBarcode> GetScanBarcodesMonitoring(int hour)
        //{
        //    List<ScanBarcode> Result = GetAll().Where(w => w.ScanIn >= DateTime.Now.AddHours(-hour) 
        //                                && w.CompletedStatus == GlobalConstants.CompletedStatusValue.None)
        //                            .GroupBy(g => g.Barcode)
        //                            .Select(s => s.OrderByDescending(o => o.StepNo).Take(1))
        //                            .SelectMany(o => o).ToList();
        //    return Result;
        //}
        public List<ScanBarcode> GetScanBarcodesMonitoring(int hour)
        {
            List<ScanBarcode> Result = GetAll().Where(w => w.ScanIn >= DateTime.Now.AddHours(-hour))
                                    .GroupBy(g => g.Barcode)
                                    .Select(s => s.OrderByDescending(o => o.StepNo).Take(1))
                                    .SelectMany(o => o).ToList();
            return Result;
        }
        public List<ScanBarcode> GetScanBarcodesFinish(int hour)
        {
            List<ScanBarcode> Result = GetAll().Where(w => w.ScanOut >= DateTime.Now.AddHours(-hour)
                                        && w.ResultStatus != GlobalConstants.ResultStatusValue.Processing && w.ScanOut != null)
                                    .GroupBy(g => g.Barcode)
                                    .Select(s => s.OrderByDescending(o => o.StepNo).Take(1))
                                    .SelectMany(o => o).ToList();
            return Result;
        }
        public List<ScanBarcode> GetListProduction(DateTime fromDate, DateTime toDate)
        {
            List<ScanBarcode> Result = (from p in ProjectDataContext.ScanBarcodes
                                        where p.ScanIn >= fromDate && p.ScanIn <= toDate
                                        select p).ToList();
            return Result;
        }
        public List<ScanBarcode> GetLastProduction(List<string> lstBarcode)
        {
            List<ScanBarcode> Result = GetAll().Where(w=> lstBarcode.Contains(w.Barcode))
                                        .GroupBy(g => g.Barcode)
                                        .Select(s => s.OrderByDescending(o => o.StepNo).Take(1))
                                        .SelectMany(o => o).ToList();
            return Result;
        }

        public List<ScanBarcode> GetFirstStep(DateTime fromDate, DateTime toDate)
        {
            
            List<ScanBarcode> Result = GetAll().Where(w => w.ScanIn >= fromDate && w.ScanIn <= toDate)
                                    .GroupBy(g => g.Barcode)
                                    .Select(s => s.OrderBy(o => o.StepNo).Take(1))
                                    .SelectMany(o => o).ToList();
            return Result;
        }
        public List<ScanBarcode> GetListProdctionByStep(List<string> lstBarcode, int step)
        {
            List<ScanBarcode> Result = (from p in ProjectDataContext.ScanBarcodes
                                        where lstBarcode.Contains(p.Barcode) && p.StepNo == step
                                        select p).ToList();
            return Result;
        }


    }
}