using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PROJECT_ASP.NET.Models
{
    public class admin
    {
        public string Username;
        public string Password;

        Koneksi koneksi = new Koneksi();

        public string doLogin()
        {
            string Name = "";
            koneksi.bukaKoneksi();
            try
            {
                string query = "SELECT * FROM Admins WHERE Username = @Username AND Password = @Password";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Username", Username);
                com.Parameters.AddWithValue("@Password", Password);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string data = "SELECT Name from Admins WHERE Username = @Username";
                    SqlCommand comdata = new SqlCommand(data, koneksi.con);
                    comdata.Parameters.AddWithValue("@Username", Username);
                    SqlDataReader sr = comdata.ExecuteReader();
                    if (sr.Read())
                    {
                        Name = sr[0].ToString();
                    }
                    sr.Close();
                }
                else
                {
                    Console.WriteLine("Login Gagal");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            koneksi.tutupKoneksi();
            return Name;
        }

    }
}