using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal Amount { get; set; }

        public virtual int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}