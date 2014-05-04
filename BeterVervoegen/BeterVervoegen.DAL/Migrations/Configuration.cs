namespace BeterVervoegen.DAL.Migrations
{
    using BeterVervoegen.BL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BeterVervoegen.DAL.EntityFrameworkRepository>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BeterVervoegen.DAL.EntityFrameworkRepository context)
        {
            var testItems = new[] {new TestItem{
						Id=1,
						Infinitive="zijn",
						SimplePast="was",
						PastParticiple="geweest"},new TestItem{
						Id=2,
						Infinitive="lopen",
						SimplePast="liep",
						PastParticiple="gelopen"}
					};

            context.TestItems.AddRange(testItems);
            context.SaveChanges();
            var test = new Test(testItems);
            context.Tests.Add(test);
            context.SaveChanges();
        }
    }
}
