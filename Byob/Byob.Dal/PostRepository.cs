using Byob.Domain;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Dal
{
    public class PostRepository : IRepository<Post>
    {
        private MongoClient client;
        private MongoServer server;
        private MongoDatabase database;
        private MongoCollection<Post> collection;
        public PostRepository()
        {
            var connectionString = "mongodb://localhost";
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase("Byob");
            collection = database.GetCollection<Post>("posts");
        }
        public Post Save(Post p)
        {
            var wc = collection.Update(
                Query<Post>.EQ<string>(p0 => p0.permalink, p.permalink),
                Update<Post>.Replace(p),
                UpdateFlags.Upsert);
            return p;
        }



        public Post FindByPermalink(string expectedPermalink)
        {
            return new Post();
        }
    }
}
