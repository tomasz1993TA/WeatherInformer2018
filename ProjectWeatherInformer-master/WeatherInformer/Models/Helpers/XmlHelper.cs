using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherInformer
{
    public class XmlHelper
    {        
        public CurrentWeather GetCurrentWeatherFromXml(XmlDocument xml)
        {
            var result = new CurrentWeather();

            result.cityName = getParam(xml, "//city", "name");
            var temperatureKelvin = double.Parse(getParam(xml, "//temperature", "value"), System.Globalization.CultureInfo.InvariantCulture);
            var unitHelper = new UnitHelper();
            result.temperature = unitHelper.getTemperatureCelsius(temperatureKelvin);
            result.pressure = double.Parse(getParam(xml, "//pressure", "value"), System.Globalization.CultureInfo.InvariantCulture);
            result.humidity = Convert.ToInt32(getParam(xml, "//humidity", "value"));
            result.windSpeed = double.Parse(getParam(xml, "//speed", "value"), System.Globalization.CultureInfo.InvariantCulture);
            result.clouds = Convert.ToInt32(getParam(xml, "//clouds", "value"));
            result.sunrise = DateTime.Parse(getParam(xml, "//sun", "rise"));
            result.sunset = DateTime.Parse(getParam(xml, "//sun", "set"));
            result.iconId = getParam(xml, "//weather", "icon");

            return result;
        }        

        private string getParam(XmlDocument xml, string node, string attribute)
        {
            var nodeName = xml.SelectSingleNode(node);
            var attrName = nodeName.Attributes[attribute];
            return attrName.Value;
        }
    }
}
