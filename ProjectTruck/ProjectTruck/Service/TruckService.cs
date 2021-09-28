using Microsoft.Extensions.Configuration;
using MySqlConnector;
using ProjectTruck.Models;
using System.Collections.Generic;


namespace ProjectTruck.Service
{
    public class TruckService
    {
        private string _connection;
        public TruckService()
        {
            IConfiguration config = new ConfigurationBuilder()
                  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                  .Build();

            _connection = config.GetValue<string>("ConnectionStrings:DefaultConnection");
        }
        public List<Truck> GetTrucks()
        {
            MySqlConnection conn = new MySqlConnection(_connection);
            conn.Open();
            var trucks = new List<Truck>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT name, model, yearOfManufacture, description, id FROM truck";
                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        var truck = new Truck(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetString(3),
                            reader.GetInt32(4));
                        trucks.Add(truck);
                    }
                }
            }
            return trucks;
        }
        public Truck GetTruck(int id)
        {
            MySqlConnection conn = new MySqlConnection(_connection);
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT name, model, yearOfManufacture, description, id FROM truck WHERE id = @id";
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@id",
                     DbType = System.Data.DbType.Int32,
                     Value = id
                 }
               );
                var reader = cmd.ExecuteReader();
                using (reader)
                {
                    reader.Read();
                    return new Truck(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDateTime(2),
                        reader.GetString(3),
                        reader.GetInt32(4));
                }
            }
        }
        public void CreateTruck(Truck truck)
        {
            MySqlConnection conn = new MySqlConnection(_connection);
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO truck (name, model, yearOfManufacture, description, id) " +
                    "VALUES(@name, @model, @yearOfManufacture, @description, @id)";
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@name",
                     DbType = System.Data.DbType.String,
                     Value = truck.Name
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@model",
                     DbType = System.Data.DbType.String,
                     Value = truck.Model
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@yearOfManufacture",
                     DbType = System.Data.DbType.DateTime,
                     Value = truck.YearOfManufacture
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@description",
                     DbType = System.Data.DbType.String,
                     Value = truck.Description
                 }
               );
                cmd.Parameters.Add(
                 new MySqlParameter()
                 {
                     ParameterName = "@id",
                     DbType = System.Data.DbType.Int32,
                     Value = truck.Id
                 }
               );
                cmd.ExecuteNonQuery();
            }
        }
    }
}
