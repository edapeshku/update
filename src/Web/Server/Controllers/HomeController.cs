using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using eSupport.Web;

namespace eSupport.Web.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly IOptionsSnapshot<AppSettings> _settings;

        public HomeController(IHostingEnvironment env, IOptionsSnapshot<AppSettings> settings)
        {
            _env = env;
            _settings = settings;
        }

        public IActionResult Configuration()
        {
            return Json(_settings.Value);
        }


        // public IActionResult Index()
        // {
        //     return View();
        // }

        // public IActionResult Error()
        // {
        //     ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        //     return View();
        // }
    }
}
