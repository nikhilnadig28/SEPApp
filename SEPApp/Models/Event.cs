using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEPApp.Models
{
    public class Event
    {

        [Key]
        public int EventId { get; set; }
        [Display(Name = "Name")]
        public string EventName { get; set; }
        [Display(Name = "Type")]
        public string EventType { get; set; }
        [Display(Name = "Client")]
        public int ClientId { get; set; }
        [Display(Name = "From")]
        public DateTime FromDate { get; set; }
        [Display(Name = "To")]
        public DateTime ToDate { get; set; }
        public string Preferences { get; set; }
        public int Budget { get; set; }
        [Display(Name = "CS Approval")]
        public bool SeniorCustomerApprove { get; set; }
        [Display(Name = "Manager Approval")]
        public bool AdministrativeManagerApprove { get; set; }
        [Display(Name = "Feedback")]
        public string FinancialManagerComments { get; set; }
        public Event()
        {
            SeniorCustomerApprove = false;
            AdministrativeManagerApprove = false;
        }
    }
}