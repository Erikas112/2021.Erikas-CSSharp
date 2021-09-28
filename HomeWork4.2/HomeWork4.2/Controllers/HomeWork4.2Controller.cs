using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork4._2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeWork4 : ControllerBase
    {
        [HttpPost]
        public IActionResult Name(string [] nameLength)
        {
            var Length = new string[] { "" };

            return new OkObjectResult ($"{nameLength} vardo ilgis yra {Length} simboliai");

        }
    }
}
