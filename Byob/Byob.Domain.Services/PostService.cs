using Byob.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Byob.Domain.Services
{
    public class PostService : IPostService
    {
        private IRepository<Post> _pr;

        public PostService(IRepository<Post> _pr)
        {
            // TODO: Complete member initialization
            this._pr = _pr;
        }

        public void AddPost(Post p)
        {
            if (p == null)
            {
                 throw new ArgumentException("Undefined posts not allowed");
            }
            if (string.IsNullOrEmpty(p.title)
                || string.IsNullOrWhiteSpace(p.title))
            {
                throw new ArgumentException("Title is mandatory");
            }
            p.preview = p.body.Substring(0, p.body.Length < 50 ? p.body.Length : 50);
            _pr.Save(p);
        }







        public IEnumerable<Post> getPosts()
        {
            return _pr.Find(p => true);
        }
    }
}
