using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class MenuModel
    {
        phone_db_2018Entities context = new phone_db_2018Entities();

        public List<p_menu> getAll()
        {
            List<p_menu> lstMenu = null;
            try
            {
                lstMenu = context.p_menu.OrderBy(e => e.menu_name).ToList();
            }
            catch (Exception e) { }
            return lstMenu;
        }

        public p_menu FindMenuById(String id)
        {
            p_menu menu = null;
            try
            {
                menu = context.p_menu.Find(id);
            }
            catch (Exception e) { }
            return menu;
        }

        public p_menu AddMenu(p_menu obj)
        {
            p_menu menu = null;
            try
            {
                menu = context.p_menu.Add(obj);
                context.SaveChanges();
            }
            catch (Exception e) { }
            return menu;
        }

        public p_menu DeleteMenuById(String id)
        {
            p_menu menu = null;
            try
            {
                menu = FindMenuById(id);
                if (menu != null)
                {
                    context.p_menu.Remove(menu);
                    context.SaveChanges();
                }
            }
            catch (Exception e) { }
            return menu;
        }
    }
}
