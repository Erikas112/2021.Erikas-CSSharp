using HomeWork6._4.Modells;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;


namespace HomeWork6._4.Service
{
    public class StudentService
    {

        private string _connection;

        public StudentService()
        {
            IConfiguration config = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                  .Build();

            _connection = config.GetValue<string>("ConnectionStrings:DefaultConnection");
        }


        public List<Student> GetStudents()
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();
            var students = new List<Student>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT documentId, name, surname, birtday FROM students";

                var reader = cmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var student = new Student(
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDateTime(3),
                            reader.GetString(0));

                        students.Add(student);
                    }
                   
                }
            }

            return students;
        }

       public Student GetStudent(string documentId)
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT documentId, name, surname, birtday From students WHERE documentId = @documentId";
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@documentId",
                     DbType = System.Data.DbType.String,
                     Value = documentId
                 }   
               );

                var reader = cmd.ExecuteReader();

                using (reader)
                {
                    reader.Read();
                    return new Student(
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3),
                        reader.GetString(0)
                        
                        );
                }
       
            }
        }

        public void CreateStudent (Student student)
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            using(var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO students (documentId, name, surname, birtday) " +
                    "VALUES(@documentId, @name, @surname, @birtday)";

                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@documentId",
                     DbType = System.Data.DbType.String,
                     Value = student.DocumentId
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@name",
                     DbType = System.Data.DbType.String,
                     Value = student.Name
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@surname",
                     DbType = System.Data.DbType.String,
                     Value = student.Surname
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@birtday",
                     DbType = System.Data.DbType.DateTime,
                     Value = student.BirtDay
                 }
               );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
