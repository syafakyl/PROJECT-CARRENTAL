using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class EditCar : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                kode = Request.QueryString["id"];
                Models.Car obj = new Models.Car();
                obj.Id_Car = kode;

                ArrayList data = obj.cariData();
                txtID.Text = data[0].ToString();
                txtCar.Text = data[1].ToString();
                txtBrand.Text = data[2].ToString();
                txtPlat.Text = data[3].ToString();
                txtYear.Text = data[4].ToString();
                txtCost.Text = data[5].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Car update = new Models.Car();
            update.Id_Car = txtID.Text;
            update.Car_Name = txtCar.Text;
            update.Plat_Number = txtPlat.Text;
            update.Id_Brand = txtBrand.Text;
            update.Years = txtYear.Text;
            update.Cost = txtCost.Text;
            string flag = update.Update();
            if (flag == "OK")
            {
                response.Text = GlobalVariable.getSuccess("Data Berhasil Diubah");
                txtID.Visible = false;
                txtCar.Visible = false;
                txtBrand.Visible = false;
                txtPlat.Visible = false;
                txtYear.Visible = false;
                txtCost.Visible = false;
                Label1.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Button1.Visible = false;
            }
            else
            {
                response.Text = GlobalVariable.getFail("Data Gagal Diubah");
            }
        }
    }
}