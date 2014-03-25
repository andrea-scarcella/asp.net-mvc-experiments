using BeterVervoegen.DAL;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BeterVervoegen.Test
{
   public class SqlServerRepositoryTest : TestBase
    {
       private SqlServerRepository _rep;
       private string absoluteDataDirectory;
       public SqlServerRepositoryTest()
        {
            this.Describes("SqlRepositoryTest Test");
            var dataDirectory = ConfigurationManager.AppSettings["DataDirectory"];
             absoluteDataDirectory = Path.GetFullPath(dataDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", absoluteDataDirectory);
        }
       [SetUp]
       public void Init()
       {
           string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
           _rep = new SqlServerRepository(connectionString);
       }
       [Test]
       public void connects_to_database() {
           int u = 0;
       }
    }
}
