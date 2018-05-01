using Interfaces.Repository;
using Interfaces.Controller;
using ServiceModel;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class QuoteController : IQuoteController
    {
        public ISqlQuotes SqlQuotes { get; set; }
        public Quote GetQuote(int Id)
        {
            return SqlQuotes.Get(Id);
        }
        public List<Quote> GetAllQuotes()
        {
            return SqlQuotes.GetAll();
        }
        public void Add(Quote quote)
        {
            SqlQuotes.Add(quote);
        }
    }
}
