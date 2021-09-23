
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HomeWork6._1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpPost]
        public IActionResult FindLongestName(string[]names)
        {
            var maxValue = 0;
            var longestName = "";
            foreach (var name in names)
            {
                var nameLength = name.Length;

                if (maxValue <= nameLength)
                {
                    maxValue = nameLength;
                    longestName = name;
                }
               
            }

            return new OkObjectResult($"Ilgiausias vardas yra {longestName}, jo ilgis yra {maxValue} simbolių");
        }

    }
}
