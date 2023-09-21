using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicTimeTableGenerate.Models
{
    public class WorkingDays
    {
        [Required]
        [Range(1, 7, ErrorMessage = "Accepts only positive number between 1 to 7")]
        public int NoOfWorkingDays { get; set; }
        [Required]
        [Range(0, 8, ErrorMessage = "Accepts only positive number less than 9")]

        public int NoOfSubjectsPerDay { get; set; }
        [Required]
        public int TotalSubjects { get; set; }
    }
}