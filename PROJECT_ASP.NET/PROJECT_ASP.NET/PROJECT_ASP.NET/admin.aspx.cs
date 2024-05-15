using PROJECT_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void User_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Models.admin login = new Models.admin();
            login.Username = txtUsername.Text;
            login.Password = txtPassword.Value;
            string hasil = login.doLogin();
            if (hasil != "")
            {
                Response.Write("<script>alert('Login Berhasil');</script>");
                Response.Redirect("dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('Login Gagal');</script>");
            }
        }
    }
}