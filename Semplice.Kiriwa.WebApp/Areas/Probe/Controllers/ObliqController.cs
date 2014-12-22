using System.Collections.Generic;
using System.Web.Http;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.Domains.DTOs;
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

        #region Stack

        // GET: api/Obliq/GetStacksWithCardCount
        public IEnumerable<StackWithCardCountDTO> GetStacksWithCardCount()
        {
            var _result = _ObliqService.GetStacksWithCardCount();

            return _result;
        }

        // GET: api/Obliq/GetStack/5
        public Stack GetStack(int id)
        {
            var _result = _ObliqService.GetStack(id);

            return _result;
        }

        #endregion

        #region Card

        // GET: api/Obliq/GetCard/5
        public Card GetCard(int id)
        {
            var _result = _ObliqService.GetCard(id);

            return _result;
        }

        #endregion
    }
}
