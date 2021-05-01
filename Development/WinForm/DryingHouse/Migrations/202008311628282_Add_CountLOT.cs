namespace DryingHouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_CountLOT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CountLOT", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CountLOT");
        }
    }
}
