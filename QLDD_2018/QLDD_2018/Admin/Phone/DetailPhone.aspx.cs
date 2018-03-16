using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;
using Models;
namespace QLDD_2018.Admin.Phone
{
    public partial class DetailPhone : System.Web.UI.Page
    {
        private PhoneController controller = new PhoneController();
        private CompanyController controllerC = new CompanyController();
        private PhoneCategoryController cateController = new PhoneCategoryController();
        private PhoneDetailController detailController = new PhoneDetailController();
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Request.Params["id"];
            p_phone phone = controller.FindPhoneById(id);
            if(phone != null)
            {
                p_phone_detail detail = detailController.FindOneById(phone.phone_category_id);
            }
        }
    }
}