using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef6._1_migrations
{
    public class SampleContext : DbContext
    {
        public DbSet<Master> Masters { get; set; }
        public SampleContext()
        {

        }
    }
}
