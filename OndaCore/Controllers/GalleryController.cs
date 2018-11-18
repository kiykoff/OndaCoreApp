using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalleryStructService;
using Microsoft.AspNetCore.Mvc;
using OndaCore.Models;




namespace OndaCore.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            ImageGalleryModel ImageGalleryModel = new ImageGalleryModel();
            
            return View(ImageGalleryModel.GetProductStruct());

        }

        [HttpGet]
        public IActionResult Index (string id)
        {
            ImageGalleryModel ImageGalleryModel = new ImageGalleryModel();

            return View(ImageGalleryModel.GetProductStruct(id));
            
        }

        [HttpGet]
        public IActionResult Items(string id = "all")
        {
            ViewBag.id = id;
            return PartialView("Items");
        }
    }
}