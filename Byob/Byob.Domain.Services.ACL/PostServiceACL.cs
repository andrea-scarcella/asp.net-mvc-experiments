using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Byob.Domain.Services.ACL
{
    public class PostServiceACL : IPostServiceACL
    {
        public Post AddPost(Web.Models.PostVM newPostVM)
        {

            Post post = PostFactory.factory(newPostVM.title, newPostVM.body, newPostVM.tags);
           //new Post();
            post.body = newPostVM.body;
            post.title = newPostVM.title;
            if (!(null == newPostVM.tags))
            {
                post.tags = new List<string>(newPostVM.tags);
            }
            return post;
        }
    }
}
