using ServiceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Repository
{
    public interface ISqlQuotes
    {
        void Add(Quote emp);
        Quote Get(int ID);
        List<Quote> GetAll();
    }
}
