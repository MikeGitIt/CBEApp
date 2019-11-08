using Abp.Web.Mvc.Authorization;
using CBEApp.Authorization;
using CBEApp.Web.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using static CBEApp.Web.Models.Admin.SearchUserListViewModel;

namespace CBEApp.Web.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
        

        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult AddEditTitles()
        {            
            return View();
        }
        public ActionResult SearchUser()
        {
            var model = new SearchUserListViewModel();
            FillMenu();          
            return View(model);
        }

        [HttpGet]
        public ActionResult InitCash()
        {
            var model = new InitCashModel();
           
            return View(model);
        }
        public ActionResult Index()
        {

            return View(new InitCashModel());
        }

//        [HttpPost(actio]
        [HttpPost]
        public ActionResult InitCash(InitCashModel initCashModel)
        {

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
        public void FillMenu()
        {
            List<MenuList> lst = new List<MenuList>();
            MenuList men = new MenuList();
            men.ActionName = "SearchUser";
            men.Name = "Search User";
            lst.Add(men);
        }

       
    }
}