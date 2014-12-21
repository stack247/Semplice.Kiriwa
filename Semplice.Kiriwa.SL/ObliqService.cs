using System.Collections.Generic;
using Highway.Data;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.SL.Contracts;
using Semplice.Kiriwa.DAL.Queries;

namespace Semplice.Kiriwa.SL
{
    public class ObliqService : IObliqService
    {
        private readonly IRepository _repository;

        public ObliqService(IRepository repository)
        {
            _repository = repository;
        }

        public Stack GetStack(int id)
        {
            var _result = _repository.Find(new StackById(id, true));

            return _result;
        }

        public IEnumerable<Stack> GetStacks()
        {
            var _result = _repository.Find(new Stacks());

            return _result;
        }
    }
}
