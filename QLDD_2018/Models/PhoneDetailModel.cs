using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhoneDetailModel
    {
        phone_db_2018Entities context = new phone_db_2018Entities();

        public p_phone_detail AddPhoneDetail(p_phone_detail detail)
        {
            p_phone_detail phone = context.p_phone_detail.Add(detail);
            context.SaveChanges();
            return phone;
        }

        public p_phone_detail FindPhoneDetailById(String id)
        {
            p_phone_detail detail = context.p_phone_detail.FirstOrDefault(e => e.phone_detail_id == id);
            return detail;
        }

        public p_phone_detail EditPhoneDetail(p_phone_detail detail)
        {
            p_phone_detail phone = FindPhoneDetailById(detail.phone_detail_id);
            if(phone != null) { 
            phone.phone_detail_id = detail.phone_detail_id;
            phone.memory = detail.memory;
            phone.pin = detail.pin;
            phone.ram = detail.ram;
            phone.screen_size = detail.screen_size;
            context.SaveChanges();
            }
            return phone;
        }
    }
}
