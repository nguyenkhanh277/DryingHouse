using DryingHouse.Core.Domain;
using System.Data.Entity;
using System.Data.Common;
using System;
using DryingHouse.Core;

namespace DryingHouse.Persistence
{
    public class ProjectDataContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new CourseConfiguration());
        }

        #region Initial Object
        public ProjectDataContext() : base("DefaultConnection") { this.Configuration.LazyLoadingEnabled = false; }
        protected ProjectDataContext(string connectionString) : base(connectionString) { }
        protected ProjectDataContext(DbConnection conn, DbContextTransaction transaction) : base(conn, false)
        {
            try
            {
                if (transaction != null)
                {
                    if (transaction.UnderlyingTransaction != null)
                        this.Database.UseTransaction(transaction.UnderlyingTransaction);
                    else
                        transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                GlobalConstants.log.Error("Loi ket noi database. " + ex.ToString());
            }
        }
        #endregion

        #region Methods
        public static ProjectDataContext GetDataContext()
        {
            return new ProjectDataContext();
        }

        public static ProjectDataContext GetDataContext(string connectionString)
        {
            return new ProjectDataContext();
        }

        public static ProjectDataContext GetDataContext(ProjectDataContext context, DbContextTransaction transaction)
        {
            if (transaction != null && context != null)
            {
                return new ProjectDataContext(context.Database.Connection, transaction);
            }
            return new ProjectDataContext();
        }

        public virtual bool CheckConnection(ProjectDataContext context)
        {
            try
            {
                context.Database.Connection.Open();
                context.Database.Connection.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region Tables
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Step> Steps { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductMatrix> ProductMatrices { get; set; }
        public virtual DbSet<RegistBarcode> RegistBarcodes { get; set; }
        public virtual DbSet<ScanBarcode> ScanBarcodes { get; set; }
        public virtual DbSet<Alarm> Alarms { get; set; }
        public virtual DbSet<LanguageLibrary> LanguageLibraries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AuthorityGroup> AuthorityGroups { get; set; }
        public virtual DbSet<ProgramFunctionMaster> ProgramFunctionMasters { get; set; }
        public virtual DbSet<ProgramFunctionAuthority> ProgramFunctionAuthorities { get; set; }
        public virtual DbSet<UserAuthority> UserAuthorities { get; set; }
        #endregion

    }
}
