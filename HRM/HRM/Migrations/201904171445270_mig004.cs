namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig004 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionCode = c.Int(nullable: false),
                        SectionName = c.Int(nullable: false),
                        DeptsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Depts", t => t.DeptsId, cascadeDelete: true)
                .Index(t => t.DeptsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "DeptsId", "dbo.Depts");
            DropIndex("dbo.Sections", new[] { "DeptsId" });
            DropTable("dbo.Sections");
        }
    }
}
