using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Admin
{ 
    public class CashBashCashViewModel
    {
        public CashBashCashViewModel()
        {
            //this.USER_IDENTIFIER= new HashSet<UserIdentifierViewModel>();
            //this.CASH_BASH_EVENT = new HashSet<CashBashEventViewModel>();
        }
        public string CSHR_TYP_CD { get; set; }
        public int EVNT_ID { get; set; }
        public string CHK_IN_USR_ID { get; set; }
        public Nullable<int> INTL_CSH_AM { get; set; }
    
        public UserViewModel USER_IDENTIFIER { get; set; }
        public CashBashEventViewModel CASH_BASH_EVENT { get; set; }
    }
}
