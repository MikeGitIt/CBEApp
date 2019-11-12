using System;
using System.Collections.Generic;

namespace CBEApp.Web.Models.Registration
{
    public partial class Cash_Bash_Staff
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string NT_USR_ID { get; set; }
        public string DPMT_CD { get; set; }
        public string HST_IN { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
    
        public virtual Cash_Bash_Attendee CASH_BASH_ATTENDEE { get; set; }
        //public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
