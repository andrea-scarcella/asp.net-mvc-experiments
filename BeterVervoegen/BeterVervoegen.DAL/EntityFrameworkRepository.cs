using BeterVervoegen.BL;
using BeterVervoegen.DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;

namespace BeterVervoegen.DAL
{
    public class EntityFrameworkRepository : DbContext
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestItem> TestItems { get; set; }
        public EntityFrameworkRepository()
            : base("name=TestContext")
        {

        }

        public ObjectContext ObjectContext
        {
            get
            {
                //With EF 6.0.2 this would throw an exception if the DB didn't exist.
                //With EF 6.1.0 this creates the database, but doesn't seed the DB.
                return ((IObjectContextAdapter)this).ObjectContext;
            }
        }

        private static readonly Object syncObj = new Object();
        public static bool InitializeDatabase()
        {
            lock (syncObj)
            {
                using (var temp = new EntityFrameworkRepository())
                {
                    if (temp.Database.Exists()) return true;

                    var initializer = new MigrateDatabaseToLatestVersion<EntityFrameworkRepository, Configuration>();
                    Database.SetInitializer(initializer);
                    try
                    {
                        temp.Database.Initialize(true);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        //Handle Error in some way
                        return false;
                    }
                }
            }
        }
    }
}
