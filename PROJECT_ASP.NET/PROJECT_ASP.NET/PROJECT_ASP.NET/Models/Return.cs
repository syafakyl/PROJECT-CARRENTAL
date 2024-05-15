using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PROJECT_ASP.NET.Models
{
    public class Return
    {
        public string Id_Return;
        public string Id_Car;
        public string Id_Rental;
        public string Id_Customer;
        public DateTime Date_Returned;
        public int Fee;
        public int Total;
        public string Status_Pengembalian;
        string flag;
        public DataSet ds = new DataSet();

        Koneksi koneksi = new Koneksi();
        public ArrayList cariData()
        {
            ArrayList data = new ArrayList();
            SqlDataReader dr = null;
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT * FROM Pengembalian WHERE Id_Return = @Id_Return";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Return", Id_Return);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    data.Add(dr[0].ToString());
                    data.Add(dr[1].ToString());
                    data.Add(dr[2].ToString());
                    data.Add(dr[3].ToString());
                    data.Add(dr[4].ToString());
                    data.Add(dr[5].ToString());
                    data.Add(dr[6].ToString());
                    data.Add(dr[7].ToString());
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

        public string Update()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE Pengembalian SET Id_Rental = @Id_Rental, Id_Car = @Id_Car, Date_Returned = @Date_Returned, Additional_Charges = @Additional_Charges, Total = @Total WHERE Id_Return = @Id_Return";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Rental", Id_Rental);
                com.Parameters.AddWithValue("@Id_Car", Id_Car);
                com.Parameters.AddWithValue("@Date_Returned", Date_Returned);
                com.Parameters.AddWithValue("@Additional_Charges", Fee);
                com.Parameters.AddWithValue("@Total", Total);
                com.Parameters.AddWithValue("@Status_Pengembalian", Status_Pengembalian);
                com.Parameters.AddWithValue("@Id_Return", Id_Return);
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

        public string UpdateStatus()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE Pengembalian SET Status_Pengembalian = 'Return' WHERE Id_Rental = @Id_Rental";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Rental", Id_Rental);
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

        

        public string History()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT * FROM Pengembalian WHERE Id_Customer = @Id_Customer;";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Customer", Id_Customer);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "History");
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



        public string Read()
        {
            try
            {
                string query = "SELECT * FROM Pengembalian";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Pengembalian");
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