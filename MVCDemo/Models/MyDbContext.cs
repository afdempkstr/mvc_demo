using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVCDemo.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=dbcon")
        { }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }
    }
}