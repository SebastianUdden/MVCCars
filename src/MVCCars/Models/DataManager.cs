using MVCCars.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCars.Models
{
    public class DataManager
    {
        static List<Car> cars = new List<Car>();

        public void AddCar(CreateCarViewModel viewModel)
        {

        }

        public List<ListCarViewModel> ListCars()
        {
            List<ListCarViewModel> carViews = new List<ListCarViewModel>();

            //foreach (var car in cars)
            //{
            //    carViews.Add(new ListCarViewModel);
            //}
            return carViews;
        }
    }
}
