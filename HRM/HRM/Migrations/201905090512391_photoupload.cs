namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photoupload : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "PhotoPath", c => c.String());
            DropColumn("dbo.Employees", "ImagePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "ImagePath", c => c.String());
            DropColumn("dbo.Employees", "PhotoPath");
        }
    }
}
