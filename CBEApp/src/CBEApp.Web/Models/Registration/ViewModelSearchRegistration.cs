
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Registration
{
    public class ViewModelSearchRegistration
    {
        //[Required]
        //public string Name { get; set; }

        //Attnd_Type SSN Attendee_Id Attendee_Name first_name, last_name
        //public Cash_Bash_Attendee ObjCbAttend { get; set; }
        //public Cash_Bash_Guest ObjCbGuest { get; set; }
        //public Cash_Bash_Dealer ObjCbDealer { get; set; }
        //public Cash_Bash_Staff ObjCbStaff { get; set; }
        //public Cash_Bash_Dealer_Winner ObjCbDealerWinner { get; set; }
        //public Dealer_Pull ObjDealerPull { get; set; }
        //public Travel ObjTravel { get; set; }

        //Attnd_Type SSN Attendee_Id Attendee_Name Guest Dealer Name Stage Name Group Name Abs Pulls Split % 


        public string Attnd_Type { get; set; }
        public string SSN { get; set; }
        public int Attendee_Id { get; set; }
        public string Attendee_Name { get; set; }
        public string Guest { get; set; }
        public string Dealer_Name { get; set; }
        public string Stage_Name { get; set; }
        public string Group_Name { get; set; }
        public string Abs { get; set; }
        public int Pulls { get; set; }
        public int Split_Percentage { get; set; }

    }
}