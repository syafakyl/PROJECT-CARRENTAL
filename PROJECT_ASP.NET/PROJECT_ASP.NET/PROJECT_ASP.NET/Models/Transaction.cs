using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace PROJECT_ASP.NET.Models
{
    public class Transaction
    {
        public string Id_Rental;
        public string Id_Car;
        public string Id_Customer;
        public DateTime Date_Borrow;
        public DateTime Date_Return;
        public int Total;
        string flag;
        public DataSet ds = new DataSet();

        Koneksi koneksi = new Koneksi();
        public string Create()
        {
            try
            {   
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Rental (Id_Car, Id_Customer, Date_Borrow, Date_Return, Total) VALUES (@Id_Car, @Id_Customer, @Date_Borrow, @Date_Return, @Total)";

                int numberOfDays = (Date_Return - Date_Borrow).Days;
                if (numberOfDays > 1)
                {
                    Total *= 2; // Kalikan total dengan 2 jika peminjaman lebih dari 1 hari
                }

                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Car", Id_Car);
                com.Parameters.AddWithValue("@Id_Customer", Id_Customer);
                com.Parameters.AddWithValue("@Date_Borrow", Date_Borrow);
                com.Parameters.AddWithValue("@Date_Return", Date_Return);
                com.Parameters.AddWithValue("@Total", Total);
                int i = com.ExecuteNonQuery();

                if (i > 0)
                {
                    flag = "OK";
                }
                else
                {
                    flag = "FAIL";
                }
            }

            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
            return flag;
        }


        public ArrayList cariData()
        {
            ArrayList data = new ArrayList();
            SqlDataReader dr = null;
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT * FROM Rental WHERE Id_Rental = @Id_Rental";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Rental", Id_Rental);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    data.Add(dr[2].ToString());
                    data.Add(dr[3].ToString());
                    data.Add(dr[4].ToString());
                    data.Add(dr[5].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                data.Add(ex.ToString());
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
            return data;
        }

        public string Read()
        {
            try
            {
                string query = "SELECT Rental.* FROM Rental INNER JOIN Pengembalian ON Rental.Id_Rental = Pengembalian.Id_Rental WHERE Pengembalian.Status_Pengembalian = 'Not Return'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Rental");
                flag = "OK";
            }
            catch (Exception ex)
            {
                flag = ex.Message;
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
            return flag;
        }
    }
}