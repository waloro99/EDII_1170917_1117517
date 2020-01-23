using System;

namespace API
{       //CREEATE A CLASE TO USE ONLY GETS TO THE SECURITY
    public class WeatherForecast
    {//USE TO REFERENCE
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }
    }
}
