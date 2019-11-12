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
    public class GuestController : CBEAppControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public GuestController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }


        public ActionResult AddGuest(ViewModelGuest objVmGuest, string btnSaveDel)
        {
            LoadDetails();
            // ViewModelGuest objVmGuest = new ViewModelGuest();
            if (TempData["WinnerId"] != null)
                objVmGuest.Winner_SSN = TempData["WinnerId"].ToString();
            List<State> objLst = new List<State>();
            State objState = new State();
            objState.St_Cd = "1";
            objState.St_Nm = "Alabama";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Alaska";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Arizona";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Arkansas";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "California";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Colorado";
            objLst.Add(objState);

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Connecticut";
            objLst.Add(objState);


            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "District of Columbia";
            objLst.Add(objState); 

            objState = new State();
            objState.St_Cd = "2";
            objState.St_Nm = "Delaware";
            objLst.Add(objState);

            objVmGuest.ObjCbAttend.Titl_Cd = 0;
            ViewBag.State = new SelectList(objLst, "St_Cd", "St_Nm");

            if (ModelState.IsValid)
            {
                if (btnSaveDel == "Save")
                {
                    SaveData();
                    ViewBag.Message = "Guest Saved Successfully";
                    return View("GuestSaveDelete");
                }
                else if (btnSaveDel == "Delete")
                {
                    DeleteData();
                    ViewBag.Message = "Guest Deleted Successfully";
                    return View("GuestSaveDelete");
                }
            }

            return View(objVmGuest);
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

            List<Cash_Bash_Title> objLstTitle = new List<Cash_Bash_Title>();
            Cash_Bash_Title objTitle = new Cash_Bash_Title();


            objTitle.Atne_Title_CD = 0;
            objTitle.Atne_Title_Desc = "Please select";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "F & I Manager";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "CEO";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "CFO";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "COO";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "General Manager";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "F & I Director";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Non - Affiliated";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);


            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Business Manager";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "General Sales Manager";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);


            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Sales Manager";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Service Director";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Sales Director";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "President";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Vice Pres";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            objTitle = new Cash_Bash_Title();
            objTitle.Atne_Title_CD = 2;
            objTitle.Atne_Title_Desc = "Service Manager";
            objTitle.Evnt_Id = 2;
            objLstTitle.Add(objTitle);

            ViewBag.ddlTitle = new SelectList(objLstTitle, "Atne_Title_CD", "Atne_Title_Desc", 0);

        }


    }
}