using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly DemoContext _db;

        public HomeController(DbContextOptions<DemoContext> options)
        {
            _db = new DemoContext(options);
        }

        public IActionResult Index()
        {
            var pajeras = _db.Pajera.AsQueryable()
                .Include(x => x.SubPajeras)
                .Include(x => x.Inspecciones)
                .Include(x => x.Adjuntos);

            var adjuntos = _db.Adjunto.AsQueryable()
                .Include(x => x.Pajera)
                .Include(x => x.SubPajera)
                .Include(x => x.Inspeccion);

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
