using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCars.ViewModels
{
    public class CreateCarViewModel
    {
        [Display(Name = "Make")]
        [Required(ErrorMessage = "Must have a make!")]
        public string Brand { get; set; }

        [Range(3, 5, ErrorMessage = "Must have 3-5 doors")]
        public int Doors { get; set; }

        //[Required(ErrorMessage = "")]
        [Range(0, 300, ErrorMessage = "Speed must be within 0 and 300!")]
        public int TopSpeed { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "You must accept Terms & Conditions")]
        [Display(Name = "I Accept Terms and conditions")]
        public bool AcceptTerms {get; set; }
    }
}
