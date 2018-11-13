using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherInformer
{
    public class CurrentWeather
    {        
        public string cityName { get; set; }

        public double temperature { get; set; }

        public double pressure { get; set; }

        public int humidity { get; set; }

        public double windSpeed { get; set; }

        public int clouds { get; set; }        

        public DateTime sunrise { get; set; }

        public DateTime sunset { get; set; }

        public string iconId { get; set; }
    }
}
