using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork<Owner> _owner;

        public HomeController(ILogger<HomeController> logger,
                              IUnitOfWork<Owner> owner  )
        {
            _logger = logger;
            _owner = owner;

        }

        public IActionResult Index()
        {
            var entity = _owner.Entity.GetAll().First() ;
            return View(entity);
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