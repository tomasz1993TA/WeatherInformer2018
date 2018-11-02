using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

            result.sunrise = DateTime.Parse(getParam(xml, "//sun", "rise"));

            // wszystkie pola z currWeather

            return result;
        }

        private string getParam(XmlDocument xml, string node, string attr)
        {
            var nodeName = xml.SelectSingleNode(node);
            var attrName = nodeName.Attributes[attr];
            return attrName.Value;
        }
    }

}
