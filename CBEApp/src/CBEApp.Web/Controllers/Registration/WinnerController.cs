using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using CashBash_Sample.Models;
using CBEApp.Authorization;
using CBEApp.Roles;
using CBEApp.Web.Models;
using CBEApp.Web.Models.Admin;
using CBEApp.Web.Models.Registration;
using CBEApp.Web.Models.Roles;

namespace CBEApp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class WinnerController : CBEAppControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public WinnerController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        //[HttpGet]
        //public ActionResult Index()
        //{
        //    var model = new ViewModelWinner();

        //    return View(model);
        //}
        public ActionResult AddWinner(ViewModelWinner objVmWinner, string btnSaveDel)
        {
            LoadDetails();
           
            List<State> objLst = new List<State>();
            State objState = new State();
            objState.St_Cd = "1";
            objState.St_Nm = "Florida";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Florida";
            objLst.Add(objState);

            objLst.Add(objState);

            ViewBag.State = new SelectList(objLst, "St_Cd", "St_Nm");

            if (ModelState.IsValid)
            {
                if (btnSaveDel == "Save")
                {
                    SaveData();
                    ViewBag.Message = "Winner Saved Successfully";
                    return View("WinnerSaveDelete");
                }
                else if (btnSaveDel == "Delete")
                {
                    DeleteData();
                    ViewBag.Message = "Winner Deleted Successfully";
                    return View("WinnerSaveDelete");
                }
            }

            return View(objVmWinner);
        }

        private void DeleteData()
        {
           // throw new NotImplementedException();
        }
        private void SaveData()
        {
            //throw new NotImplementedException();
        }
        

        public void LoadDetails()
        {
            CASH_BASH_EVENT cbEvent = new CASH_BASH_EVENT();
            cbEvent.EVNT_NM = "Cash Bash 2019 - Viva Las Vegas Bash";
            ViewBag.EventNm = cbEvent.EVNT_NM;

            Cash_Bash_Title objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 1;
            objTitle.Atne_Title_Desc = "Test";
            objTitle.Evnt_Id = 2;
            List<Cash_Bash_Title> objLstTitle = new List<Cash_Bash_Title>();
            objLstTitle.Add(objTitle);
            ViewBag.ddlTitle = new SelectList(objLstTitle, "Atne_Title_CD", "Atne_Title_Desc");

            var HomeDealershiplist = new SelectList(new[]
                {
                new { ID = "1", Name = "mosses Ford BMW(57626)" },
                 new { ID = "2", Name = "Joseph Ford BMW(3321)" },
                    new { ID = "3", Name = "Test Test BMW(17626)"  },
                        },
                "ID", "Name", 1);

            ViewData["HomeDealershiplist"] = HomeDealershiplist;




            var Status = new SelectList(new[]
               {
                new { ID = "1", Name = "registered" },
                 new { ID = "2", Name = "Not registered" },
                    new { ID = "3", Name = "Test Test Data"  },
                        },
               "ID", "Name", 1);

            ViewData["Status"] = Status;

        }


    }
}