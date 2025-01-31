﻿using Microsoft.EntityFrameworkCore;
using QuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesAPI.Data
{
    public class QuotesDBContext : DbContext
    {
        public QuotesDBContext(DbContextOptions<QuotesDBContext>options):base(options)
        {

        }
        public DbSet<Quote> Quotes { get; set; }
    }
}
