using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class EditCustomer : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                kode = Request.QueryString["id"];
                Models.Customers obj = new Models.Customers();
                obj.Id_Customer = kode;

                ArrayList data = obj.cariData();
                txtID.Text = data[0].ToString();
                txtNIK.Text = data[1].ToString();
                txtName.Text = data[2].ToString();
                txtEmail.Text = data[3].ToString();
                txtPassword.Text = data[4].ToString();
                txtPhone.Text = data[5].ToString();
                txtAddress.Text = data[6].ToString();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Models.Customers update = new Models.Customers();
            update.Id_Customer = txtID.Text;
            update.NIK = txtNIK.Text;
            update.Name = txtName.Text;
            update.Email = txtEmail.Text;
            update.Password = txtPassword.Text;
            update.Phone = txtPhone.Text;
            update.Address = txtAddress.Text;
            string flag = update.Update();
            if (flag == "OK")
            {
                response.Text = GlobalVariable.getSuccess("Data Berhasil Diubah");
                txtID.Visible = false;
                txtNIK.Visible = false;
                txtName.Visible = false;
                txtEmail.Visible = false;
                txtPassword.Visible = false;
                txtPhone.Visible = false;
                txtAddress.Visible = false;
                Label1.Visible = false;
                Label2.Visible = false;
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