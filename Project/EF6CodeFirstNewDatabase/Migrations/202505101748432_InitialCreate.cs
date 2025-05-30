namespace EF6CodeFirstNewDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DeptId)
                .Index(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DeptId", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "DeptId" });
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
        }
    }
}
