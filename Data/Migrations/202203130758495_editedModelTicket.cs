namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedModelTicket : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "TypeTicket", c => c.String());
            DropColumn("dbo.Tickets", "IsOneWayTicket");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "IsOneWayTicket", c => c.Boolean(nullable: false));
            DropColumn("dbo.Tickets", "TypeTicket");
        }
    }
}
