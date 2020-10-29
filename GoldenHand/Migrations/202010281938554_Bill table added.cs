namespace GoldenHand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Billtableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BillId);
            
        }
        
        public override void Down()
        {
            DropTable("public.Bills");
        }
    }
}
