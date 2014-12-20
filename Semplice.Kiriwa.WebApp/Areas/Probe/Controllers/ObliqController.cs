using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Semplice.Kiriwa.WebApp.Areas.Probe.Controllers
{
    public class ObliqController : ApiController
    {
        // GET: api/Obliq
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Obliq/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Obliq
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Obliq/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stack/5
        public void Delete(int id)
        {
        }
    }
}
