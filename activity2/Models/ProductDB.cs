using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace activity2.Models
{
    public class ProductDB : DbContext
    {
        public DbSet<Products> products { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Order_Line> order_lines { get; set; }
    }
}