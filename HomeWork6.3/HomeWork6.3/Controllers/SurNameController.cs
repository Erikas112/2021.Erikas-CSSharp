
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeWork6._3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SurNameController : ControllerBase
    {
        [HttpPost]
        public IActionResult FilterSurName(string [] surnames)
        {
            var filterSurnames = new List<string>();
            foreach(string surname in surnames)
            {
                if (surname.ToLower().StartsWith('a'))
                {
                    filterSurnames.Add(surname);
                }
            }
            return new OkObjectResult(filterSurnames);
        }
    }
}
