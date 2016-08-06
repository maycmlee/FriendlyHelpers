namespace FriendlyHelpers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Friends", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Friends", "Address", c => c.String());
        }
    }
}
