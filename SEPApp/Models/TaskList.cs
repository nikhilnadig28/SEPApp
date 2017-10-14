using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SEPApp.Models
{
    public class TaskList
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        //[ForeignKey("AspNetUsers")]
        [Column("Id")]
        public int EmployeeId { get; set; }
        public string TaskDetails { get; set; }
        public string TaskFeedback { get; set; }
        //public virtual AspNetUsers AspNetUsers { get; set; }
    }
}