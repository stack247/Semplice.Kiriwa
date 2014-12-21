using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Semplice.Kiriwa.SL.Contracts;

namespace Semplice.Kiriwa.WebApp.Areas.Probe.Controllers
{
    public class ObliqController : ApiController
    {
        private readonly IObliqService _ObliqService;

        public ObliqController(IObliqService obliqService)
        {
            _ObliqService = obliqService;
        }

        // GET: api/Obliq
        public IEnumerable<string> Get()
        {
            var test = _ObliqService.GetStacks();
            var test2 = _ObliqService.GetStack(1);

            return new string[] { "value1", "value2", test2.Name, test2.Cards.FirstOrDefault().Text, test.FirstOrDefault().Name };
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
