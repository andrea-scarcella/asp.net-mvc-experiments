using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Byob.Domain
{
    public interface IEntity
    {
         Guid? Id { get; set; }
    }
}
