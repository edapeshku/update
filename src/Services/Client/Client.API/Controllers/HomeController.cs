using Microsoft.AspNetCore.Mvc;

namespace eSupport.Services.Client.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}