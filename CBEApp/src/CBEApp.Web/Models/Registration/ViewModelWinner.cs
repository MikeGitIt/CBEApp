using CBEApp.Web.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Registration
{
    public class ViewModelWinner
    {
        public string Winner_SSN { get; set; }
        private Cash_Bash_Attendee _ObjCbAttend;
        public Cash_Bash_Attendee ObjCbAttend
        {
            get
            {
                if (_ObjCbAttend == null)
                    _ObjCbAttend = new Cash_Bash_Attendee();

                return _ObjCbAttend;
            }
            set
            {
                _ObjCbAttend = value;
            }
        }
        private Cash_Bash_Guest _objCbGuest;
        public Cash_Bash_Guest objCbGuest
        {
            get
            {
                if (_objCbGuest == null)
                    _objCbGuest = new Cash_Bash_Guest();

                return _objCbGuest;
            }
            set
            {
                _objCbGuest = value;
            }
        }
        private Attendee_Address _objAttendAdd;
        public Attendee_Address objAttendAdd
        {
            get
            {
                if (_objAttendAdd == null)
                    _objAttendAdd = new Attendee_Address();

                return _objAttendAdd;
            }
            set
            {
                _objAttendAdd = value;
            }
        }
        private Travel _objTravel;
        public Travel objTravel
        {
            get
            {
                if (_objTravel == null)
                    _objTravel = new Travel();

                return _objTravel;
            }
            set
            {
                _objTravel = value;
            }
        }
        private TravelPrefernces _objTravelPref;
        public TravelPrefernces objTravelPref
        {
            get
            {
                if (_objTravelPref == null)
                    _objTravelPref = new TravelPrefernces();

                return _objTravelPref;
            }
            set
            {
                _objTravelPref = value;
            }
        }
        public Attendee_Note _objAttendeeNote;
        public Attendee_Note objAttendeeNote
        {
            get
            {
                if (_objAttendeeNote == null)
                    _objAttendeeNote = new Attendee_Note();

                return _objAttendeeNote;
            }
            set
            {
                _objAttendeeNote = value;
            }
        }
    }
}