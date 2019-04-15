using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> l = new List<string>()
        {
            "valure","va2","va3"

            
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return l;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return l[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            l.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            l[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            l.RemoveAt(id);
        }
    }
}
