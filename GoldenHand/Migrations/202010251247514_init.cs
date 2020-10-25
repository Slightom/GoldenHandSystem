namespace GoldenHand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Forms",
                c => new
                    {
                        FormId = c.Int(nullable: false, identity: true),
                        Lp = c.Int(nullable: false),
                        SeniorId = c.Int(nullable: false),
                        WorkerId = c.Int(nullable: false),
                        FormStatusId = c.Int(nullable: false),
                        Info = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        RepairDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FormId)
                .ForeignKey("public.FormStatus", t => t.FormStatusId, cascadeDelete: true)
                .ForeignKey("public.Seniors", t => t.SeniorId, cascadeDelete: true)
                .ForeignKey("public.Workers", t => t.WorkerId, cascadeDelete: true)
                .Index(t => t.FormStatusId)
                .Index(t => t.SeniorId)
                .Index(t => t.WorkerId);
            
            CreateTable(
                "public.FormStatus",
                c => new
                    {
                        FormStatusId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.FormStatusId);
            
            CreateTable(
                "public.Seniors",
                c => new
                    {
                        SeniorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.SeniorId);
            
            CreateTable(
                "public.Workers",
                c => new
                    {
                        WorkerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.WorkerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Forms", "WorkerId", "public.Workers");
            DropForeignKey("public.Forms", "SeniorId", "public.Seniors");
            DropForeignKey("public.Forms", "FormStatusId", "public.FormStatus");
            DropIndex("public.Forms", new[] { "WorkerId" });
            DropIndex("public.Forms", new[] { "SeniorId" });
            DropIndex("public.Forms", new[] { "FormStatusId" });
            DropTable("public.Workers");
            DropTable("public.Seniors");
            DropTable("public.FormStatus");
            DropTable("public.Forms");
        }
    }
}
