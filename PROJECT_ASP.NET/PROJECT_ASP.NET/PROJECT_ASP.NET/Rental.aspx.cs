using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PROJECT_ASP.NET
{
    public partial class RentAvanza : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userinfo"];
            TextBox5.Text = userinfo["Id_Customer"];
            if (!Page.IsPostBack)
            {
                kode = Request.QueryString["id"];
                Models.Car obj = new Models.Car();
                obj.Id_Car = kode;

                ArrayList data = obj.cariData();
                TextBox1.Text = data[0].ToString();
                TextBox2.Text = data[5].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userinfo"];
            Models.Transaction input = new Models.Transaction();
            input.Id_Car = TextBox1.Text;
            input.Id_Customer = TextBox5.Text;
            input.Date_Borrow = DateTime.Parse(txtBorrow.Value);
            input.Date_Return = DateTime.Parse(txtReturn.Value);
            input.Total = Convert.ToInt32(TextBox2.Text);
            string flag = input.Create();
            if (flag == "OK")
            {
                Response.Write("<script>alert('Pemesanan Berhasil');</script>");
                Response.Redirect("history.aspx");
            }
            else
            {
                Response.Write("<script>alert('Pemesanan Gagal');</script>");
            }
        }
    }
}