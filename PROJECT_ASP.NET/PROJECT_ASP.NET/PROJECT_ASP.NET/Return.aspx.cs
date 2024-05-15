using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class Return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void tampilData()
        {
            string display = "<table id = 'table' class='table table-striped' table = 'bordered' styles='width : 100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>Return ID</th>";
            display += "<th>Rental ID</th>";
            display += "<th>Car ID</th>";
            display += "<th>Customer ID</th>";
            display += "<th>Date Returned</th>";
            display += "<th>Fee</th>";
            display += "<th>Total</th>";
            display += "<th>Status</th>";
            display += "</tr>";
            display += "</thead>";
            display += "<tbody>";

            Models.Return car = new Models.Return();
            string flag = car.Read();
            if (flag == "OK")
            {
                foreach (DataRow dr in car.ds.Tables[0].Rows)
                {
                    display += "<tr>";
                    foreach (DataColumn dc in car.ds.Tables[0].Columns)
                    {
                        display += "<td>" + dr[dc.ColumnName].ToString() + "</td>";
                    }
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