using Interfaces.Repository;
using Repository.EF;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class QuoteRepository : IQuoteRepository
    {

        private readonly DatabaseSetup _context;

        public QuoteRepository(DatabaseSetup context)
        {
            _context = context;
        }
        public void Add(Quote emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
        }

        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }
        public Quote GetQuote(int ID)
        {
            return _context.Quotes.FirstOrDefault(e => e.QuoteId == ID);
        }

        public User GetUser(int ID)
        {
            return _context.User.FirstOrDefault(e => e.UserId == ID);
        }
        public List<Quote> GetAllQuotes()
        {
            return _context.Quotes.ToList<Quote>();
        }
        public List<User> GetAllUsers()
        {
            return _context.User.ToList<User>();
        }

        public void Add(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
        }

        public Author GetAuthor(int ID)
        {
            return _context.Author.FirstOrDefault(e => e.AuthorId == ID);
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Author.ToList<Author>();
        }
    }
}
