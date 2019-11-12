using System;
using System.Collections.Generic;
namespace CBEApp.Web.Models
{   
    public class Attendee_Address
    {
        public int Atne_Id { get; set; }
        public string Addr_Ln_1_Tx { get; set; }
        public string Addr_Ln_2_Tx { get; set; }
        public string Atne_City_Nm { get; set; }
        public string Atne_St_Cd { get; set; }
        public string Atne_Zip_Cd { get; set; }
        public System.DateTime Lst_Updt_Ts { get; set; }
        public string Lst_Updt_Usr_Id { get; set; }
    
        //public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        //public virtual STATE STATE { get; set; }
    }
}
