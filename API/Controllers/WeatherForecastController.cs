using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Class;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private readonly MovieSingleton _movie;
       // private readonly static MovieSingleton _movie = new MovieSingleton();

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            
            return Data.Instance.lista;
            //----------------------------
            /// _movie.Lista.Count
            //int cntMovies = _movie.Lista.Count;
            //if (cntMovies < 10) return _movie.Lista;
            //else return _movie.Lista.Skip(cntMovies - 10).ToList();
            //int cntMovies = Movies.Count();
            //if (cntMovies < 10) return Movies;
            //else return Movies.Skip(cntMovies - 10).ToList();
        }


        //urlhttp://localhost:5319/api/weatherforecast
        // POST: api/Movie
        [HttpPost]
        public void Post( [FromBody]Movies newMovies)
        {

            //_movie.Lista.Add(newMovies);
            //Movies.Add(newMovies);
            Data.Instance.lista.Add(newMovies);
        }

    }
}
