using System;
using System.Collections.Generic;

namespace CBEApp.Web.Models.Registration
{
    public partial class Dealer_Pull
    {
        public string Fws_Id_Nb { get; set; }
        public int Evnt_Id { get; set; }
        public Nullable<short> Plls_Won_Qy { get; set; }
        public Nullable<short> Plls_Kpt_Qy { get; set; }
        public Nullable<short> Trps_Won_Qy { get; set; }
        public string Trps_Purs_Qy { get; set; }
        public Nullable<short> Totl_Pnts_Qy { get; set; }
        public Nullable<int> Pull_Ordr_Nb { get; set; }
        public Nullable<System.DateTime> Lst_Updt_Dt { get; set; }
        public Nullable<short> Pull_Progress_Id { get; set; }
        public System.DateTime Lst_Updt_Ts { get; set; }
        public string Pull_Dist_Type { get; set; }
        public string Lst_Updt_Usr_Id { get; set; }
        public string Display_Nm { get; set; }
        public string Group_Nm { get; set; }
        public Nullable<int> Dinner_Only_Qy { get; set; }
        public string Notes { get; set; }
    }
}
