using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConversionTime.Pages
{
    public class MassModel : PageModel
    {
        public int Po2Ou { get; set; }
        public int Ou2Po { get; set; }
        public int Gr2Po { get; set; }
        public int Mg2Po { get; set; }

        public void OnPost()
        {
            //var MassOpt = Request.Form["MassOpt"];
            double convMass = 0;
            if(MassOpt == "1")
            {
                convMass = convMass * 16;
            }else if(MassOpt == "2")
            {
                convMass = convMass / 16;
            }else if (MassOpt == "3")
            {
                convMass = convMass / 454;
            }
            else
            {
                convMass = convMass / 453592;
            }
        }
        public void OnGet()
        {

        }
    }
}