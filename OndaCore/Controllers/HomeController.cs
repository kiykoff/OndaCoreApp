using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OndaCore.Models;
using static OndaCore.Models.AxaptaModel;

namespace OndaCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult About()
        {
            //ViewBag.Entity = AxaptaModel.RunserviceOnHandAsync();
            // ViewBag.ItemName = AxaptaModel.RunserviceOnHandAsync();

            ViewBag.SalesId = AxaptaModel.Create();
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewBag.Entity = AxaptaModel.RunserviceOnHandAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
