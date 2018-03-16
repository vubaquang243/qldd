using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class PhoneDetailController
    {
        PhoneDetailModel model = new PhoneDetailModel();

        public p_phone_detail AddNewPhone(p_phone_detail detail)
        {
            p_phone_detail phone = model.AddPhoneDetail(detail);
            return phone;
        }

        public p_phone_detail EditPhoneDetail(p_phone_detail detail)
        {
            p_phone_detail phone = model.EditPhoneDetail(detail);
            return phone;
        }

        public p_phone_detail FindOneById(String id)
        {
            p_phone_detail detail = model.FindPhoneDetailById(id);
            return detail;
        }
    }
}
