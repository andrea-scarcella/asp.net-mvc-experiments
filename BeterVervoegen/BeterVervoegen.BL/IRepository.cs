using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeterVervoegen.BL
{
    public interface IRepository<T, L>
    {
        IEnumerable<T> get(L lookupData);
        T create();
        T save(T t);
        T update(T t);
        T delete(T t);
    }
   
}
