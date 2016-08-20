namespace FriendlyHelpers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tasks", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "Category", c => c.String());
        }
    }
}
