using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryPhone
    {
        private phone_db_2018Entities context = new phone_db_2018Entities();

        public List<p_phone_category> getAll()
        {
            List<p_phone_category> lst = context.p_phone_category.ToList();
            return lst;
        }

        public List<p_phone_category> getAllByCompanyId(String id)
        {
            List<p_phone_category> lst = context.p_phone_category.Where(e => e.company_id == id).ToList();

            return lst;
        }
    }
}
