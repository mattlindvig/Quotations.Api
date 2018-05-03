using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Controller
{
    public interface IQuoteController
    {
        Quote GetQuote(int Id);
        List<Quote> GetQuotes(string searchText);
        List<Quote> GetAllQuotes();
        void Add(Quote quote);
    }
}
