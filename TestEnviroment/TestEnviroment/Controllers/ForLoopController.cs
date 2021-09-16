using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEnviroment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ForLoopController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult FirstExample()
        //{
        //    string line = "";
        //    for (int i = 0; i <10; i++)
        //    {
        //        if(i % 2 == 0) // modaline dalyba kai grazinama liekana
        //        {
        //            line += i + "\n";
        //        }
                
        //    } 
            

        //    return new OkObjectResult(line);
        //}


        [HttpGet]
        public IActionResult SecondExample()
        {
            string result = "";
            for (int i = 0; i < 30; i+=3)
            {
                    result += i + ", ";
            }
            result = result.Remove(result.Length -2, 2);
            return new OkObjectResult(result);
        }
    }

}
