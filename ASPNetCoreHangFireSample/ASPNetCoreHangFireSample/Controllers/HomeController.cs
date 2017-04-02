using System;
using Microsoft.AspNetCore.Mvc;
using Hangfire;

namespace ASPNetCoreHangFireSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BackgroundJob.Enqueue(() => Console.WriteLine("BackGroundJob"));
            RecurringJob.AddOrUpdate(() => Console.WriteLine("RecurringJob"), Cron.Daily);
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
