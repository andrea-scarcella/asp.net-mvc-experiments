using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Byob.Domain;
using Byob.Dal;

using MongoDB.Driver;
using MongoDB.Driver.Builders;
namespace Byob.Domain.UnitTests
{
    public class Class1
    {
        private MongoClient client;
        private MongoServer server;
        private MongoDatabase database;
        private MongoCollection<Post> collection;

        [TestFixtureSetUp]
        public void Setup()
        {
            r = new PostRepository();

            var connectionString = "mongodb://localhost";
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("Byob");
            collection = database.GetCollection<Post>("posts");
            collection.Drop();
        }
        [Test]
        public void CanAddPost()
        {
            //Arrange
            Post p = new Post();
            //Act

            var retrieved = r.Save(p);
            //Assert
            Assert.IsNotNull(retrieved);
            Assert.IsNotNull(retrieved.Id);
        }


        [Test]
        public void CanRetrieveSavedPost()
        {
            //Arrangee
            //Act
            Post p = new Post();
            var expectedPermalink = p.permalink;
            r.Save(p);
            var q = r.FindByPermalink(expectedPermalink);
            var actualPermalink = q.permalink;
            //Assert
            Assert.AreEqual(expectedPermalink, actualPermalink);
            //same entity yet two instances??
        }

        public IRepository<Post> r { get; set; }
    }
}
