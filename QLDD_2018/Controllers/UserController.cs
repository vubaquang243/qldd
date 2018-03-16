using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controllers
{
    public class UserController
    {
        private UserModel model = new UserModel();
        public p_user checkLogin(String email, String password)
        {
            p_user user = model.CheckLogin(email, password);
            return user;
        } 
    }
}
