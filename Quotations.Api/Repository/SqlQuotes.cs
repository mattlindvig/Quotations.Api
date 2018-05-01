﻿using Interfaces.Repository;
using ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class SqlQuotes : ISqlQuotes
    {

        private DatabaseThing _context { get; set; }
        public SqlQuotes(DatabaseThing context)
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
            return _context.Quotes.FirstOrDefault(e => e.Id == ID);
        }
        public List<Quote> GetAll()
        {
            return _context.Quotes.ToList<Quote>();
        }
    }
}