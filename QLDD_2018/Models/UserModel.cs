using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserModel
    {
        phone_db_2018Entities context = new phone_db_2018Entities();
        public List<p_user> getAll()
        {
            List<p_user> lstUser = context.p_user.ToList();
            return lstUser;
        }

        public p_user AddUser(p_user user)
        {
            p_user userModel = null;
            try
            {
                context.p_user.Add(user);
                context.SaveChanges();
                userModel = user;
                return userModel;
            }
            catch (Exception e) { }
            return userModel;
        }

        public p_user FindUserById(String id)
        {
            p_user user = null;
            try
            {
                user = context.p_user.Find(id);
            }
            catch (Exception e)
            { }
            return user;
        }

        public p_user EditUserById(p_user user)
        {
            p_user userM = null;
            try
            {
                userM = FindUserById(user.user_id);
                if (userM != null)
                {
                    userM.user_id = user.user_id;
                    userM.username = user.username;
                    userM.password = user.password;
                    userM.email = user.email;
                    userM.company_id = user.company_id;
                    userM.authority = user.authority;
                    context.SaveChanges();
                    return userM;
                }
            }
            catch (Exception e)
            {
            }
            return userM;
        }

        public p_user RemoveUserById(String id)
        {
            p_user user = null;
            try
            {
                user = FindUserById(id);
                if (user != null)
                {
                    context.p_user.Remove(user);
                    context.SaveChanges();
                    return user;
                }
            }
            catch (Exception e) { }
            return user;
        }

        public p_user CheckLogin(String email, String password)
        {
            p_user user = null;
            try
            {
                user = context.p_user.FirstOrDefault(e => e.email == email && e.password == password);
                return user;
            }
            catch (Exception e) { }
            return user;
        }

        public List<p_user> FindUserByParams(dynamic form)
        {
            return null;
        }
    }
}
