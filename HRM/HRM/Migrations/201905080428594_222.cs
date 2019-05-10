namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _222 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "ImagePath", c => c.String());
            AlterColumn("dbo.Divisions", "DivisionCode", c => c.Int(nullable: false));
            DropColumn("dbo.Divisions", "DivisionName");
            DropColumn("dbo.Employees", "NickName");
            DropColumn("dbo.Employees", "BloodGroup");
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "DeptName");
            DropColumn("dbo.Employees", "EmployeePhotoPath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeePhotoPath", c => c.String());
            AddColumn("dbo.Employees", "DeptName", c => c.String());
            AddColumn("dbo.Employees", "Address", c => c.String());
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "BloodGroup", c => c.String());
            AddColumn("dbo.Employees", "NickName", c => c.String());
            AddColumn("dbo.Divisions", "DivisionName", c => c.String());
            AlterColumn("dbo.Divisions", "DivisionCode", c => c.String());
            DropColumn("dbo.Employees", "ImagePath");
        }
    }
}
