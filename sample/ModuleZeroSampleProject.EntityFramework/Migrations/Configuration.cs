using System.Collections.Generic;
using System.Collections.ObjectModel;
using ModuleZeroSampleProject.EntityFramework;
using ModuleZeroSampleProject.Migrations.Data;
using ModuleZeroSampleProject.Navigation;

namespace ModuleZeroSampleProject.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ModuleZeroSampleProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ModuleZeroSampleProject";
        }

        protected override void Seed(ModuleZeroSampleProjectDbContext context)
        {
            new InitialDataBuilder().Build(context);
            //context.Menus.Add(new Menu() { Name = "answer", Description = "Answers" });

            //context.SaveChanges();
        }
    }
}
