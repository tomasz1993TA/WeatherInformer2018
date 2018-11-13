using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherInformer
{
    public class UnitHelper
    {
        public double getTemperatureCelsius(double tempKelvin)
        {
            var result = tempKelvin - 273.15;
            return result;
        }
    }
}
