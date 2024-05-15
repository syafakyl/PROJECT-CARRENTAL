using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        private void tampilData()
        {
            string display = "<table id = 'table' class='table table-striped' table = 'bordered' styles='width : 100%'>";
            display += "<thead>";
            display += "<tr>";
            display += "<th>Rental ID</th>";
            display += "<th>Car ID</th>";
            display += "<th>Customer ID</th>";
            display += "<th>Date Borrow</th>";
            display += "<th>Date Return</th>";
            display += "<th>Total</th>";
            display += "<th>Action</th>";
            display += "</tr>";
            display += "</thead>";
            display += "<tbody>";

            Models.Transaction obj = new Models.Transaction();
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
                    display += "<a href='UpdateTransaction.aspx?id=" + dr[0].ToString() + "' class='btn btn-warning'>Return</a>";
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