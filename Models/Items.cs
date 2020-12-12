using System;
using System.ComponentModel.DataAnnotations;

namespace MvcPlay.Models
{
    public class Items   {

        public int Id { get; set; }
        public string Item  { get; set; }

        
        public string Unit { get; set; }
        public decimal Price { get; set; }

        public decimal Qty { get; set; }
        public decimal Total { get; set; }

        public decimal Discount{ get; set; }
        public decimal Net { get; set; }



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