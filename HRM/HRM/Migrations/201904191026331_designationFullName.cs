namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class designationFullName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Designations", "FullDesignationName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Designations", "FullDesignationName");
        }
    }
}
