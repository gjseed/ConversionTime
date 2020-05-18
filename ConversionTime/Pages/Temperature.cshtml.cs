using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConversionTime.Pages
{
    public class TemperatureModel : PageModel
    {
        [BindProperty]
        public double FahtoCel { get; set; }
        [BindProperty]
        public double CeltoFah { get; set; }


        public void OnPost()
        {
            //var TempOpt = Request.Form["TempOpt"];
            double convertedTemp;
            if (TempOpt == 1)
            {
                //ViewData["convertedTemp"] = (FahtoCel - 32) * 5 / 9;
                convertedTemp = (FahtoCel - 32) * 5 / 9;

            }
            else
            {
                //ViewData["convertedTemp"] = (CeltoFah * 9 / 5) + 32;
                convertedTemp = (CeltoFah * 9 / 5) + 32;

            }
        }
        public void OnGet()
        {

        }
    }
}