using Microsoft.AspNetCore.Mvc;

namespace eSupport.Application.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}