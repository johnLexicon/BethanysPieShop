using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository repository)
        {
            _pieRepository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Pie Overview";
            var pies = _pieRepository.GetAllPies().ToList<Pie>();

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany's Pie Shop",
                Pies = pies
            };

            return View(homeViewModel);
        }
    }
}
