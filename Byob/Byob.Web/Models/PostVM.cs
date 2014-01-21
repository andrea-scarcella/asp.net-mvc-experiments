using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Byob.Web.Models
{
    public class PostVM
    {
        public string title { get; set; }

        public string body { get; set; }

        public IEnumerable<string> tags { get; set; }
    }
}
