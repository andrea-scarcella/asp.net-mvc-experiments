using BeterVervoegen.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BeterVervoegen.DAL
{
    public class EntityFrameworkRepository : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestItem> TestItems { get; set; }
        public EntityFrameworkRepository()
            : base("name=BeterVervoegenDAL")
        {

        }
         static EntityFrameworkRepository()
            //: base("name=BeterVervoegenDAL")
        {
            Database.SetInitializer<EntityFrameworkRepository>(new DbInitializer());
            using (var dbc = new EntityFrameworkRepository())
            {
                dbc.Database.Initialize(true);
            }
        }

    }
    class DbInitializer : DropCreateDatabaseAlways<EntityFrameworkRepository>
    {
        protected override void Seed(EntityFrameworkRepository context)
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
