using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byob.Dal
{
    public class Entity
    {
        [BsonIgnoreIfDefault]
        public Guid? Id { get; set; }
    }
}
