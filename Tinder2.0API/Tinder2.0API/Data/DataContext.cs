using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Tinder2API
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}
