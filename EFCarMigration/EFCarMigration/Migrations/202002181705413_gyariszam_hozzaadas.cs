namespace EFCarMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gyariszam_hozzaadas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auto", "Gyariszam", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auto", "Gyariszam");
        }
    }
}
