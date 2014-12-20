using Highway.Data;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.SL.Queries;

namespace Semplice.Kiriwa.SL
{
    public class ObliqService
    {
        private readonly IRepository _repository;

        public ObliqService(IRepository repository)
        {
            _repository = repository;
        }

        public Card GetCard(int id)
        {
            // TODO: 12.14.2014 - Remove this, just for test
            var _results = _repository.Find(new Cards());

            var _result = _repository.Find(new CardById(id));

            return _result;
        }
    }
}
