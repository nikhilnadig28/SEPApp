using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEPApp.Models
{
    public enum HireStatus { NotStarted, Ongoing, Completed };

    public class HiringTracker
    {
        [Key]
        public int HireId { get; set; }
        public string SkillSet { get; set; }
        public HireStatus Status { get; set; }

      
    }
}