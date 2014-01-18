using Byob.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
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
            BsonClassMap.RegisterClassMap<Post>(cm =>
            {
                cm.AutoMap();
                cm.SetIdMember(
                    cm.GetMemberMap(p => p.Id)
                    //.SetIgnoreIfDefault(true)
                    //.SetRepresentation(BsonType.String)
                    );
            });
         

        }
        public Post Save(Post p)
        {
           
            collection.Save<Post>(p);
            return p;
        }



        public Post FindByPermalink(string expectedPermalink)
        {
            return collection.FindOne(Query<Post>.EQ<string>(p0 => p0.permalink, expectedPermalink));

        }
    }
}
