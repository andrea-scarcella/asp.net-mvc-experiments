using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Byob.Domain
{
    public interface IPostService
    {
        void AddPost(Post p);




        IEnumerable<Post> getPosts();
    }
}
