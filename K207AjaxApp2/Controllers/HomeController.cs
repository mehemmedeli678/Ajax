using K207AjaxApp2.Data;
using K207AjaxApp2.Models;
using K207AjaxApp2.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AjaxContextApp _context;
        public HomeController(ILogger<HomeController> logger, AjaxContextApp context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ModelWidthProduct vm = new ModelWidthProduct()
            {
                Marka = _context.Marka.ToList(),
                products = _context.Products.Take(4).ToList(),
                model = _context.Models.ToList(),
                maxPro = _context.Products.Count()
            };
            return View(vm);
        }

        public JsonResult FindModel(int? markaId)
        {
            var modelList = _context.Models.Where(x => x.MarkaId == markaId).ToList();
            return Json(modelList);
        }
        public JsonResult ProductFilter(int skip)
        {
                var prolist = _context.Products.Skip(skip).Take(4).ToList();
                return Json(prolist);
            
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
