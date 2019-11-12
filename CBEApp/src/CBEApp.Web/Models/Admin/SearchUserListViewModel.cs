using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Admin
{
    public class SearchUserListViewModel
    {
        
        [Display(Name = "Id")]
        public int EventID { get; set; }


        [Required(ErrorMessage = "AttendeeType name is required.")]
        public string AttendeeType { get; set; }

        public int TitleCode { get; set; }

        [Required(ErrorMessage = "SSN is required.")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName is required.")]
        public string LastName { get; set; }


        public string ArrivalDate { get; set; }
        public string DealerName { get; set; }

        public string DealerNum { get; set; }
        public string AttendeeID { get; set; }
        public string AbsenteeFlag { get; set; }
        public string MasterFlag { get; set; }
        public string VipFlag { get; set; }
        public string InActiveFlag { get; set; }
        public Boolean CheckInFlag { get; set; }



        //public virtual ICollection<SearchUserListViewModel> SearchUserListViewModels
        //{
        //    get; set;

        //    // public IReadOnlyList<PermissionDto> Permissions { get; set; }
        //}
        public class MenuList
        {
            public string Name { get; set; }
            public string ActionName { get; set; }
            public string ControllerName { get; set; }

        }
    }
}