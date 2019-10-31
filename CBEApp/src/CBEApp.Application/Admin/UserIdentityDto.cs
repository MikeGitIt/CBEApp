using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBEApp.Admin
{
    public class UserIdentityDto
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordText { get; set; }
        

        public int EventId { get; set; }
        public string Access_Level_Code { get; set; }
        public string RoleCode { get; set; }

        public System.DateTime LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public Nullable<System.DateTime> INCE_DT { get; set; }
    }
}
