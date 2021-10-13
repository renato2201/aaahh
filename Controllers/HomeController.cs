using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pc3.Models;

namespace pc3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PruebaContext _context;

        public HomeController(ILogger<HomeController> logger, PruebaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {   
            var registro = _context.Pruebas.ToList();
            return View(registro);
        }

        public IActionResult Compra()
        {   
            
            return View();
        }
        [HttpPost]
        public IActionResult Compra(Prueba prueba)
        {
            if (ModelState.IsValid){
                _context.Add(prueba);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(prueba);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
