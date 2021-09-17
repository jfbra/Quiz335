using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quiz335.Dto
{
    public class MarksInDto
    {
        [Required]
        public int Id { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
    }
}
