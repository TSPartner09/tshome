using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeSculpting.Models;

namespace TimeSculpting.ViewModels
{
    public class HomeIndexVM
    {
        public HomeIndexVM()
        {
            ConsultationRequest = new ConsultationRequest();
        }

        public ConsultationRequest ConsultationRequest { get; set; }
    }
}