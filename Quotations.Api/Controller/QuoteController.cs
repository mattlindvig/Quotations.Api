using Interfaces.Repository;
using Interfaces.Controller;
using ServiceModel;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class QuoteController : IQuoteController
    {
        public ISqlQuotes _sqlQuotes { get; set; }

        public QuoteController(ISqlQuotes sqlQuotes)
        {
            _sqlQuotes = sqlQuotes;
        }
        public Quote GetQuote(int Id)
        {
            return _sqlQuotes.Get(Id);
        }
        public List<Quote> GetAllQuotes()
        {
            return _sqlQuotes.GetAll();
        }
        public void Add(Quote quote)
        {
            _sqlQuotes.Add(quote);
        }
    }
}
