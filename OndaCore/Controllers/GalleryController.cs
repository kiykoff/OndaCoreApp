using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OndaCore.Models;




namespace OndaCore.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            ImageGalleryModel ImageGalleryModel = new ImageGalleryModel();
            AxdWebGalleryStruct structure = ImageGalleryModel.GetProductStruct();
            return View(structure);
            
        }

        public IActionResult Materials()
        {
            return View();
        }
    }
}