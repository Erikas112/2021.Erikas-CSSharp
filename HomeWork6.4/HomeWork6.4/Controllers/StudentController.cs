
using HomeWork6._4.Modells;
using HomeWork6._4.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeWork6._4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
     

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (student.Name == "")
            {
                return ValidationProblem("Nenurodete vardo!");
            }

            if (student.Surname == "")
            {
                return ValidationProblem("Nenurodete pavardes!");

            }
            if (student.DocumentId == "")
            {
                return ValidationProblem("Nenurodete dokumento!");

            }

            if (student.BirtDay == System.DateTime.MinValue)
            {
                return ValidationProblem("Nenurodete gimimo dienos!");

            }
            var service = new StudentService();           
            service.CreateStudent(student);

            return Ok();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var service = new StudentService();

            var students = service.GetStudents();

            return new OkObjectResult(students);
        }

        [HttpGet]
        public IActionResult Get(string documentId)
        {
            var service = new StudentService();

            var student = service.GetStudent(documentId);
            
            return  new OkObjectResult(student);
        }


        [HttpGet("filter")]
        public IActionResult Filter(string text)
        {
            var service = new StudentService();

            var students = service.GetStudents();

            var filteredStudents = new List<Student>();

            foreach (var student in students)
            {
                if (student.GetInformation().Contains(text))
                {
                    filteredStudents.Add(student);
                }
            }
            return new ObjectResult(filteredStudents);
        }
     }
    
    
}
