using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCars.ViewModels
{
    public class CreateCarViewModel
    {
        public string Brand { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public bool AcceptTerms {get; set; }
    }
}
