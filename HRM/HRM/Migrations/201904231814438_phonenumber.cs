namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phonenumber : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
