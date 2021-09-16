using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quiz335.Models
{
    public class Course
    {
        [Key]
        public string Code { get; set; }
        public string Start1 { get; set; }
        public string End1 { get; set; }
        public string Weekday1 { get; set; }
        public string Location1 { get; set; }
        public string Start2 { get; set; }
        public string End2 { get; set; }
        public string Weekday2 { get; set; }
        public string Location2 { get; set; }

    }
}
