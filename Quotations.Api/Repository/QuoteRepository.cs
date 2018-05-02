using Interfaces.Repository;
using Repository.EF;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class QuoteRepository : ISqlQuotes
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
        public Quote Get(int ID)
        {
            return _context.Quotes.FirstOrDefault(e => e.QuoteId == ID);
        }
        public List<Quote> GetAll()
        {
            return _context.Quotes.ToList<Quote>();
        }
    }
}
