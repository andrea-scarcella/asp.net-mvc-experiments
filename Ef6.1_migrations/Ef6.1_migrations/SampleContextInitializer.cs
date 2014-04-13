using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef6._1_migrations
{


    public class SampleContextInitializer : System.Data.Entity.DropCreateDatabaseAlways<SampleContext>
    {
        protected override void Seed(Ef6._1_migrations.SampleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var masters = new[] { new Master { Id = Guid.NewGuid(), Property1 = "p1" }, new Master { Id = Guid.NewGuid(), Property1 = "p2" } };
            context.Masters.AddRange( masters);
        }
    }
}
