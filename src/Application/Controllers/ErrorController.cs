using Microsoft.AspNetCore.Mvc;

namespace eSupport.Application.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error() => View();
    }
}