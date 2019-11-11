using System;
using System.Collections.Generic;

namespace CBEApp.Web.Models.Admin
{
    public class CashBashWinnerTitleViewModel
    {
     public CashBashWinnerTitleViewModel()
        {
            this.TitlesViewModel = new List<WinnerTitleViewModel>();
        }
        public int EventId { get; set; }
        public int NewTitleCode { get; set; }
        public string NewTitleDescription { get; set; }

        public int UpdatedTitleCode { get; set; }
        public string UpdatedTitleDescription { get; set; }

        public IList<WinnerTitleViewModel> TitlesViewModel { get; set; }
        //public CashBashEventViewModel CASH_BASH_EVENT { get; set; }
    }

    public class WinnerTitleViewModel
    {
        public int TitleCode { get; set; }
        public string TitleDescription { get; set; }
        
    }

}
