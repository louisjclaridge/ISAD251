using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ItsPizzaTime.Models
{
    public class ProductDB : DbContext
    {
        public DbSet<Customer> customer { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Pizza> pizza { get; set; }
    }
}