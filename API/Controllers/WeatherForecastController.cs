using API.Class;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    { // path GET: api/Movie
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            int cont = Data.Instance.lista.Count;
            if (cont < 11)
            {
                return Data.Instance.lista;
            }
            else
            {
                return Data.Instance.lista.Skip(cont - 10).ToList();
            }

        }


        [HttpPost]
        public void Post([FromBody]Movies newMovies)
        {
            Data.Instance.lista.Add(newMovies);
        }

    }
}
