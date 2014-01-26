using Byob.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            if (!BsonClassMap.IsClassMapRegistered(typeof(Post)))
            {
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


        public IEnumerable<Post> Find(Expression<Func<Post, bool>> predicate)
        {


            return collection.AsQueryable<Post>().Where(predicate);
            //throw new NotImplementedException();
        }
    }
}
