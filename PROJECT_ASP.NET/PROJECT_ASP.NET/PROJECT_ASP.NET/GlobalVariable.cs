using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_ASP.NET
{
    public class GlobalVariable
    {
        private static string success;
        private static string fail;


        public static string getSuccess(string info)
        {
            success = "";
            success = success + "<div class'alert alert-success alert-dismissible fade show' role='alert'>";
            success = success + "<strong>Success!</strong>" + info;
            success = success + "<button type='button' class='close' data-dismiss='alert' aria-label='close'>";
            success = success + "<span aria-hidden='true'>&times;</span>";
            success = success + "</button>";
            success = success + "</div>";
            return success; 
        }

        public static string getFail(string info)
        {
            fail = "";
            fail = fail + "<div class'alert alert-danger alert-dismissible fade show' role='alert'>";
            fail = fail + "<strong>Failed!</strong>" + info;
            fail = fail + "<button type='button' class='close' data-dismiss='alert' aria-label='close'>";
            fail = fail + "<span aria-hidden='true'>&times;</span>";
            fail = fail + "</button>";
            fail = fail + "</div>";
            return fail;
        }
    }
}