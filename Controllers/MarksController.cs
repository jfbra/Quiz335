using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz335.Dto;
using Quiz335.Data;
using Quiz335.Models;

namespace Quiz335.Controllers
{
    [Route("quizapi")]
    [ApiController]
    public class MarksController : Controller
    {
        private readonly IMarksAPIRepo _repository;

        public MarksController(IMarksAPIRepo repository)
        {
            _repository = repository;
        }

        [HttpGet("GetMarks")]
        public async Task<ActionResult<IEnumerable<MarksOutDto>>> GetMarksAsync()
        {
            IEnumerable<Marks> marks = await _repository.GetAllMarksAsync();
            IEnumerable<MarksOutDto> m = marks.Select(e => new MarksOutDto { Id = e.Id, A1 = e.A1, A2 = e.A2 });
            return Ok(m);
        }

        [HttpGet("GetMarkByID/{id}")]
        [ActionName(nameof(GetMarkByIDAsync))]
        public async Task<ActionResult<MarksOutDto>> GetMarkByIDAsync(int id)
        {
            Marks mark = await _repository.GetMarkByIDAsync(id);
            if (mark == null)
            {
                string response = "No record for the student with the ID number " + id;
                return NotFound(response);
            }
            MarksOutDto m = new MarksOutDto { Id = mark.Id, A1 = mark.A1, A2 = mark.A2 };
            return Ok(m);
        }

        [HttpPost("SetMark")]
        public async Task<ActionResult<MarksOutDto>> SetMarksAsync(MarksInDto marks)
        {
            Marks m = new Marks
            {
                Id = marks.Id,
                A1 = marks.A1,
                A2 = marks.A2
            };
            await _repository.SetMarksAsync(m);
            return CreatedAtAction(actionName: nameof(GetMarkByIDAsync), new { id = marks.Id.ToString() }, m);
        }
    }
}
