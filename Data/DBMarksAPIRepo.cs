using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Quiz335.Models;

namespace Quiz335.Data
{
    public class DBMarksAPIRepo : IMarksAPIRepo
    {
        private readonly WebAPIQuiz335DBContext _dbContext;

        public DBMarksAPIRepo(WebAPIQuiz335DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Marks>> GetAllMarksAsync()
        {
            IEnumerable<Marks> marks = _dbContext.Marks.ToList<Marks>();
            return marks;
        }

        public async Task<Marks> GetMarkByIDAsync(int id)
        {
            Marks mark = _dbContext.Marks.FirstOrDefault(e => e.Id == id);
            return mark;
        }
    }
}
