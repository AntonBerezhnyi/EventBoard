using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventBoard.Models
{
    public class EventDbInitializer : DropCreateDatabaseAlways<EventContext>
    {
        protected override void Seed(EventContext db)
        {
            db.Events.Add(new Event { Name = "Ivan Dorn album presentation", Orginizer = "Misto", Date = new DateTime(2017, 5, 20, 21, 10, 0), Price = 120 });
            db.Events.Add(new Event { Name = "Mashrooms", Orginizer = "Holiday", Date = new DateTime(2017, 4, 13, 19, 12, 0), Price = 150 });
            db.Events.Add(new Event { Name = "L`One", Orginizer = "Misto", Date = new DateTime(2017, 5, 16, 22, 0, 0), Price = 200 });
            db.Events.Add(new Event { Name = "Wu-tang-clan", Orginizer = "Radmir", Date = new DateTime(2017, 7, 7, 19, 30, 0), Price = 700 });
            db.Events.Add(new Event { Name = "Ice Cube", Orginizer = "Tokarev.org", Date = new DateTime(2017, 6, 6, 19, 30, 0), Price = 500 });

            base.Seed(db);
        }
    }
}