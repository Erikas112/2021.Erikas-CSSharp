using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEnviroment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameDayController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetNameDay(string name)
        //{
        //    string[] names = {
        //        "Rimgaudas",
        //        "Joginte",
        //        "Kamile",
        //        "Edita",
        //        "Eufemija",
        //        "Gediminas",
        //        "Kornelijus"};

        //    string message = "";
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == name)
        //        {
        //            //TODO logc then find name masive
        //            message = $"Sveikiname su vardo diena! { name}";
        //            break;
        //        }
        //        else
        //        {
        //            //TODO then not find name masiv
        //            var nameInString = string.Join(", ", names);
        //            message = $"Siandien vadro diena svencia! {nameInString}";
        //        }
        //    }

        //    return new OkObjectResult(message);
        //}

        [HttpGet]
        public IActionResult GetNameDay(string [] name)
        {
            string[] names = {
                "Rimgaudas",
                "Joginte",
                "Kamile",
                "Edita",
                "Eufemija",
                "Gediminas",
                "Kornelijus" };


            string message = "";
            if (names.Contains(name))
            {
                message = $"Sveikiname su vardo diena! { name}!";
            }
            else
            {
                var nameInString = string.Join(", ", names);
                message = $"Siandien vadro diena svencia! {nameInString}";
            }
            return new OkObjectResult(message);
    
        }

    }
}
