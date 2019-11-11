using CBEApp.Web.Models;
using CBEApp.Web.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBEApp.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AddUser()
        {
            FillMenu();
            var userview = PopulateSecurityRole();
            return View(userview);
        }

        [HttpPost]
        [Abp.Web.Security.AntiForgery.DisableAbpAntiForgeryTokenValidation]
        public ActionResult SaveUser(UserViewModel UserViewModelData)
        {
            if(ModelState.IsValid)
            {
                
            }
            FillMenu();
            var userview = PopulateSecurityRole();
            return View("AddUser",userview); 
        }


        public ActionResult AddEditTitles()
        {
            FillMenu();
            CashBashWinnerTitleViewModel titleView = PopulateData();
            return View(titleView);
        }

        [HttpPost]
        [Abp.Web.Security.AntiForgery.DisableAbpAntiForgeryTokenValidation]
        public ActionResult WinnerTitleAction(string Actionname, CashBashWinnerTitleViewModel viewData)
        {

            if (Actionname == "Add")
            {
                string discription = viewData.NewTitleDescription;
            }
            else if (Actionname=="Update")
            {
                string discription = viewData.UpdatedTitleDescription;
                int titlecode = viewData.UpdatedTitleCode;
            }

            return View();
        }

        public void FillMenu()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "SearchUser";
            men.Name = "Search User";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "AddUser";
            men.Name = "Add User";
            lst.Add(men);


            //men = new MenuList();
            //men.ActionName = "EditEvent";
            //men.Name = "Edit Event";
            //lst.Add(men);

            men = new MenuList();
            men.ActionName = "AddEditTitles";
            men.Name = "Add/Edit Titles";
                       

            men = new MenuList();
            men.ActionName = "EditPullInfo";
            men.Name = "Search User";
            lst.Add(men);

            men = new MenuList();
            men.ActionName = "EditCash";
            men.Name = "Edit cash";
            lst.Add(men);
            ViewBag.controller = "Admin";
            ViewBag.v = lst;
        }

        private CashBashWinnerTitleViewModel PopulateData()
        {
            CashBashWinnerTitleViewModel viewObj = new CashBashWinnerTitleViewModel();

            string[] title = new string[] { "Admin Title", "Owner", "General Sales Manager", "F&I Manager" };
            int i = 0;
            foreach (string str in title)
            {
                WinnerTitleViewModel obj = new WinnerTitleViewModel();
                obj.TitleDescription = str;
                obj.TitleCode = ++i;
                viewObj.TitlesViewModel.Add(obj);
            }
            return viewObj;
        }
        
        private UserViewModel PopulateSecurityRole()
        {
            UserViewModel viewObject = new UserViewModel();
            //dataobj.UserSecurity = new List<UserSecurityViewModel>();
            string[] roles = new string[] {"Admin", "Registrar", "Cashier", "CheckIn", "Emcee", "Tabulator" };            
            foreach (string str in roles)
            {
                UserSecurityViewModel obj = new UserSecurityViewModel();
                obj.RoleName = str;
                viewObject.UserSecurity.Add(obj);
            }          

            return viewObject;
        }
    }
}