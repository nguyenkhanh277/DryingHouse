namespace DryingHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alarms",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Barcode = c.String(),
                        PartNumber = c.String(),
                        StepNo = c.Int(nullable: false),
                        AlarmDate = c.DateTime(nullable: false),
                        AlarmStatus = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AuthorityGroups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        AuthorityGroupName = c.String(),
                        Sort = c.Int(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProgramFunctionAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProgramName = c.String(),
                        FunctionName = c.String(),
                        AuthorityGroupID = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupID)
                .Index(t => t.AuthorityGroupID);
            
            CreateTable(
                "dbo.UserAuthorities",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UserID = c.String(maxLength: 128),
                        AuthorityGroupID = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AuthorityGroups", t => t.AuthorityGroupID)
                .ForeignKey("dbo.Users", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.AuthorityGroupID);
            
            CreateTable(
                "dbo.LanguageLibraries",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Vietnamese = c.String(),
                        English = c.String(),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductMatrices",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PartNumber = c.String(),
                        StepNo = c.Int(nullable: false),
                        DryingTime = c.Single(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PartNumber = c.String(),
                        ProductName = c.String(),
                        UnitId = c.String(maxLength: 128),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.ProgramFunctionMasters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ProgramName = c.String(),
                        FunctionName = c.String(),
                        Explanation = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegistBarcodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        RegistDate = c.DateTime(nullable: false),
                        PartNumber = c.String(),
                        SEQ = c.String(),
                        Barcode = c.String(),
                        UserID = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ScanBarcodes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Barcode = c.String(),
                        PartNumber = c.String(),
                        StepNo = c.Int(nullable: false),
                        ScanIn = c.DateTime(nullable: false),
                        Limit = c.DateTime(),
                        ScanOut = c.DateTime(),
                        DryingTime = c.Single(nullable: false),
                        ResultStatus = c.Int(nullable: false),
                        CompletedStatus = c.Int(nullable: false),
                        Reason = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        DungSai = c.Single(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StepNo = c.Int(nullable: false),
                        RequestScanIn = c.Int(nullable: false),
                        RequestScanOut = c.Int(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        UnitName = c.String(),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Username = c.String(),
                        Salt = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Gender = c.Int(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        CreatedBy = c.String(),
                        EditedAt = c.DateTime(),
                        EditedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAuthorities", "UserID", "dbo.Users");
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropForeignKey("dbo.UserAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropForeignKey("dbo.ProgramFunctionAuthorities", "AuthorityGroupID", "dbo.AuthorityGroups");
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropIndex("dbo.UserAuthorities", new[] { "AuthorityGroupID" });
            DropIndex("dbo.UserAuthorities", new[] { "UserID" });
            DropIndex("dbo.ProgramFunctionAuthorities", new[] { "AuthorityGroupID" });
            DropTable("dbo.Users");
            DropTable("dbo.Units");
            DropTable("dbo.Steps");
            DropTable("dbo.Settings");
            DropTable("dbo.ScanBarcodes");
            DropTable("dbo.RegistBarcodes");
            DropTable("dbo.ProgramFunctionMasters");
            DropTable("dbo.Products");
            DropTable("dbo.ProductMatrices");
            DropTable("dbo.LanguageLibraries");
            DropTable("dbo.UserAuthorities");
            DropTable("dbo.ProgramFunctionAuthorities");
            DropTable("dbo.AuthorityGroups");
            DropTable("dbo.Alarms");
        }
    }
}
