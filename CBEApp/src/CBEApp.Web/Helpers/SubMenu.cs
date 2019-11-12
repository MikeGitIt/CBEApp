using CBEApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Helpers
{
    public static class SubMenu
    {

        public static List<MenuList> AdminSubSectionMenu()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "Admin/SearchUser";
            men.Name = "Search User";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "Admin/AddUser";
            men.Name = "Add User";
            lst.Add(men);


            //men = new MenuList();
            //men.ActionName = "EditEvent";
            //men.Name = "Edit Event";
            //lst.Add(men);

            men = new MenuList();
            men.ActionName = "Admin/AddEditTitles";
            men.Name = "Add/Edit Titles";
            lst.Add(men);

            //men = new MenuList();
            //men.ActionName = "EditPullInfo";
            //men.Name = "Search User";
            //lst.Add(men);

            men = new MenuList();
            men.ActionName = "Admin/InitCash";
            men.Name = "Edit cash";
            lst.Add(men);

            return lst;

        }

        public static List<MenuList> RegistrationSubSectionMenu()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            //men.ActionName = "Registration";
            //men.Name = "Registration";
            //lst.Add(men);

            men = new MenuList();
            men.ActionName = "Registration/Search";
            men.Name = "Search";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "Winner/AddWinner";
            men.Name = "Add Winner";

            lst.Add(men);
            men = new MenuList();
            men.ActionName = "Registration/DealerPullsKept";
            men.Name = "Dealer Pull Kept";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "DealerPullOrder/GetPullOrder";
            men.Name = "Dealer Pull Order";
            lst.Add(men);
            return lst;

        }
    }
}