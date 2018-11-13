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

            var xmlHelper = new XmlHelper();
            var currentWeather = xmlHelper.GetCurrentWeatherFromXml(xml);            
            
            return currentWeather;
        }

        public Image GetWeatherIcon(string iconId)
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
    }
}
