using Microsoft.EntityFrameworkCore;
using System;

namespace ServiceModel
{
    public class Quote
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Quotation { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }

    }
}
