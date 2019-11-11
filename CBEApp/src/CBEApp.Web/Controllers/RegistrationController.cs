using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using CashBash_Sample.Models;
using CBEApp.Authorization;
using CBEApp.Roles;
using CBEApp.Web.Helpers;
using CBEApp.Web.Models.Admin;
using CBEApp.Web.Models.Registration;
using CBEApp.Web.Models.Roles;

namespace CBEApp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class RegistrationController : CBEAppControllerBase
    {
        public ActionResult Search(string btnSubmit, string ddlAttndType, string ddlTitle, string txtFName, string txtLName, string txtArrDate, string txtDepDat, bool chkVip = false, bool chkCancel = false)
        {
            // if (btnSubmit == null)
            //  {
            LoadDetails();
            List<Attendee_Type> objLstAtndType = new List<Attendee_Type>();

            Attendee_Type objAttType = new Attendee_Type();
            objAttType.Attend_CD = 1;
            objAttType.Attend_Type_Desc = "Winner";
            objLstAtndType.Add(objAttType);

            objAttType = new Attendee_Type();
            objAttType.Attend_CD = 2;
            objAttType.Attend_Type_Desc = "Guest";
            objLstAtndType.Add(objAttType);

            objAttType = new Attendee_Type();
            objAttType.Attend_CD = 3;
            objAttType.Attend_Type_Desc = "Staff";
            objLstAtndType.Add(objAttType);

            ViewBag.AttendType = new SelectList(objLstAtndType, "Attend_CD", "Attend_Type_Desc");

            List<ViewModelSearchRegistration> lstnew = new List<ViewModelSearchRegistration>();
            ViewModelSearchRegistration objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "EDDIE ACCARDI DODGE CHRYS JEEP";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);


            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-5933";
            objVw.Attendee_Id = 9969;
            objVw.Attendee_Name = "Accardi, Joseph";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "EDDIE ACCARDI DODGE CHRYS JEEP";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);


            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "EDDIE ACCARDI MOTORS";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);


            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "ACCARDI MILROT";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);


            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "ACCARDI DODGE";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);


            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "EDDIE ACCARDI CHEVROLET";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);

            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "EDDIE ACCARDI CHRY-PLYM-SUBARU";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);

            objVw = new ViewModelSearchRegistration();
            objVw.Attnd_Type = "Winner";
            objVw.SSN = "xxx-xx-6237";
            objVw.Attendee_Id = 10530;
            objVw.Attendee_Name = "Akhlaghi, Reza";
            objVw.Guest = "Edit";
            objVw.Dealer_Name = "PREBUL JEEP INC";
            objVw.Stage_Name = "";
            objVw.Group_Name = "";
            objVw.Abs = "Yes";
            objVw.Pulls = 0;
            objVw.Split_Percentage = 17;
            lstnew.Add(objVw);
            //}
            FillMenu();
            return View(lstnew);
        }
        [HttpGet]
        public ActionResult GoToWinner(string Winner_id, int AttendId, string Oprn, string DealName)
        {
            FillMenu();
            TempData["WinnerId"] = Winner_id;
            return RedirectToAction("AddWinner", "Winner");
        }
        [HttpGet]
        public ActionResult GoToGuest(string Winner_id, int AttendId, string Oprn, string DealName)
        {
            FillMenu();
            TempData["WinnerId"] = Winner_id;
            //return View("~/Views/Guest/AddGuest.cshtml");
            return RedirectToAction("AddGuest", "Guest");
        }

        [HttpGet]
        public ActionResult GoToPullKept(string Winner_id, int AttendId, string Oprn, string DealName)
        {
            FillMenu();
            TempData["WinnerId"] = Winner_id;
            return RedirectToAction("DealerPullsKept", "DealerPullsKept");
        }

        [NonAction]
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

            objTitle.Atne_Title_CD = 1;
            objTitle.Atne_Title_Desc = "Owner";
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

            ViewBag.Title = new SelectList(objLstTitle, "Atne_Title_CD", "Atne_Title_Desc");

        }
        public ActionResult Insert()
        {
            FillMenu();
            return View();
        }

        public ActionResult DealerPullsKept()
        {
            FillMenu();
            return View();
        }

        [HttpPost]
        [Abp.Web.Security.AntiForgery.DisableAbpAntiForgeryTokenValidation]
        public ActionResult SaveDealerPullKept()
        {
            if (ModelState.IsValid)
            {

            }
            FillMenu();
            return View("DealerPullsKept");
        }

        public void FillMenu()
        {
            ViewBag.controller = "Registration";
            ViewBag.v = SubMenu.RegistrationSubSectionMenu();
        }

    }
}