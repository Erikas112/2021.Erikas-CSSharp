using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork6._4.Modells
{
    public class Student
    {

        public Student(string name, string surname, DateTime birtDay, string documnetId)
        {
            Name = name;
            Surname = surname;
            BirtDay = birtDay;
            DocumnetId = documnetId;
            Age = DateTime.Now.Year - birtDay.Year;
        }

        internal static void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public string Name { get;}
        public string Surname { get; }
        public DateTime BirtDay { get;}
        public string DocumnetId { get;}
        public int Age { get;}

        public string GetInformation()
        {
            return $"{Name} {Surname} {BirtDay.ToString("yyyy-MM-dd")} {DocumnetId} {Age}";
        }
    }
}
