using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPlay.Models
{
    public class Invoice    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }

        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
        public string InvoiceStore { get; set; }
         public decimal InvoiceTotale { get; set; }

          public decimal InvoiceTaxes { get; set; }
           public decimal InvoiceNet { get; set; }


         public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        
    }
}