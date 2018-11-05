using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WeatherInformer
{
    
    public class OpenWeatherMapService
    {
        string iconId { get; set; }
        public List<CityData> GetCityDataList()
        {
            var cityList = new List<CityData>();

            using (StreamReader streamReader = new StreamReader(System.Configuration.ConfigurationSettings.AppSettings["cityListJsonPath"].ToString()))
            {
                string json = streamReader.ReadToEnd();
                cityList = JsonConvert.DeserializeObject<List<CityData>>(json);
            }
            return cityList;
        }

        public CurrentWeather GetCurrentWeather(string cityName)
        {
            string url = string.Format(System.Configuration.ConfigurationSettings.AppSettings["urlXml"], cityName);

            var xml = getCurrentWeatherXml(url);
            var currentWeather = getCurrentWeatherFromXml(xml);
            
            return currentWeather;
        }

        public Image GetWeatherIcon()
        {              
            string urlAdressIcon = string.Format(System.Configuration.ConfigurationSettings.AppSettings["urlIcon"], iconId);

            var weatherIcon = GetResponseIcon(urlAdressIcon);

            return weatherIcon;
        }

        private Image GetResponseIcon(string url)
        {
            var requestIcon = (HttpWebRequest)WebRequest.Create(url);
            var responseIcon = (HttpWebResponse)requestIcon.GetResponse();
            var responseImage = Bitmap.FromStream(responseIcon.GetResponseStream());

            return responseImage;
        }

        private XmlDocument getCurrentWeatherXml(string url)
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(GetResponseApi(url));
            return xmlDocument;
        }

        private string GetResponseApi(string urlAddress)
        {
            var request = (HttpWebRequest)WebRequest.Create(urlAddress);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }

        private CurrentWeather getCurrentWeatherFromXml(XmlDocument xml)
        {
            var result = new CurrentWeather();

            result.cityName = getParam(xml, "//city", "name");
            var temperatureKelvin = double.Parse(getParam(xml, "//temperature", "value"), System.Globalization.CultureInfo.InvariantCulture);
            result.temperature = getTemperatureCelsius(temperatureKelvin);
            result.pressure = double.Parse(getParam(xml, "//pressure", "value"), System.Globalization.CultureInfo.InvariantCulture);
            result.humidity = Convert.ToInt32(getParam(xml, "//humidity", "value"));
            result.windSpeed = double.Parse(getParam(xml, "//speed", "value"), System.Globalization.CultureInfo.InvariantCulture);
            result.clouds = Convert.ToInt32(getParam(xml, "//clouds", "value"));
            result.sunrise = DateTime.Parse(getParam(xml, "//sun", "rise"));
            result.sunset = DateTime.Parse(getParam(xml, "//sun", "set"));
            iconId = getParam(xml, "//weather", "icon");

            return result;
        }

        private string getParam(XmlDocument xml, string node, string attribute)
        {
            var nodeName = xml.SelectSingleNode(node);
            var attrName = nodeName.Attributes[attribute];
            return attrName.Value;
        }  

        private double getTemperatureCelsius(double tempKelvin)
        {
            var result = tempKelvin - 273.15;
            return result;
        }
    }
}
