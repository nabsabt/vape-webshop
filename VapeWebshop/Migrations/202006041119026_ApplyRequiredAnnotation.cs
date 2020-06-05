namespace VapeWebshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyRequiredAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Devices", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Liquids", "Flavour", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Liquids", "Flavour", c => c.String());
            AlterColumn("dbo.Devices", "Name", c => c.String());
        }
    }
}
