using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controllers;
using Models;
using System.Web.Services;
using System.Web.Script.Services;

namespace QLDD_2018.Admin.Phone
{
    public partial class AddPhone : System.Web.UI.Page
    {
        private PhoneController controller = new PhoneController();
        public List<p_phone> lst = new List<p_phone>();
        private CompanyController controllerC = new CompanyController();
        private PhoneDetailController controllerD = new PhoneDetailController();
        
        public String error = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlListCompany.DataSource = controllerC.GetAll();
            ddlListCompany.DataTextField = "company_id";
            ddlListCompany.DataValueField = "name";
            ddlListCompany.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            p_phone phone = new p_phone();
            p_phone_detail detail = new p_phone_detail();
            phone.phone_id = getIdPhone(txtPhoneName.Text, ddlListCompany.SelectedValue);
            phone.phone_name = txtPhoneName.Text;
            phone.phone_category_id = ddlListCategoryPhone.SelectedValue;
            phone.date_issue = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
            phone.cost = txtCost.Text;
            phone.company_id = ddlListCompany.SelectedValue;
            phone.code_no = txtCode.Text;
            phone.phone_detail_id = getPhoneIdDetail(phone.phone_id, phone.phone_category_id);

            detail.phone_detail_id = phone.phone_detail_id;
            detail.memory = txtMemory.Text;
            detail.pin = txtPin.Text;
            detail.ram = txtRam.Text;
            detail.screen_size = txtScreenSize.Text;
            p_phone_detail result = controllerD.AddNewPhone(detail);
            p_phone phoneobj = controller.AddPhone(phone);
            if (phoneobj != null && result != null)
            {
                Session.Add("success", "Thêm mới thành công");
                Response.Redirect("~/Admin/Phone/Phone.aspx");
            }
            else
            {
                error = "Thêm mới không thành công";
            }
        }

        protected void ddlListCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idCompany = ddlListCompany.SelectedValue;
        }

        public String getIdPhone(String phoneName,String companyId)
        {
            DateTime date = new DateTime();
            return phoneName + date.Day + date.Month + date.Year + companyId;
        }
        public String getPhoneIdDetail(String idPhone,String category)
        {
            return idPhone + category;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, XmlSerializeString = false)]
        public static List<p_phone_category> GetPhoneCate(String companyId)
        {
            PhoneCategoryController controllerCate = new PhoneCategoryController();
            return controllerCate.getAllByCompanyId(companyId);//chay di
        }
    }//code d
}