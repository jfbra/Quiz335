using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quiz335.Models
{
    public class Enrolement
    {
        [Key]
        public string EnrolementNum { get; set; }
        public int StudentID { get; set; }
        public string Course { get; set; }
    }
}
