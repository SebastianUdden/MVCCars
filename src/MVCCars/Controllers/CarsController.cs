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
        public IActionResult Create(CreateCarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                var dataManager = new DataManager();
                dataManager.AddCar(viewModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError(nameof(CreateCarViewModel.Brand), "Wrong dude! Try again!");
                return View();
            }
            return RedirectToAction(nameof(CarsController.Index));
        }
    }
}
