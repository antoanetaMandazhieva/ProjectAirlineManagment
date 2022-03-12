namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedPilot : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pilots", "PhoneNumber", c => c.String());
            AddColumn("dbo.Pilots", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Pilots", "TypePilot", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pilots", "TypePilot");
            DropColumn("dbo.Pilots", "Age");
            DropColumn("dbo.Pilots", "PhoneNumber");
        }
    }
}
