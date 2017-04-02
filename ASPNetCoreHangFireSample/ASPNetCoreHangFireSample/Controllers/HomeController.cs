using System;
using Microsoft.AspNetCore.Mvc;
using Hangfire;

namespace ASPNetCoreHangFireSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BackgroundJob.Enqueue(() => Console.Write("BackGroundJob"));
            RecurringJob.AddOrUpdate(() => Console.Write("RecurringJob"), Cron.Daily);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
