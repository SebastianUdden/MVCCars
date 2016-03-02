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

        static DataManager()
        {
            cars.Add(new Car("Ferarri", 3, 299));
            cars.Add(new Car("Volvo V70", 5, 170));
            cars.Add(new Car("Puma", 3, 247));
        }

        public void AddCar(CreateCarViewModel viewModel)
        {

        }

        public List<ListCarViewModel> ListCars()
        {
            return cars
                .OrderBy(o => o.Brand)
                .Select(o => new ListCarViewModel
                {
                    Brand = o.Brand,
                    ShowAsFast = o.TopSpeed >= 250
                })
                .ToList();
        }
    }
}
