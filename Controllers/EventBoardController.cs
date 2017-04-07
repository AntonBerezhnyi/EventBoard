using System.Web.Mvc;

namespace EventBoard.Controllers
{
    public class EventBoardController : Controller
    {
        // GET: EventBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}