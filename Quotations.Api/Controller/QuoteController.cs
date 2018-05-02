using Interfaces.Repository;
using Interfaces.Controller;
using ServiceModel;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class QuoteController : IQuoteController
    {
        private IQuoteRepository _sqlQuotes { get; set; }

        public QuoteController(IQuoteRepository sqlQuotes)
        {
            _sqlQuotes = sqlQuotes;
        }
        public Quote GetQuote(int Id)
        {
            return _sqlQuotes.GetQuote(Id);
        }
        public List<Quote> GetAllQuotes()
        {
            return _sqlQuotes.GetAllQuotes();
        }
        public void Add(Quote quote)
        {
            _sqlQuotes.Add(quote);
        }
    }
}
