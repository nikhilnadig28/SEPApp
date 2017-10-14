using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEPApp.Models
{
    public enum Approve { Negotiating, Approved, Rejetced };

    public class Financial
    {
        [Key]
        public int RequestId { get; set; }
        public int EventId { get; set; }
        public int ExpectedBudgetIncrease { get; set; }
        public string Justification { get; set; }
        public Approve Approval { get; set; }

    }
}