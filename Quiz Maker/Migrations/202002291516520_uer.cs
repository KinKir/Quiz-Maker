namespace Quiz_Maker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Selected");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Selected", c => c.Boolean(nullable: false));
        }
    }
}
