using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLDD_2018.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        public String a = "quang vu";
        protected void Page_Load(object sender, EventArgs e)
        {
            a = "nuce";
        }
    }
}