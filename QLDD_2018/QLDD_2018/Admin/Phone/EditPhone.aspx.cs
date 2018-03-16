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
    public partial class EditPhone : System.Web.UI.Page
    {
        PhoneController controller = new PhoneController();
        PhoneDetailController controllerDetail = new PhoneDetailController();
        CompanyController controllerC = new CompanyController();
        public String edit_fail = "";
        public p_phone phone = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = Request.Params["id"];
            phone = controller.FindPhoneById(id);
            if(phone == null)
            {
                Session.Add("success","Id không tồn tại");
                Response.Redirect("/Admin/Phone/Phone.aspx");
            }
            p_phone_detail detail = controllerDetail.FindOneById(phone.phone_detail_id);
            ddlListCompany.DataSource = controllerC.GetAll();
            ddlListCompany.DataTextField = "name";
            ddlListCompany.DataValueField = "company_id";
            ddlListCompany.DataBind();

            ddlListCompany.Items.FindByValue(phone.company_id).Selected = true;
            txtPhoneId.Value = phone.phone_id;
            txtPhoneDetailId.Value = phone.phone_category_id;
            txtCode.Text = phone.code_no;
            txtCost.Text = phone.cost;
            txtPhoneName.Text = phone.phone_name;

            txtRam.Text = detail.ram;
            txtPin.Text = detail.pin;
            txtScreenSize.Text = detail.screen_size;
            txtMemory.Text = detail.memory;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            p_phone phone = new p_phone();
            phone.phone_id = txtPhoneId.ToString();
            phone.phone_name = txtPhoneName.Text;
            phone.company_id = ddlListCompany.SelectedValue;
            phone.cost = txtCost.Text;
            phone.code_no = txtCode.Text;
            phone.phone_category_id = ddlListCategoryPhone.SelectedValue;
            phone.phone_detail_id = txtPhoneDetailId.ToString();
            p_phone result = controller.AddPhone(phone);
            if(result != null)
            {
                p_phone_detail detail = new p_phone_detail();
                detail.phone_detail_id = txtPhoneDetailId.ToString();
                detail.pin = txtPin.Text;
                detail.memory = txtMemory.Text;
                detail.ram = txtRam.Text;
                detail.screen_size = txtScreenSize.Text;
                p_phone_detail result1 = controllerDetail.EditPhoneDetail(detail);
                if(result1 != null)
                {
                    //Session.Add("edit_phone_success", "Sửa thành công");
                    Session.Add("success", "Sửa thành công");
                    Response.Redirect("~/Admin/Phone/Phone.aspx");
                }else{
                    edit_fail = "Sửa không thành công !";
                }
            }
            else
            {
                edit_fail = "Sửa không thành công !";
            }
        }

        protected void ddlListCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            String companyId = ddlListCompany.SelectedValue;            
        }
    }
}