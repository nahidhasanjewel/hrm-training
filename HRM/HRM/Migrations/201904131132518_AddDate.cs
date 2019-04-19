namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Divisions", "DivisionPlace", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Divisions", "DivisionPlace");
        }
    }
}
