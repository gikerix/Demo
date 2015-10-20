using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ConvertNumbers.Models
{
    public class NumbersContext : DbContext
    {
        public DbSet<BasicNumbers> BasicNumbers { get; set; }
    }
}