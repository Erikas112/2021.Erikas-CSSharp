using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4._1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherTemperatureController : ControllerBase
    {
        [HttpPost]
        public IActionResult WeatherTemperature(int [] celsijaus)
        {
            int temperature = int.MaxValue;
            string message = ("");
            for (int i = 0; i < celsijaus.Length; i++)
            {
                if (celsijaus[i] < temperature )
                {
                    temperature = celsijaus[i];
                  
                }
                message += $"Is pateiktu oro temperaturu maziausia temperatura yra {temperature} laipsniai celsijaus,  ";

                int temperature2 = int.MinValue;
                for (int y = 0; y <celsijaus.Length; y++)
                if (celsijaus[i] > temperature2)
                {
                    temperature2 = celsijaus[i];
                }
                message += $"Is pateiktu oro temperaturu didziausia yra {temperature2} laipsniai celsijaus, ";

                var average  =  temperature / celsijaus.Length;
                message += $"vidutine oro temperatura yra {average} laipsniu celsijaus.";
            }
            return new OkObjectResult(message);
        }
    }
}
