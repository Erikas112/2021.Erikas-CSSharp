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
            string message = "";

            var sum = CalculateSum(potatoes);
            message += $"Is viso bulviu buvo parduota {sum} kg. ";

            var average = CalculateAverage(sum, potatoes.Length);
            message += $"Vieno ukininko parduotu bulviu vidurkis yra {average} kg.";

            int counter = CalculateFarmersWhoSoldMoreThenFifty(potatoes);


            message += $"Ukininku kurie pardave daugiau negu 50 kg yra {counter} ";

                return new OkObjectResult(message);
        }

        private int CalculateSum(int []collection)
        {
            int sum = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                sum += collection[i];
            }
            return sum;
        }
            private double CalculateAverage(int sum, int count)
        {
            return sum / count;
        }

        private int CalculateFarmersWhoSoldMoreThenFifty(int[] potatoes)
        {
            int counter = 0;
            
            for (int i = 0; i < potatoes.Length; i++)
            {
                if (potatoes[i] > 50)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
