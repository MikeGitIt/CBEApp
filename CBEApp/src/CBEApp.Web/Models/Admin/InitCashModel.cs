using CashBash_Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CBEApp.Web.Models.Admin
{
    public partial class InitCashModel
    {
        public string CSHR_TYP_CD { get; set; }
        public int EVNT_ID { get; set; }
        public string CHK_IN_USR_ID { get; set; }
        public int INTL_CASH_AM { get; set; }
        public int INTL_CASH { get; set; }
        public virtual USER_IDENTIFIER USER_IDENTIFIER { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }



        private List<SelectListItem> _Event = new List<SelectListItem>();
        private List<SelectListItem> _UserId = new List<SelectListItem>();

        [Required(ErrorMessage = "Please select a event")]
        public string SelectedEvent { get; set; }

        [Required(ErrorMessage = "Please select a user")]
        public string SelectedUserId { get; set; }

        public List<SelectListItem> UserId
        {
            get { return _UserId; }
        }

        public List<SelectListItem> Event
        {
            get
            {
                _Event.Add(new SelectListItem() { Text = "Cash Bash 2005 - Viva Las Vegas Bash", Value = "1028" });
                _Event.Add(new SelectListItem() { Text = "Cash Bash 2001 - Bash by the Bay", Value = "1105" });
                _Event.Add(new SelectListItem() { Text = "Cash Bash 2010 - Wonderland Bash", Value = "1005" });
                //_Event.Add(new SelectListItem() { Text = "JavaScript", Value = "4" });
                //_Event.Add(new SelectListItem() { Text = "Ruby", Value = "1" });
                //_Event.Add(new SelectListItem() { Text = "JavaScript", Value = "2" });
                return _Event;
            }
        }
    }
}
    
