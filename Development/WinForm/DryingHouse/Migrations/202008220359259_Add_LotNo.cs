namespace DryingHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_LotNo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegistBarcodes", "LOT", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegistBarcodes", "LOT");
        }
    }
}
