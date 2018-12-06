using Microsoft.AspNetCore.Mvc;

namespace Vinter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

    }
}
