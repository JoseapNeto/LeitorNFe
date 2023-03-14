namespace AppLeitorNfe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppLeitorNfe.Models.LeitorNfeContext3>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppLeitorNfe.Models.LeitorNfeContext3 context)
        {
            
        }
    }
}
