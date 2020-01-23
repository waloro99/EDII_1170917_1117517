using API.Class;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    { // path GET: api/Movie
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            return Data.Instance.lista;
        }

        [HttpPost]
        public void Post([FromBody]Movies newMovies)
        {
            Data.Instance.lista.Add(newMovies);
        }

    }
}
