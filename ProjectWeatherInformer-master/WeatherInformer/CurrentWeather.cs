using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherInformer
{
    public class CurrentWeather
    {
        // I think that your class structure is without sense. You used a lot of class that are necessary
        // Like class Main, Wind, Clouds, Sys. You should have one class for all of that unless it have more sense
        // Properties names should be started from a capital letter !!!
        // you should use another classes - to stored data from json and mapped it to your main weather model
        public string name { get; set; }

        public Main main { get; set; }        

        public Wind wind { get; set; }
                
        public Clouds clouds { get; set; }

        public Sys sys { get; set; }

        public DateTime sunrise { get; set; }

        public DateTime sunset { get; set; }
    }
}
