using PROJECT_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class Avanza : System.Web.UI.Page
    {
        string flag;
        public DataSet ds = new DataSet();
        Koneksi koneksi= new Koneksi(); 
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
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
            string flag = car.Avanza();
            if (flag == "OK")
            {
                foreach (DataRow dr in car.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in car.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
                    display += "<td>";
                    display += "<a href='Rental.aspx?id=" + dr[0].ToString() + "' class='btn btn-warning'>Rent</a>";
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
    }
}