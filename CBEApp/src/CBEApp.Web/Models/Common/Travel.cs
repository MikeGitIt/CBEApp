using System;
using System.Collections.Generic;

namespace CBEApp.Web.Models
{
    public partial class Travel
    {


        public int Atne_Id { get; set; }
        public int Evnt_Id { get; set; }
        public string Atne_Typ_Cd { get; set; }
        public string Prfd_Arpt_Nm { get; set; }
        public Nullable<short> Lnd_Cost_Am { get; set; }
        public Nullable<short> Air_Cst_Am { get; set; }
        public Nullable<System.DateTime> Arvl_Dt { get; set; }
        public Nullable<System.DateTime> Depr_Dt { get; set; }
        public Nullable<short> Csh_Alwc_Am { get; set; }

        public bool Vip_In_bool
        {
            get
            {
                if (Vip_In == "1")
                    return true;
                else
                    return false;
            }
            set
            {
                Vip_In = value == true ? "1" : "0";
            }

        }
        public string Vip_In { get; set; }
        public Nullable<short> Misc_Csh_Am { get; set; }
        public Nullable<short> Gme_Wngs_Am { get; set; }
        public string Chk_In_Usr_Id { get; set; }
        public string Mdcl_Rsts_In { get; set; }
        public string Lst_Updt_Usr_Id { get; set; }
        public Nullable<System.DateTime> Lst_Updt_Dt { get; set; }
        public string Land_Buy_In_Typ_Cd { get; set; }
        public string Air_Buy_In_Type_Cd { get; set; }
        public string Cash_Alwc_Type_Cd { get; set; }
        public string Misc_Buy_In_Cd { get; set; }
        public Nullable<short> Othr_Cost_Am { get; set; }
        public string Othr_Cost_Type_Cd { get; set; }

        //public virtual BUY_IN_TYPE BUY_IN_TYPE { get; set; }
        //public virtual BUY_IN_TYPE BUY_IN_TYPE1 { get; set; }
        //public virtual BUY_IN_TYPE BUY_IN_TYPE2 { get; set; }
        //public virtual BUY_IN_TYPE BUY_IN_TYPE3 { get; set; }
        //public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        //public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
        //public virtual USER_IDENTIFIER USER_IDENTIFIER { get; set; }
    }
}
