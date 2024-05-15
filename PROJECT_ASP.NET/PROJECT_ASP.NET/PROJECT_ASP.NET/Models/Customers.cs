using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET.Models
{
    public class Customers
    {
        public string NIK;
        public string Name;
        public string Email;
        public string Password;
        public string Phone;
        public string Address;
        public string Id_Customer;
        string flag;
        public DataSet ds = new DataSet();

        Koneksi koneksi = new Koneksi();
        public string Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Customers VALUES (@NIK, @Name, @Email, @Password, @Phone, @Address)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@NIK", NIK);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Email", Email);
                com.Parameters.AddWithValue("@Password", Password);
                com.Parameters.AddWithValue("@Phone", Phone);
                com.Parameters.AddWithValue("@Address", Address);
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
                string query = "UPDATE Customers SET NIK = @NIK, Name = @Name, Email = @Email, Password = @Password, Phone = @Phone, Address = @Address WHERE Id_Customer = @Id_Customer";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@NIK", NIK);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@Email", Email);
                com.Parameters.AddWithValue("@Password", Password);
                com.Parameters.AddWithValue("@Phone", Phone);
                com.Parameters.AddWithValue("@Address", Address);
                com.Parameters.AddWithValue("@Id_Customer", Id_Customer);
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

        public string doLogin()
        {
            koneksi.bukaKoneksi();

            try
            {
                string query = "SELECT * FROM Customers WHERE Email = @Email AND Password = @Password";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Email", Email);
                com.Parameters.AddWithValue("@Password", Password);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    string Id_Customer = dr[0].ToString();
                    string NIK = dr[1].ToString();
                    string Name = dr[2].ToString();
                    string Email = dr[3].ToString();
                    string Password = dr[4].ToString();
                    string Phone = dr[5].ToString();
                    string Address = dr[6].ToString();
                    Console.WriteLine("berhasil masuk, Halo " + Name);

                    HttpCookie userinfo = new HttpCookie("userinfo");
                    userinfo["Id_Customer"] = Id_Customer;
                    userinfo["NIK"] = NIK;
                    userinfo["Name"] = Name;
                    userinfo["Email"] = Email;
                    userinfo["Password"] = Password;
                    userinfo["Phone"] = Phone;
                    userinfo["Address"] = Address;
                    userinfo.Expires = DateTime.Now.AddYears(1);
                    HttpContext.Current.Response.Cookies.Add(userinfo);
                    flag = "OK";
                }
                else
                {
                    Console.WriteLine("Login Gagal");
                    flag = "FAIL";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            koneksi.tutupKoneksi();
            return flag;
        }

        public string Delete()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "DELETE Customers WHERE Id_Customer = @Id_Customer";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("Id_Customer", Id_Customer);
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
                string query = "SELECT * FROM Customers";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Customers");
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
                string query = "SELECT * FROM Customers WHERE Id_Customer = @Id_Customer";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@Id_Customer", Id_Customer);
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
    }
}