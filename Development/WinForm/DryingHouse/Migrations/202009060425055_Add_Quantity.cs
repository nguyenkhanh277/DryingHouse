namespace DryingHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Quantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.RegistBarcodes", "Quantity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegistBarcodes", "Quantity");
            DropColumn("dbo.Products", "Quantity");
        }
    }
}
