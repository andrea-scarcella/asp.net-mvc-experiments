using Byob.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Dal
{
    public class PostRepository : IRepository<Post>
    {
        public Post Save(Post p)
        {
            return new Post(p);
        }



        public Post FindByPermalink(string expectedPermalink)
        {
            return new Post();
        }
    }
}
