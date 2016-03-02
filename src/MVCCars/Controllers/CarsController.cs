using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVCCars.Models;
using MVCCars.ViewModels;

namespace MVCCars.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            var dataManager = new DataManager();
            var model = dataManager.ListCars();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
