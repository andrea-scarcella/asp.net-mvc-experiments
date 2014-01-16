using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Domain
{
    public interface IRepository<T>
    {

        T Save(Post p);

        T FindByPermalink(string expectedPermalink);
    }
}
