using BeterVervoegen.BL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace BeterVervoegen.DAL
{
    public class EnfityFrameworkRepository : DbContext
    {
        public DbSet<Taaltest> Tests;

    }
}
