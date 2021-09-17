using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Quiz335.Controllers
{
    [Route("quizapi")]
    [ApiController]
    public class CourseController : Controller
    {
        [HttpGet("GetCourseInfo/{code}")]
        public ActionResult GetCourseInfo(string code)
        {
            string path = Directory.GetCurrentDirectory();
            string courseDir = Path.Combine(path, "Courses");
            string fileName = Path.Combine(courseDir, code + ".html");
            string respHeader = "";
            if (System.IO.File.Exists(fileName))
            {
                respHeader = "text/html; charset=UTF-8";
                return PhysicalFile(fileName, respHeader);
            }
            else
            {
                string responseString = "There is no course " + code;
                return NotFound(responseString);
            }
        }
    }
}
