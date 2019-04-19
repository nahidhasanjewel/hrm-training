namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employee : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "DesignationId", newName: "Designation");
            RenameIndex(table: "dbo.Employees", name: "IX_DesignationId", newName: "IX_Designation");
            DropColumn("dbo.Employees", "FullDesignationName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "FullDesignationName", c => c.String());
            RenameIndex(table: "dbo.Employees", name: "IX_Designation", newName: "IX_DesignationId");
            RenameColumn(table: "dbo.Employees", name: "Designation", newName: "DesignationId");
        }
    }
}
