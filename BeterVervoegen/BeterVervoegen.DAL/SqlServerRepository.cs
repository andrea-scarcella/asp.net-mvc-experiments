using BeterVervoegen.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BeterVervoegen.DAL
{
    public class SqlServerRepository : ITestDeelRepository
    {
        private SqlConnection connection;
        public SqlServerRepository(string connectionString) {
            connection = OpenConnection(connectionString);
        }
        protected static SqlConnection OpenConnection(string connectionString)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public IEnumerable<TestDeel> get(string lookupData)
        {
            throw new NotImplementedException();
        }

        public TestDeel create()
        {
            throw new NotImplementedException();
        }

        public TestDeel save(TestDeel t)
        {
            throw new NotImplementedException();
        }

        public TestDeel update(TestDeel t)
        {
            throw new NotImplementedException();
        }

        public TestDeel delete(TestDeel t)
        {
            throw new NotImplementedException();
        }
    }
}
