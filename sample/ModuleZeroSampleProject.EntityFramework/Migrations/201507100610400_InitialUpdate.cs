namespace ModuleZeroSampleProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nav", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nav", "Icon");
        }
    }
}
