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
    public class RepositoryUT
    {
        private MongoClient client;
        private MongoServer server;
        private MongoDatabase database;
        private MongoCollection<Post> collection;
        private PostBuilder pb = null;
        [TestFixtureSetUp]
        public void Setup()
        {
            r = new PostRepository();
            pb = new PostBuilder();
            MongoSetup();
            collection = database.GetCollection<Post>("posts");
            collection.Drop();
        }

        private void MongoSetup()
        {
            var connectionString = "mongodb://localhost";
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("Byob");
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            collection.Drop();
        }
        [Test]
        public void CanAddPost()
        {
            //Arrange
            Post p = pb.getValidPost();
            //Act
            var retrieved = r.Save(p);
            //Assert
            Assert.IsNotNull(retrieved);
            Assert.AreNotEqual(Guid.Empty, retrieved.Id);
        }


        [Test]
        public void CanRetrieveSavedPost()
        {
            //Arrangee
            //Act
            Post p = pb.getValidPost();
            var expectedPermalink = p.permalink;
            r.Save(p);
            var q = r.FindByPermalink(expectedPermalink);
            var actualPermalink = q.permalink;
            //Assert
            Assert.AreEqual(expectedPermalink, actualPermalink);
            //same entity yet two instances??
        }
        [Test]
        public void CanAddTwoPosts()
        {
            //Arrange
            Post p0 = pb.getValidPost();
            Post p1 = pb.getValidPost();
            //Act
            var s0 = r.Save(p0);
            var s1 = r.Save(p1);
            //Assert
            Assert.AreNotEqual(Guid.Empty, s0.Id);
            Assert.AreNotEqual(Guid.Empty, s1.Id);
            Assert.AreNotEqual(s0.Id, s1.Id);
        }
        public IRepository<Post> r { get; set; }
    }
}
