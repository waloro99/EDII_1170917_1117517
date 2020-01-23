using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Class
{   //CREATE A INSTANCE TO THE LIST
    public class Data
    {
       private static Data instance = null;
       public static Data Instance
        {
            get
            {
                if (instance == null) instance = new Data();
                return instance;
            }
        }
        public List<Movies> lista = new List<Movies>();
    }
}
