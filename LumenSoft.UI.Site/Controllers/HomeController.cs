using Microsoft.AspNetCore.Mvc;

namespace LumenSoft.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
