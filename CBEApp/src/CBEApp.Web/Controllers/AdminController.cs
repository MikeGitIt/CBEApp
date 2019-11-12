using CBEApp.Web.Helpers;
using CBEApp.Web.Models;
using CBEApp.Web.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CBEApp.Web.Controllers
{
    public class AdminController : Controller
    {

        #region "--milind--"
        public ActionResult SearchUser()
        {
            var model = new SearchUserListViewModel();
            FillMenu();
            return View(model);
        }

        [HttpGet]
        public ActionResult InitCash()
        {
            FillMenu();
            var model = new InitCashModel();
            return View(model);
        }
        public ActionResult Index()
        {
            FillMenu();
            return View(new InitCashModel());
        }
        //        [HttpPost(actio]
        [HttpPost]
        public ActionResult InitCash(InitCashModel initCashModel)
        {
            FillMenu();
            //return View(new InitCashModel());
            return View(initCashModel);
        }
        public string GetUserForEvent(string id)
        {
            // get the products from the repository 

            var UserId = new List<SelectListItem>();

            if (id == "1028")
            {
                UserId.Add(new SelectListItem() { Text = "cashbash", Value = "cashbash" });
                UserId.Add(new SelectListItem() { Text = "Cashier1", Value = "Cashier1" });
            }
            else if (id == "1105")
            {
                UserId.Add(new SelectListItem() { Text = "batcher", Value = "batcher" });
                UserId.Add(new SelectListItem() { Text = "donna", Value = "donna" });
            }

            return new JavaScriptSerializer().Serialize(UserId);
        }
      
        #endregion

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

            FillMenu();
            CashBashWinnerTitleViewModel titleView = PopulateData();
            return View("AddEditTitles",titleView);
        }

        public void FillMenu()
        {            
            ViewBag.controller = "Admin";
            ViewBag.v = SubMenu.AdminSubSectionMenu();
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