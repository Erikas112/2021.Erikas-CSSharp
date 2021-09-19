using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork3._1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private object numbers;

        [HttpGet]
        public IActionResult HomeWork()
        {

            string result = "Iveskite skaicius nuo [0 - 100]";
            for (int i = 0; i <100 ; i++)
            {
                if ()
            }


            return new OkObjectResult("");
        }
    }
}
