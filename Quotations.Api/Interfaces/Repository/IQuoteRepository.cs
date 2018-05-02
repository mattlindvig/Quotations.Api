using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Repository
{
    public interface IQuoteRepository
    {
        void Add(Quote emp);
        Quote GetQuote(int ID);
        List<Quote> GetAllQuotes();

        void Add(User user);
        User GetUser(int ID);
        List<User> GetAllUsers();


        void Add(Author author);
        Author GetAuthor(int ID);
        List<Author> GetAllAuthors();
    }
}
