using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class PhoneCategoryController
    {
        private CategoryPhone model = new CategoryPhone();

        public List<p_phone_category> getAll()
        {
            return model.getAll();
        }

        public List<p_phone_category> getAllByCompanyId(String id)
        {
            return model.getAllByCompanyId(id);
        }
    }
}
