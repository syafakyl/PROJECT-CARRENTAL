using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class UpdateTransaction : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            kode = Request.QueryString["id"];
            Label1.Text = "Apakah Mobil Telah Dikembalikan?";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Return update = new Models.Return();
            update.Id_Rental = kode;
            string flag = update.UpdateStatus();
            if (flag == "OK")
            {
                response.Text = GlobalVariable.getSuccess("Data Berhasil Diupdate");
                Button1.Visible = false;
                Button2.Text = "Kembali";
            }
            else
            {
                response.Text = GlobalVariable.getFail("Data Gagal Diupdate");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction.aspx");
        }
    }
}