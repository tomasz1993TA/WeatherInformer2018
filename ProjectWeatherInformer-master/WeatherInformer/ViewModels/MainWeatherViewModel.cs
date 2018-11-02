using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherInformer.ViewModels
{
    public class MainWeatherViewModel
    {
        public string City { get; set; }    
        public string Temperature { get; set; }
        public string Pressure { get; set; }
        public string Wind { get; set; }
        public string Clouds { get; set; }
        public string Humidity { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}
