using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Domain
{
    public interface IRepository<T>
    {

        T Save(T p);

        T FindByPermalink(string expectedPermalink);

        IEnumerable<T> Find(Expression<Func<Post, bool>> predicate);
    }
}
