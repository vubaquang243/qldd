using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class PhoneController
    {
        private PhoneModel model = new PhoneModel();

        public List<p_phone> getAllPhone()
        {
            List<p_phone> list = model.getAll();
            return list;
        }

        public p_phone FindPhoneById(String id)
        {
            p_phone phone = model.GetByPhoneId(id);
            return phone;
        }

        public p_phone AddPhone(p_phone obj)
        {
            p_phone phone = model.AddPhone(obj);
            return phone;
        }

        public p_phone EditPhone(p_phone obj)
        {
            p_phone phone = model.EditPhoneById(obj);
            return phone;
        }

        public p_phone DeletePhone(String id)
        {
            p_phone obj = model.ReMovePhone(id);
            return obj;
        }

        public List<p_phone> GetAllByParams(PhoneForm form)
        {
            return model.findListPhoneByParams(form);
        }
    }
}
