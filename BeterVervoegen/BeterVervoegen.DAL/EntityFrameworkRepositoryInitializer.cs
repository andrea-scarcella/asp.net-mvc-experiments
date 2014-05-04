using BeterVervoegen.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.DAL
{
    public class EntityFrameworkRepositoryInitializer : System.Data.Entity.DropCreateDatabaseAlways<EntityFrameworkRepository>
    {
        protected override void Seed(EntityFrameworkRepository context)
        {
            //base.Seed(context);
            //Test t0 = new Test(
            //);
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
