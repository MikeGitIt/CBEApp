using System;
using System.Collections.Generic;

namespace CBEApp.Web.Models.Registration
{
    public partial class Cash_Bash_Guest
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public System.DateTime LST_UPDT_DT { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public Nullable<int> INVR_ID { get; set; }
        public string INVR_FWS_DLR_NB { get; set; }
    
        public virtual Cash_Bash_Attendee CASH_BASH_ATTENDEE { get; set; }
        public virtual Cash_Bash_Attendee CASH_BASH_ATTENDEE1 { get; set; }
        public virtual Cash_Bash_Dealer CASH_BASH_DEALER { get; set; }
    }
}
