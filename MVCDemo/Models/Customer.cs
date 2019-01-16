using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDemo.Models
{
    public class Customer
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public int NumberOfChildren { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}