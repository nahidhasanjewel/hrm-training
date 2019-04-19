namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jewel22 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Divisions", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Divisions", "Date", c => c.Int(nullable: false));
        }
    }
}
