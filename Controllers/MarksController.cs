using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz335.Controllers
{
    [Route("quizapi")]
    [ApiController]
    public class MarksController : Controller
    {
        [HttpGet("GetMarks")]
        public async Task<ActionResult<IEnumerable<MarksOutDto>>> GetMarksAsync()
        {
            return View();
        }
    }
}
