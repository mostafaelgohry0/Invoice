using System.Collections.Generic;
using MvcPlay.Models;

namespace MvcPlay.ViewModel
{
    public class InvoiceDbs
    {
        public IEnumerable<Invoice> Invoice { get; set; }  
        public IEnumerable<Play> Play { get; set; } 
    }
}