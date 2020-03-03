using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Tinder2API.Models;

namespace Tinder2API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
