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
        public string EventName { get; set; }
        public string EventType { get; set; }
        public int ClientId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Preferences { get; set; }
        public int Budget { get; set; }
    }
}