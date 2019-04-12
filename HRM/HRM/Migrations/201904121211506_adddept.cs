namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddept : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Depts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptCode = c.Int(nullable: false),
                        DeptName = c.Int(nullable: false),
                        DivisionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Divisions", t => t.DivisionId, cascadeDelete: true)
                .Index(t => t.DivisionId);
            
            AddColumn("dbo.Divisions", "DivisionCode", c => c.Int(nullable: false));
            DropColumn("dbo.Divisions", "DivusionCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Divisions", "DivusionCode", c => c.Int(nullable: false));
            DropForeignKey("dbo.Depts", "DivisionId", "dbo.Divisions");
            DropIndex("dbo.Depts", new[] { "DivisionId" });
            DropColumn("dbo.Divisions", "DivisionCode");
            DropTable("dbo.Depts");
        }
    }
}
