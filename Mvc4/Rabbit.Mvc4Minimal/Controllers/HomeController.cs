using System.Web.Mvc;

namespace Rabbit.Mvc4Minimal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
