using Microsoft.AspNetCore.Mvc;

namespace eSupport.Services.Invoice.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger");
        }
    }
}