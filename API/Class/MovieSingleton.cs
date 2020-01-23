using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Class
{
    public class MovieSingleton : IMovieSingleton
    {

        public List<Movies> Lista = new List<Movies>();
    }

    public interface IMovieSingleton
    {

    }


}
