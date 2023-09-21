using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicTimeTableGenerate.Models
{
    public class SubjectAndHours
    {
        [Required]
        public string SubjectName { get; set; }
        [Required]
        public int SubjectTotalHours { get; set; }
        public int TotalHours { get; set; }
    }
}