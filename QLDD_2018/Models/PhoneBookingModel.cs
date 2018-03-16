using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class PhoneBookingModel
    {
        phone_db_2018Entities context = new phone_db_2018Entities();

        public List<phone_booking> getAll()
        {
            List<phone_booking> lst = null;
            lst = context.phone_booking.ToList();
            return lst;
        }

        public phone_booking FindById(int id)
        {
            phone_booking book = null;
            try
            {
                book = context.phone_booking.FirstOrDefault(e => e.id == id);
            }
            catch (Exception e) { }
            return book;
        }
        public phone_booking AddNewBooking(phone_booking phone)
        {
            phone_booking book = null;
            book = context.phone_booking.Add(phone);
            context.SaveChanges();
            return book;
        }
        public phone_booking EditPhoneBooking(int id, String status)
        {
            phone_booking phone = null;
            try
            {
                phone = FindById(id);
                if (phone != null)
                {
                    phone.status = status;
                    context.SaveChanges();
                }
            }
            catch (Exception e) { }
            return phone;
        }
    }
}
