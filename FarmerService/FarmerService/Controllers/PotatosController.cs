using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotatosController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalculateResults(int[] potatoes)
        {

            int sum = 0;
            string message = "";
            for (int i = 0; i < potatoes.Length; i++)
            {
                sum += potatoes[i];
            }
            message += $"Is viso bulviu buvo parduota {sum} kg. ";

            // vidurkio skaiciavimas
            var average = (double)sum / potatoes.Length;
            message += $"Vieno ukininko parduotu bulviu vidurkis yra {average} kg.";
            // suskaiciuoti tuos kurie pardave daugiau
            int counter = 0;
            for (int i = 0; i < potatoes.Length; i++)
            {
                if (potatoes[i] > 50)
                {
                    counter++;
                }
            }
            message += $"Ukininku kurie pardave daugiau negu 50 kg yra {counter} ";

                return new OkObjectResult(message);
        }
            
    }
}
