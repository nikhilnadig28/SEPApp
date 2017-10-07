using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SEPApp.Models
{
    public class Financial
    {
        [Key]
        public int RequestId { get; set; }
        public int EventId { get; set; }
        public int ExpectedBudgetIncrease { get; set; }
        public string Justification { get; set; }

    }
}