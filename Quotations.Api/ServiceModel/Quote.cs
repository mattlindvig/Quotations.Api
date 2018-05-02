using Microsoft.EntityFrameworkCore;
using System;

namespace ServiceModel
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public Author Author { get; set; }
        public string Quotation { get; set; }
        public User Users { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public string SourceInfo { get; set; }

    }
}
