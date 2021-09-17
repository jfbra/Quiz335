using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quiz335.Models;

namespace Quiz335.Data
{
    public interface IMarksAPIRepo
    {
        Task<IEnumerable<Marks>> GetAllMarksAsync();
        Task<Marks> GetMarkByIDAsync(int id);
    }
}
