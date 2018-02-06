using System.Web.Mvc;

namespace ShopSystemUI.Controllers
{
    [LoginVerifica]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
