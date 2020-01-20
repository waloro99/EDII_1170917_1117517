using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Class
{
    public class MovieSingleton : IMovieSingleton
    {
        
        public List<Movies> Lista { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IMovieSingleton
    {

        List<Movies> Lista { get; set; }
    }
}
