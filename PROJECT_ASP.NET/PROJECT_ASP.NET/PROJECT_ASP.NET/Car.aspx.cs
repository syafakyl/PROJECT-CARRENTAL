using PROJECT_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PROJECT_ASP.NET
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void clearData()
        {
            txtCar.Text = "";
            txtBrand.Text = "";
            txtPlat.Text = "";
            txtYear.Text = "";
            txtCost.Text = "";
        }

        private void tampilData()
        {
            string display = "<table id = 'table' class='table table-striped' table = 'bordered' styles='width : 100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>Car ID</th>";
            display += "<th>Car Name</th>";
            display += "<th>Brand ID</th>";
            display += "<th>Plate Number</th>";
            display += "<th>Years</th>";
            display += "<th>Cost</th>";
            display += "<th>Car Status</th>";
            display += "<th>Action</th>";
            display += "</tr>";
            display += "</thead>";
            display += "<tbody>";

            Models.Car car = new Models.Car();
            string flag = car.Read();
            if(flag == "OK")
            {
                foreach (DataRow dr in car.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in car.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='EditCar.aspx?id=" + dr[0].ToString() +"' class='btn btn-warning'>Edit</a>";
                    display += "<a>  |  </a>";
                    display += "<a href='DeleteCar.aspx?id=" + dr[0].ToString() + "' class='btn btn-danger'>Delete</a>";
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Car input = new Models.Car();
            input.Car_Name = txtCar.Text;
            input.Id_Brand = txtBrand.Text;
            input.Plat_Number = txtPlat.Text;
            input.Years = txtYear.Text;
            input.Cost = txtCost.Text;
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