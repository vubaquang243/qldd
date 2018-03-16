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
    public partial class Phone : System.Web.UI.Page
    {
        private PhoneController controller = new PhoneController();
        public List<p_phone> lst = new List<p_phone>();
        private CompanyController controllerC = new CompanyController();
        private PhoneCategoryController cateController = new PhoneCategoryController();
        public String alert = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            PhoneForm form = new PhoneForm();
            if (txtPhoneId.Text != null && ""!=txtPhoneId.Text) {
                form.phoneId = txtPhoneId.Text;
            }
            if(txtCost.Text != null &&  "" != txtCost.Text )
            {
                form.cost = txtCost.Text;
            }
            if(txtDateIssueFrom != null && ""!=txtDateIssueFrom.Text)
            {
                form.dateIssueFrom = DateTime.Parse(txtDateIssueFrom.Text);
            }
            if(txtDateIssueTo != null && "" != txtDateIssueTo.Text)
            {
                form.dateIssueTo = DateTime.Parse(txtDateIssueTo.Text);
            }

                lst = controller.getAllPhone();
             

            ddlCompany.DataSource = controllerC.GetAll();
            ddlCompany.DataTextField = "name";
            ddlCompany.DataValueField = "company_id";
            ddlCompany.DataBind();
            if (Session["success"] != null)
            {
                alert = Session["success"].ToString();
                Session.Remove("success");
            }
            String id = Request.Params["id"];
            if(id != null && !id.Equals(""))
            {
                controller.DeletePhone(id);
                Session.Add("success","Xóa thành công");
                alert = Session["success"].ToString();
            }
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            String companyId = ddlCompany.SelectedValue;
            ddlPhoneCategory.DataSource = cateController.getAllByCompanyId(companyId);
            ddlPhoneCategory.DataTextField = "phone_category_name";
            ddlPhoneCategory.DataValueField = "phone_category_id";
            ddlPhoneCategory.DataBind();
        }
    }
}