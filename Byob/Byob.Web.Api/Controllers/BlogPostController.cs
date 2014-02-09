using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Byob.Web.Api
{
    public class BlogPostController : ApiController
    {
        // GET api/blogpost
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/blogpost/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/blogpost
        public void Post([FromBody]string value)
        {
        }

        // PUT api/blogpost/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/blogpost/5
        public void Delete(int id)
        {
        }
    }
}
