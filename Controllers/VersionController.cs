using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz335.Controllers
{
    [Route("quizapi")]
    [ApiController]
    public class VersionController : Controller
    {
        [HttpGet("GetVersion")]
        public ActionResult<string> GetVersion()
        {
            return Ok("v1");
        }
    }
}
