namespace EFCar2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tulaj_hozzaadasa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tulaj",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                        SzuletesEve = c.Int(nullable: false),
                        auto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auto", t => t.auto_Id)
                .Index(t => t.auto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tulaj", "auto_Id", "dbo.Auto");
            DropIndex("dbo.Tulaj", new[] { "auto_Id" });
            DropTable("dbo.Tulaj");
        }
    }
}
