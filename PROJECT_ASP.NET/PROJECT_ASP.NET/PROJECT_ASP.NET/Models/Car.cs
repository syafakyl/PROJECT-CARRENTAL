using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PROJECT_ASP.NET.Models
{
    public class Car
    {
        public string Id_Car;
        public string Car_Name;
        public string Id_Brand;
        public string Plat_Number;
        public string Years;
        public string Cost;
        string flag;
        public DataSet ds = new DataSet();

        Koneksi koneksi = new Koneksi();

        public string Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Car (Car_Name, Id_Brand, Plat_Number, Years, Cost) VALUES (@Car_Name, @Id_Brand, @Plat_Number, @Years, @Cost)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Car_Name", Car_Name);
                com.Parameters.AddWithValue("@Id_Brand", Id_Brand);
                com.Parameters.AddWithValue("@Plat_Number", Plat_Number);
                com.Parameters.AddWithValue("@Years", Years);
                com.Parameters.AddWithValue("@Cost", Cost);
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

        public string Update()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE Car SET Car_Name = @Car_Name, Id_Brand = @Id_Brand, Plat_Number = @Plat_Number, Years = @Years, Cost = @Cost WHERE Id_Car = @Id_Car";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Car", Id_Car);
                com.Parameters.AddWithValue("@Car_Name", Car_Name);
                com.Parameters.AddWithValue("@Id_Brand", Id_Brand);
                com.Parameters.AddWithValue("@Plat_Number", Plat_Number);
                com.Parameters.AddWithValue("@Years", Years);
                com.Parameters.AddWithValue("@Cost", Cost);
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

        public string Read()
        {
            try
            {
                string query = "SELECT * FROM Car";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public string Avanza()
        {
            try
            {
                string query = "SELECT * FROM Car WHERE Car_Name = 'Avanza' AND Car_Status = 'Available'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public string Innova()
        {
            try
            {
                string query = "SELECT * FROM Car WHERE Car_Name = 'Innova' AND Car_Status = 'Available'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public string Fortuner()
        {
            try
            {
                string query = "SELECT * FROM Car WHERE Car_Name = 'Fortuner'AND Car_Status = 'Available'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public string Brio()
        {
            try
            {
                string query = "SELECT * FROM Car WHERE Car_Name = 'Brio' AND Car_Status = 'Available'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public string HRV()
        {
            try
            {
                string query = "SELECT * FROM Car WHERE Car_Name = 'HRV' AND Car_Status = 'Available'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public string Civic()
        {
            try
            {
                string query = "SELECT * FROM Car WHERE Car_Name = 'Civic' AND Car_Status = 'Available'";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Car");
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

        public ArrayList cariData() 
        {
            ArrayList data = new ArrayList();
            SqlDataReader dr = null;
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT * FROM Car WHERE Id_Car = @Id_Car";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Car" , Id_Car);
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

        public string Delete()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "DELETE Car WHERE Id_Car = @Id_Car";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("Id_Car", Id_Car);
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
    }
}