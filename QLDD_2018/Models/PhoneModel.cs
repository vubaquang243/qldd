using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhoneModel
    {
        private phone_db_2018Entities context = new phone_db_2018Entities();
        public p_phone GetByPhoneId(string phoneId)
        {
            p_phone phone = null;
            try
            {
                phone = context.p_phone.FirstOrDefault(e => e.phone_id == phoneId);
                return phone;
            }
            catch (System.Exception ex)
            {
                phone = null;
            }

            return phone;
        }

        public List<p_phone> getAll()
        {
            List<p_phone> lstPhone = new List<p_phone>();
            lstPhone = context.p_phone.ToList();
            return lstPhone;
        }

        public p_phone AddPhone(p_phone phone)
        {
            p_phone obj = null;
            try
            {
                obj = context.p_phone.Add(phone);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {

            }
            return obj;
        }

        public p_phone EditPhoneById(p_phone phone)
        {
            p_phone obj = null;
            try
            {
                obj = context.p_phone.Find(phone.phone_id);
                if (obj != null)
                {
                    obj.phone_id = phone.phone_id;
                    obj.phone_name = phone.phone_name;
                    obj.company_id = phone.company_id;
                    obj.cost = phone.cost;
                    obj.date_issue = phone.date_issue;
                    obj.phone_category_id = phone.phone_category_id;
                    obj.code_no = phone.code_no;
                    context.SaveChanges();
                    return obj;
                }
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public p_phone ReMovePhone(String id)
        {

            p_phone phone = context.p_phone.Find(id);
            if (phone != null)
            {
                context.p_phone.Remove(phone);
                p_phone_detail detail = context.p_phone_detail.Find(phone.phone_detail_id);
                context.p_phone_detail.Remove(detail);
                context.SaveChanges();
                return phone;
            }
            return phone;
        }

        public List<p_phone> findListPhoneByParams(PhoneForm form)
        {
            List<p_phone> lstPhone = null;
            try
            {
                if (form.phoneId != "")
                {
                    lstPhone = context.p_phone.Where(e => e.phone_id == form.phoneId).ToList();
                }
                if (form.companyId != "" && form.companyId != null)
                {
                    lstPhone = context.p_phone.Where(e => e.company_id == form.companyId).ToList();
                }
                if (!form.dateIssueFrom.Equals("") && form.dateIssueFrom != null)
                {
                    lstPhone = context.p_phone.Where(e => e.date_issue > form.dateIssueFrom).ToList();
                }
                if (!form.dateIssueTo.Equals("") && form.dateIssueTo != null)
                {
                    lstPhone = context.p_phone.Where(e => e.date_issue < form.dateIssueTo).ToList();
                }
                if(form.cost != null && form.cost != "")
                {
                    lstPhone = context.p_phone.Where(e => e.cost == form.cost).ToList();
                }
            }
            catch (Exception e)
            {

            }
            return lstPhone;
        }
    }
}
