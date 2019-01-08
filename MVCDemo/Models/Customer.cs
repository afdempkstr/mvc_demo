using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Balance { get; set; }

        public DateTime Birthday { get; set; }

        public int NumberOfChildren { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}