using BusinessLogic;
using CrashCourse.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrashCourse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService _carService;
        private readonly IOrganizationService _organizationService;

        public HomeController(ILogger<HomeController> logger,
            ICarService carService,
            IOrganizationService organizationService)
        {
            _logger = logger;
            _carService = carService;
            _organizationService = organizationService;
        }

        public IActionResult Index()
        {
            var homeViewModel = new CarHomeViewModel();
            homeViewModel.Organization = _organizationService.GetById(1);
            homeViewModel.Cars = _carService.GetCars();


            return View(homeViewModel);
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
