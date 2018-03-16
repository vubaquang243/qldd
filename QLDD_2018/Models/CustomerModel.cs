using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerModel
    {
        phone_db_2018Entities context = new phone_db_2018Entities();

        public List<p_customer> getAllCustomer()
        {
            List<p_customer> lstCus = null;
            try
            {
                lstCus = context.p_customer.ToList();
            }
            catch (Exception e) { }
            return lstCus;
        }

        public p_customer AddNewCustomer(p_customer customer)
        {
            p_customer cus = null;
            try
            {
                cus = context.p_customer.Add(customer);
                return cus;
            }
            catch (Exception e) { }
            return cus;
        }

        public p_customer FindCustomerById(String id)
        {
            p_customer cus = null;
            try
            {
                cus = context.p_customer.FirstOrDefault(e => e.customer_id == id);
            }
            catch (Exception e) { }
            return cus;
        }

        public p_customer EditCustomerById(p_customer obj)
        {
            p_customer cus = null;
            try
            {
                cus = FindCustomerById(obj.customer_id);
                if (cus != null)
                {
                    cus.customer_id = obj.customer_id;
                    cus.address = obj.address;
                    cus.company = obj.company;
                    cus.date_of_birth = obj.date_of_birth;
                    cus.email = obj.email;
                    cus.identity_no = obj.identity_no;
                    cus.name = obj.name;
                    cus.password = obj.password;
                    context.SaveChanges();
                    return cus;
                }
            }
            catch (Exception e) { }
            return cus;
        }

        public p_customer RemoveCustomerById(String id)
        {
            p_customer cus = null;
            try
            {
                cus = FindCustomerById(id);
                context.p_customer.Remove(cus);
                context.SaveChanges();
            }
            catch (Exception e) { }
            return cus;
        }

        public List<p_customer> FindCustomerByParams(dynamic form)
        {
            List<p_customer> lstCus = null;
            return lstCus;
        }
    }
}
