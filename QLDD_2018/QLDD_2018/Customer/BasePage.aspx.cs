using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLDD_2018.Customer
{
    public partial class BasePage : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            var sessionLogin = Session["login"];
            if (sessionLogin == null || sessionLogin == "false")
            {
                Response.Redirect("/Admin/User/login.aspx");
            }
        }
    }
}