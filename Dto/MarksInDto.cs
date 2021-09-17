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
        public float A1 { get; set; }
        public float A2 { get; set; }
    }
}
