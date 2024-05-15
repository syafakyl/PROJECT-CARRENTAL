using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PROJECT_ASP.NET.Models
{
    public class Koneksi
    {
        string source;
        public SqlConnection con;

        public Koneksi()
        {
            try
            {
                source = "Integrated Security=true;Initial Catalog=car_rental;Data Source=.";
                con = new SqlConnection(source);
            }
            catch (Exception sqle)
            {
                Console.WriteLine("Error: " + sqle.Message);
            }
        }


        public void bukaKoneksi()
        {
            try
            {
                con.Open();
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Error: " + sqle.Message);
            }
        }

        public void tutupKoneksi()
        {
            try
            {
                con.Close();
            }
            catch (SqlException sqle)
            {
                Console.WriteLine("Error: " + sqle.Message);
            }
        }
    }
}