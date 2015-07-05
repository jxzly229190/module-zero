namespace ModuleZeroSampleProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Infrastructure.Annotations;
    using System.Data.Entity.Migrations;
    
    public partial class InitMyNavsData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyNavs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Long(),
                        DeletionTime = c.DateTime(),
                        LastModificationTime = c.DateTime(),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                    },
                annotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_MyNav_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AbpUsers", t => t.CreatorUserId)
                .ForeignKey("dbo.AbpUsers", t => t.DeleterUserId)
                .ForeignKey("dbo.AbpUsers", t => t.LastModifierUserId)
                .Index(t => t.DeleterUserId)
                .Index(t => t.LastModifierUserId)
                .Index(t => t.CreatorUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyNavs", "LastModifierUserId", "dbo.AbpUsers");
            DropForeignKey("dbo.MyNavs", "DeleterUserId", "dbo.AbpUsers");
            DropForeignKey("dbo.MyNavs", "CreatorUserId", "dbo.AbpUsers");
            DropIndex("dbo.MyNavs", new[] { "CreatorUserId" });
            DropIndex("dbo.MyNavs", new[] { "LastModifierUserId" });
            DropIndex("dbo.MyNavs", new[] { "DeleterUserId" });
            DropTable("dbo.MyNavs",
                removedAnnotations: new Dictionary<string, object>
                {
                    { "DynamicFilter_MyNav_SoftDelete", "EntityFramework.DynamicFilters.DynamicFilterDefinition" },
                });
        }
    }
}
