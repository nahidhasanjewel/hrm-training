namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class depts112 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "Designation", newName: "DesignationId");
            RenameIndex(table: "dbo.Employees", name: "IX_Designation", newName: "IX_DesignationId");
            AddColumn("dbo.Employees", "EmployeeCode", c => c.String(maxLength: 10));
            AddColumn("dbo.Employees", "NickName", c => c.String());
            AddColumn("dbo.Employees", "MobileNumber", c => c.String(maxLength: 15));
            AddColumn("dbo.Employees", "Email", c => c.String(maxLength: 100));
            AddColumn("dbo.Employees", "FatherName", c => c.String());
            AddColumn("dbo.Employees", "MotherName", c => c.String());
            AddColumn("dbo.Employees", "BloodGroup", c => c.String(maxLength: 3));
            AddColumn("dbo.Employees", "DeptId", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Address", c => c.String());
            AddColumn("dbo.Employees", "EmployeePhotoPath", c => c.String());
            AlterColumn("dbo.Depts", "DeptCode", c => c.String());
            AlterColumn("dbo.Depts", "DeptName", c => c.String());
            CreateIndex("dbo.Employees", "DeptId");
            AddForeignKey("dbo.Employees", "DeptId", "dbo.Depts", "Id", cascadeDelete: true);
            DropColumn("dbo.Employees", "EmployeeName");
            DropColumn("dbo.Employees", "FatherNameName");
            DropColumn("dbo.Employees", "PhoneNumber");
            DropColumn("dbo.Employees", "PhotoPath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "PhotoPath", c => c.String());
            AddColumn("dbo.Employees", "PhoneNumber", c => c.String(maxLength: 10));
            AddColumn("dbo.Employees", "FatherNameName", c => c.String());
            AddColumn("dbo.Employees", "EmployeeName", c => c.String(maxLength: 10));
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Depts");
            DropIndex("dbo.Employees", new[] { "DeptId" });
            AlterColumn("dbo.Depts", "DeptName", c => c.Int(nullable: false));
            AlterColumn("dbo.Depts", "DeptCode", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "EmployeePhotoPath");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "DeptId");
            DropColumn("dbo.Employees", "BloodGroup");
            DropColumn("dbo.Employees", "MotherName");
            DropColumn("dbo.Employees", "FatherName");
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "MobileNumber");
            DropColumn("dbo.Employees", "NickName");
            DropColumn("dbo.Employees", "EmployeeCode");
            RenameIndex(table: "dbo.Employees", name: "IX_DesignationId", newName: "IX_Designation");
            RenameColumn(table: "dbo.Employees", name: "DesignationId", newName: "Designation");
        }
    }
}
