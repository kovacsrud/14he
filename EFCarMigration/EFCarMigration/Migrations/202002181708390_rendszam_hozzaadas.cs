﻿namespace EFCarMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rendszam_hozzaadas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auto", "Rendszam", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Auto", "Rendszam");
        }
    }
}
