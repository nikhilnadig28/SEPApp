using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEPApp.Models
{
    public class Recruitment
    {
        [Key]
        public int RequestId { get; set; }
        public string RequestName { get; set; }
        public int DepartmentId { get; set; }
        public string SkillSet { get; set; }
    }
}