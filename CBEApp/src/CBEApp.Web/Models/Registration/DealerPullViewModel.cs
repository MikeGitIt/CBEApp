﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBEApp.Web.Models.Registration
{
    public class DealerPullViewModel
    {
        public string DealerNumber { get; set; }
        public string FWS_ID_NB { get; set; }
        public int EVNT_ID { get; set; }
        public Nullable<short> PLLS_WON_QY { get; set; }
        public Nullable<short> PLLS_KPT_QY { get; set; }
        public Nullable<short> TRPS_WON_QY { get; set; }
        public string TRPS_PURS_QY { get; set; }
        public Nullable<short> TOTL_PNTS_QY { get; set; }
        public Nullable<int> PULL_ORDR_NB { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
        public Nullable<short> PULL_PROGRESS_ID { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string PULL_DIST_TYPE { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string DISPLAY_NM { get; set; }
        public string GROUP_NM { get; set; }
        public Nullable<int> DINNER_ONLY_QY { get; set; }
        public string NOTES { get; set; }
    }
}