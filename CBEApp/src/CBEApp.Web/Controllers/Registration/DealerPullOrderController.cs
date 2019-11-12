using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using CashBash_Sample.Models;
using CBEApp.Authorization;
using CBEApp.Roles;
using CBEApp.Web.Helpers;
using CBEApp.Web.Models;
using CBEApp.Web.Models.Admin;
using CBEApp.Web.Models.Registration;
using CBEApp.Web.Models.Roles;

namespace CBEApp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class DealerPullOrderController : CBEAppControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public DealerPullOrderController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }


        public ActionResult GetPullOrder(Dealer_Pull obDealerPull, string btnSaveDel)
        {
            LoadDetails();
            // ViewModelGuest obDealerPull = new ViewModelGuest();
            //if (TempData["WinnerId"] != null)
            //    obDealerPull.Winner_SSN = TempData["WinnerId"].ToString();
            //List<State> objLst = new List<State>();
            //State objState = new State();
            //objState.St_Cd = "1";
            //objState.St_Nm = "Alabama";
            //objLst.Add(objState);

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "Alaska";
            //objLst.Add(objState);

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "Arizona";
            //objLst.Add(objState);

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "Arkansas";
            //objLst.Add(objState);

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "California";
            //objLst.Add(objState);

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "Colorado";
            //objLst.Add(objState);

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "Connecticut";
            //objLst.Add(objState);


            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "District of Columbia";
            //objLst.Add(objState); 

            //objState = new State();
            //objState.St_Cd = "2";
            //objState.St_Nm = "Delaware";
            //objLst.Add(objState);

            //obDealerPull.ObjCbAttend.Titl_Cd = 0;
            //ViewBag.State = new SelectList(objLst, "St_Cd", "St_Nm");

            //if (ModelState.IsValid)
            //{
            //    if (btnSaveDel == "Save")
            //    {
            //        SaveData();
            //        ViewBag.Message = "Guest Saved Successfully";
            //        return View("GuestSaveDelete");
            //    }
            //    else if (btnSaveDel == "Delete")
            //    {
            //        DeleteData();
            //        ViewBag.Message = "Guest Deleted Successfully";
            //        return View("GuestSaveDelete");
            //    }
            //} 
            return View("~/Views/Registration/GetPullOrder.cshtml", obDealerPull); ;
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
            FillMenu();
            CASH_BASH_EVENT cbEvent = new CASH_BASH_EVENT();
            cbEvent.EVNT_NM = "Cash Bash 2019 - Viva Las Vegas Bash";
            ViewBag.EventNm = cbEvent.EVNT_NM;

            List<Cash_Bash_Dealer> objLstTitle = new List<Cash_Bash_Dealer>();

            Cash_Bash_Dealer objDealer = new Cash_Bash_Dealer();


            //objDealer.FWS_DLR_NB = "0";
            //objDealer.DLR_NM = "Please select";
            //objDealer.objDealerPull.Group_Nm = "";
            //objLstTitle.Add(objDealer);

            objDealer = new Cash_Bash_Dealer();
            objDealer.FWS_DLR_NB = "37822";
            objDealer.DLR_NM = "A&T Cheverolet";
            objDealer.objDealerPull.Group_Nm = ""; 
            objLstTitle.Add(objDealer);

            objDealer = new Cash_Bash_Dealer();
            objDealer.FWS_DLR_NB = "91491";
            objDealer.DLR_NM = "ACCARDI DODGE";
            objDealer.objDealerPull.Group_Nm = "";
            objLstTitle.Add(objDealer);

            ViewBag.PullOrder = objLstTitle;

            //ViewBag.PullOrder = new SelectList(objLstTitle, "FWS_DLR_NB", "DlrNM_GroupNm", 0);

        }

        private void FillMenu()
        {
            ViewBag.controller = "DealerPullOrder";
            ViewBag.v = SubMenu.RegistrationSubSectionMenu();
        }
    }
}