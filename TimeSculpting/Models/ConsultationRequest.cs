using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSculpting.Models
{
    public class ConsultationRequest
    {
        public int ConsultationRequestId { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address:")]
        [MaxLength(200, ErrorMessage ="Stop that")]
        public string EmailAddress { get; set; }

        public DateTime DateOfRequest { get; set; }

        [MaxLength(750)]
        [Display(Name = "Brief description of business need:")]
        public string Description { get; set; }
        
        public string IPAddress { get; set; }

        [Phone]
        [Display(Name = "Phone:")]
        public string Phone { get; set; }

        [Display(Name = "Address Line 1:")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2:")]
        public string Address2 { get; set; }
    }
}