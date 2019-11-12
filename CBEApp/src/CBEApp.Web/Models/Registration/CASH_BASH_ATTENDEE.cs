using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CBEApp.Web.Models.Registration
{
    public partial class Cash_Bash_Attendee
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public CASH_BASH_ATTENDEE()
        //{
        //    this.ATTENDEE_NOTE = new HashSet<ATTENDEE_NOTE>();
        //    this.CASH_BASH_GUEST = new HashSet<CASH_BASH_GUEST>();
        //    this.CASH_BASH_STAFF = new HashSet<CASH_BASH_STAFF>();
        //    this.CASH_BASH_EVENT_WINNER = new HashSet<CASH_BASH_EVENT_WINNER>();
        //    this.CASH_BASH_GUEST1 = new HashSet<CASH_BASH_GUEST>();
        //    this.TRAVELs = new HashSet<TRAVEL>();
        //    this.TRAVEL_PREFERENCES = new HashSet<TRAVEL_PREFERENCES>();
        //}

        public int Atne_Id { get; set; }
        public string Atne_Ttp_Cd { get; set; }
        public string Frst_Nm { get; set; }
        public string Lst_Nm { get; set; }
        public Nullable<int> Titl_Cd { get; set; }
        public string Hm_Phn_Nb { get; set; }

        //[Display(Name = "Email address")]
        //[Required(ErrorMessage = "The email address is required")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailValidate { get; set; }

        public string Emrg_Cntc_Nm { get; set; }
        public string Emrg_Phn_Nb { get; set; }
        public string Atne_Ssn_Nb { get; set; }
        public Nullable<System.DateTime> Ince_Dt { get; set; }
        public string Chk_In { get; set; }

       
        public bool Txbl_In_bool
        {
            get
            {
                if (Txbl_In == "1")
                    return true;
                else
                    return false;
            }
            set
            {
                Txbl_In = value==true?"1":"0";
            }

        }
        public string Txbl_In { get; set; }
        public int Evnt_Id { get; set; }
        public string Atne_Xref_Id { get; set; }
        public System.DateTime Lst_Updt_Ts { get; set; }
        public string Lst_Updt_Ust_Id { get; set; }
        public string Mid_Init { get; set; }
        public string Lawson_Vendor_Id { get; set; }
        public string Display_Dlr_Id { get; set; }
        public string Email { get; set; }
        public Nullable<int> Status { get; set; }
        public string Dinner_Only_In { get; set; }
        public string Absentee { get; set; }
        public Nullable<int> Treip_Nb { get; set; }
        public string Switchtrip { get; set; }

    }
}
