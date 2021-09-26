using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork6._4.Modells
{
    public class Student
    {

        public Student(string name, string surname, DateTime birtDay, string documentId)
        {
            Name = name;
            Surname = surname;
            BirtDay = birtDay;
            DocumentId = documentId;
            Age = DateTime.Now.Year - birtDay.Year;
        }


        public string Name { get;}
        public string Surname { get; }
        public DateTime BirtDay { get;}
        public string DocumentId { get;}
        public int Age { get;}

        public string GetInformation()
        {
            return $"{Name} {Surname} {BirtDay.ToString("yyyy-MM-dd")} {DocumentId} {Age}";
        }
    }
}
