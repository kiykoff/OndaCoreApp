using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using DirPartyTableService;
using Microsoft.AspNetCore.Mvc;
using OndaCore.Models;
using PartyTableCustom;


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

            // ViewBag.SalesId = AxaptaModel.Create();
            ViewBag.str = PBAModel.Test();
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Наши менеджеры готовы ответить на любые вопросы. Вы можете связаться с нами одним из указанных способов.";
            // ViewBag.Entity = AxaptaModel.RunserviceOnHandAsync();
            // EntityKey[] employee = EmplModel.FindKeys();
            AxdDirPartyTableCustom table = EmplModel.Find() ;
            return View(table);


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
