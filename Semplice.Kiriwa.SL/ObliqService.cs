using System.Collections.Generic;
using Highway.Data;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.Domains.DTOs;
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

        #region Stack

        public Stack GetStack(int id)
        {
            var _result = _repository.Find(new StackById(id, true));

            return _result;
        }

        public IEnumerable<StackWithCardCountDTO> GetStacksWithCardCount()
        {
            var _result = _repository.Find(new StacksWithCardCount());

            return _result;
        }

        #endregion

        #region Card

        public Card GetCard(int id)
        {
            var _result = _repository.Find(new CardById(id));

            return _result;
        }

        #endregion
    }
}
