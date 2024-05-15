using PROJECT_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userinfo"];
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Customers login = new Customers();
            login.Email = txtEmail.Value;
            login.Password = txtPassword.Value;
            string flag = login.doLogin();
            if (flag == "OK")
            {
                if (CheckBox1.Checked)
                {
                    HttpCookie userinfo = Request.Cookies["userinfo"];
                    userinfo["Email"] = login.Email;
                    userinfo.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(userinfo);
                }
                Session["Email"] = login.Email;
                Response.Write("<script>alert('Login Berhasil');</script>");
                Response.Redirect("User.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login Gagal');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Customers regis = new Customers();
            regis.NIK = txtNIK.Text;
            regis.Name = txtName.Text;
            regis.Email = txtEmailR.Text;
            regis.Password = txtPasswordR.Value;
            regis.Phone = txtPhone.Text;
            regis.Address = txtAddress.Text;
            string flag = regis.Create();
            if (flag == "OK")
            {
                Response.Write("<script>alert('Register Berhasil');</script>");
                Response.Redirect("login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Register Gagal');</script>");

            }
        }
    }
}