
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeWork6._2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        [HttpPost]
        public IActionResult FilterNumbers(int[] numbers)
        {
            var filteredNumbers = new List<int>();
            foreach(var number in numbers)
            {
                if (number % 5 == 0)
                {
                    filteredNumbers.Add(number);
                }
            }
            return new OkObjectResult (filteredNumbers);
        }
    }
}
