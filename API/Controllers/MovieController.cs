using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Class;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly MovieSingleton _movie;

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
           /// _movie.Lista.Count
            int cntMovies = _movie.Lista.Count;
            if (cntMovies < 10) return _movie.Lista;
            else return _movie.Lista.Skip(cntMovies - 10).ToList();
            //int cntMovies = Movies.Count();
            //if (cntMovies < 10) return Movies;
            //else return Movies.Skip(cntMovies - 10).ToList();
        }


        // POST: api/Movie
        [HttpPost]
        public void Post(Movies newMovies)
        {
            _movie.Lista.Add(newMovies);
            //Movies.Add(newMovies);
        }

 
    }
}
