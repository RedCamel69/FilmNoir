using QuizMaster.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Api
{
    public  interface IMovieData
    {
        Task<IEnumerable<Movie>> GetMovies();
    }
}
