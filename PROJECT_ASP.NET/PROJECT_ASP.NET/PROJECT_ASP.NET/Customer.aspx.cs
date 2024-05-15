using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class Customer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void clearData()
        {
            txtNIK.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void tampilData()
        {
            string display = "<table id = 'table' class='table table-striped' table = 'bordered' styles='width : 100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>ID</th>";
            display += "<th>NIK</th>";
            display += "<th>Name</th>";
            display += "<th>Email</th>";
            display += "<th>Password</th>";
            display += "<th>Phone</th>";
            display += "<th>Address</th>";
            display += "<th>Action</th>";
            display += "</tr>";
            display += "</thead>";
            display += "<tbody>";

            Models.Customers obj = new Models.Customers();
            string flag = obj.Read();
            if (flag == "OK")
            {
                foreach (DataRow dr in obj.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in obj.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='EditCustomer.aspx?id=" + dr[0].ToString() + "' class='btn btn-warning'>Edit</a>";
                    display += "<a>  |  </a>";
                    display += "<a href='DeleteCustomer.aspx?id=" + dr[0].ToString() + "' class='btn btn-danger'>Delete</a>";
                    display += "</td>";

                    display += "</tr>";
                }
                display += "</tbody>";
                display += "</table>";
                lt_table.Text = display;
            }
            else
            {
                lt_table.Text = "Tidak ada data tersedia";
            }
        }

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Models.Customers input = new Models.Customers();
            input.NIK = txtNIK.Text;
            input.Name = txtName.Text;
            input.Email = txtEmail.Text;
            input.Password = txtPassword.Text;
            input.Phone = txtPhone.Text;
            input.Address = txtAddress.Text;
            string flag = input.Create();
            if (flag == "OK")
            {
                response.Text = GlobalVariable.getSuccess("Data Berhasil Disimpan");
                clearData();
                tampilData();
            }
            else
            {
                response.Text = GlobalVariable.getFail("Data Gagal Disimpan");
            }
        }
    }
}