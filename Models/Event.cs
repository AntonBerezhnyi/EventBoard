using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventBoard.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Orginizer { get; set; }
        public double Price { get; set; }

    }
}