using API.Class;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly static MovieSingleton _movie = new MovieSingleton();
        // path GET: api/Movie
        [HttpGet]
        // _movie.Lista.Count
        public IEnumerable<Movies> Get()
        {
            int cntMovies1 = _movie.Lista.Count;
            if (cntMovies1 < 10) return _movie.Lista;
            else return _movie.Lista.Skip(cntMovies1 - 10).ToList();
        }


        // POST: api/Movie
        [HttpPost]
        public void Post(Movies newMovies)
        {
            _movie.Lista.Add(newMovies);//Movies.Add(newMovies);
        }


    }
}
