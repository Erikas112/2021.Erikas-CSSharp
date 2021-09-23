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
            int temperature = 0;
            string message = ("");
            for (int i = 0; i < celsijaus.Length; i++)
            {
               if (celsijaus[i] > temperature)
                {
                    temperature = celsijaus.Length;
                }
                message = $" yra {temperature}";
            }
            return new OkObjectResult(message);
        }
    }
}
