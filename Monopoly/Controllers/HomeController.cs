using System.Web.Mvc;

namespace Monopoly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Game()
        {
            return View();
        }
    }
}
