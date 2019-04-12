namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jewel01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DivusionCode = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Divisions");
        }
    }
}
