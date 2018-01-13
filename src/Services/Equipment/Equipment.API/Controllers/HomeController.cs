using Microsoft.AspNetCore.Mvc;

namespace eSupport.Services.Equipment.API.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index() 
        {
            return new RedirectResult("~/swagger");
        }
    }
}