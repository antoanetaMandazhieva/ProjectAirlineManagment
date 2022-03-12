namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flights", "Destination", c => c.String());
            DropColumn("dbo.Flights", "Destinatio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Flights", "Destinatio", c => c.String());
            DropColumn("dbo.Flights", "Destination");
        }
    }
}
