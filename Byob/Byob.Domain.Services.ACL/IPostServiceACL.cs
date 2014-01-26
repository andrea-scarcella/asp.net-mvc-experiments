using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Domain.Services.ACL
{
    public interface IPostServiceACL
    {
        Post AddPost(Web.Models.PostVM newPostVM);
    }
}
