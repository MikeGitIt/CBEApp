using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Admin
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            this.CashBashCash = new HashSet<CashBashCashViewModel>();            
            this.UserSecurity = new List<UserSecurityViewModel>();
        }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Passwordtext { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        //public Nullable<System.DateTime> INCE_DT { get; set; }
        public bool IsActive { get; set; }

        public ICollection<CBEApp.Web.Models.Admin.CashBashCashViewModel> CashBashCash { get; set; }
        
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  IList<UserSecurityViewModel> UserSecurity { get; set; }
    }
}