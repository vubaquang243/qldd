using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class CustomerController
    {
        private CustomerModel model = new CustomerModel();
        public List<p_customer> getAll()
        {
            return model.getAllCustomer();
        }

        public p_customer RemoveCustomerById(String id)
        {
            return model.RemoveCustomerById(id);
        }
    }
}
