namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig22 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Divisions", "Date", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Divisions", "Date");
        }
    }
}
