using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventBoard.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        //buyer name
        public string Person { get; set; }

        public int EventId { get; }
        public int CardNumber { get; set; }

        public DateTime Date { get; set; }

    }
}