using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;
using Models;
namespace QLDD_2018.Admin.User
{
    public partial class Login : System.Web.UI.Page
    {
        private UserController controller = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.Add("login", 1);
            //Session.RemoveAll();
            //Request.QueryString.Get("id");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Text;
            p_user user = controller.checkLogin(email, password);
            if(user != null)
            {
                Response.Redirect("/Admin/Phone/Phone/aspx");
            }else
            {
                Session["check"] = "thất bại ! Vui lòng thử lại";
            }
        }
    }
}