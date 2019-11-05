using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class AuthController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
    }
}