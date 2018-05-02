using Interfaces.Controller;
using Interfaces.Repository;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
    public class AuthorController : IAuthorController
    {
        private IQuoteRepository _sqlQuotes { get; set; }
        public AuthorController(IQuoteRepository sqlQuotes)
        {
            _sqlQuotes = sqlQuotes;
        }
        public Author GetAuthor(int Id)
        {
            return _sqlQuotes.GetAuthor(Id);
        }
        public List<Author> GetAllAuthors()
        {
            return _sqlQuotes.GetAllAuthors();
        }
        public void Add(Author author)
        {
            _sqlQuotes.Add(author);
        }
    }
}
