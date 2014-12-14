using Highway.Data;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.SL.Queries;

namespace Semplice.Kiriwa.SL
{
    public class AuthorService
    {
        private readonly IRepository _repository;

        public AuthorService(IRepository repository)
        {
            _repository = repository;
        }

        public Author GetAuthor(int id)
        {
            // TODO: 12.14.2014 - Remove this, just for test
            var _results = _repository.Find(new Authors());

            var _result = _repository.Find(new AuthorById(id));

            return _result;
        }
    }
}
