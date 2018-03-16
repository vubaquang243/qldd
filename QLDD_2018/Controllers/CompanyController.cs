using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class CompanyController
    {
        CompanyModel model = new CompanyModel();

        public List<p_company> GetAll()
        {
            List<p_company> lst = model.getAll();
            return lst;
        }
    }
}
