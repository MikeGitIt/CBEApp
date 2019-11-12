using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Admin
{
    public class UserSecurityViewModel
    {
        public bool IsSelected { get; set; }
        public string UserId { get; set; }
        public int EventId { get; set; }
        public string AccessLevelCode { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public Nullable<System.DateTime> LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
    
        //public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
       // public virtual USER_IDENTIFIER USER_IDENTIFIER { get; set; }
    }
}
