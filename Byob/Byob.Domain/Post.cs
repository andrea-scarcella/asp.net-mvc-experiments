using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Domain
{
    public class Post
    {

        public Post()
        {
            permalink = Guid.NewGuid().ToString();
        }

        public string title { get; set; }
        public string author { get; set; }
        public string body { get; set; }
        public string permalink { get; set; }
        public List<string> tags { get; set; }
        public List<Comment> comments { get; set; }
        public DateTime date { get; set; }


        public Guid  Id { get; set; }
    }
}
