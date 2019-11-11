using System;
using System.Collections.Generic;

namespace CBEApp.Web.Models
{ 
    public  class Attendee_Note
    {
        public int Atne_Id { get; set; }
        public int Evnt_Id { get; set; }
        public System.DateTime Lst_Updt_Ts { get; set; }
        public string LST_Updt_Usr_Id { get; set; }
        public string Nt_Cmnt_Tx { get; set; }
        public string Dvtn_In { get; set; }
        public int Note_Type_Id { get; set; }
    
        //public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        //public virtual NOTE_TYPE NOTE_TYPE { get; set; }
        //public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
