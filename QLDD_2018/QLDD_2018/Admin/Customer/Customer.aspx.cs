using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;
using Models;
namespace QLDD_2018.Admin.Customer
{
    public partial class Customer : System.Web.UI.Page
    {
        private CustomerController controller = new CustomerController();
        public List<p_customer> lstCus = new List<p_customer>();
        public String alert = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            lstCus = controller.getAll();
            String id = Request.Params["id"];
            if(id != null && id!= "")
            {
                p_customer cus = controller.RemoveCustomerById(id);
                if(cus != null)
                {
                    Session.Add("success", "Xóa thành công");
                    alert = Session["success"].ToString();
                }
            }
        }

    }
}