using QuizMaster.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaster.Api
{
    public  class MovieData : IMovieData
    {
        private readonly List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Name = "The Maltese Falcon",
                Description = "American film noir written and directed by John Huston.",
                Year = 1941
            },
            new Movie
            {
                Id = 20,
                Name = "The Postman Always Rings Twice",
                Description = "1946 American film noir based on the 1934 novel of the same name by James M. Cain.",
                Year = 1946
            },
            new Movie
            {
                Id = 30,
                Name = "A Kiss Before Dying",
                Description = "1956 American color film noir,[1] directed by Gerd Oswald in his directorial debut.",
                Year = 1956
            },
              new Movie
            {
                Id = 30,
                Name = "Tomorrow Is Another Day",
                Description = "1951 American film noir,[1] directed by Felix E. Feist.",
                Year = 1951
            }
        };

        public Task<IEnumerable<Movie>> GetMovies()
        {
            return Task.FromResult(movies.AsEnumerable());
        }
    }
}
