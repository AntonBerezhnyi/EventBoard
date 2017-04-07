using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EventBoard.Models;

namespace EventBoard.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        EventContext db = new EventContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Events
            IEnumerable<Event> events = db.Events;
            // передаем все объекты в динамическое свойство Events в ViewBag
            ViewBag.Events = events;
            // возвращаем представление
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.EventId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = getToday();
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Thank you , " + purchase.Person + ", for purchase!";
        }

        private DateTime getToday()
        {
            return DateTime.Now;
        }
    }
}