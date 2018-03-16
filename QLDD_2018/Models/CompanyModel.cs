using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CompanyModel
    {
        phone_db_2018Entities context = new phone_db_2018Entities();

        public List<p_company> getAll()
        {
            List<p_company> lstCompany = null;
            try
            {
                lstCompany = context.p_company.ToList();
            }
            catch (Exception e) { }
            return lstCompany;
        }

        public p_company FindCompanyById(String id)
        {
            p_company com = null;
            com = context.p_company.Find(id);
            return com;
        }

        public p_company AddCompany(p_company obj)
        {
            p_company comp = context.p_company.Add(obj);
            context.SaveChanges();
            return comp;
        }

        public p_company EditCompany(p_company com)
        {
            p_company obj = null;
            try
            {
                obj = FindCompanyById(com.company_id);
                if (obj != null)
                {
                    obj.company_id = com.company_id;
                    obj.address = com.address;
                    obj.code_no = com.code_no;
                    obj.country = com.country;
                    obj.email = com.email;
                    obj.name = com.name;
                    obj.phone = com.phone;
                    context.SaveChanges();
                }
            }
            catch (Exception e) { }
            return obj;
        }

        public p_company RemoveCompanyById(String id)
        {
            p_company com = FindCompanyById(id);
            if (com != null)
            {
                context.p_company.Remove(com);
                context.SaveChanges();
            }
            return com;
        }
    }
}
