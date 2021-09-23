using HomeWork6._4.Modells;
using System;
using System.Collections.Generic;


namespace HomeWork6._4.Service
{
    public class StudentService
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>();

            students.Add(
                new Student(
                "Jonas", 
                "Jonaitis", 
                new DateTime(2000, 1, 1), 
                "abb123"
                )
                );
            students.Add(
                new Student(
                "Onute",
                "Pakalnute",
                new DateTime(2001, 1, 1),
                "abs145"
                )
                );
            students.Add(
                new Student(
                "Petras",
                "Petraitis",
                new DateTime(2012, 1, 1),
                "axs123"
                )
                );

            students.Add(
                new Student(
                "Barbora",
                "Bora",
                new DateTime(1991, 1, 1),
                "asdaff"
                )
                );

            students.Add(
                new Student(
                "Greta",
                "Geriete",
                new DateTime(1999, 1, 1),
                "adsff3"
                )
                );





            return students;
        }

       
    }
}
