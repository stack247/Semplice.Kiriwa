using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.DAL
{
    public class AuthorService
    {
        private readonly IRepository _repository;

        public AuthorService(IRepository repository)
        {
            _repository = repository;
        }

        public Author GetAllAuthors()
        {
            _repository.Context.GetAll();
        }
    }
}
