using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WeatherInformer.ViewModels;

namespace WeatherInformer
{
    public partial class MainWeatherView : Form
    {
        public MainWeatherViewModel mainWeatherViewModel { get; set; }
        private OpenWeatherMapService openWeatherMapService { get; set; }

        public MainWeatherView()
        {
            InitializeComponent();
            mainWeatherViewModel = new MainWeatherViewModel();
            openWeatherMapService = new OpenWeatherMapService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCitiesCombobox();
        }

        private void InitializeCitiesCombobox()
        {
            var cityDataList = openWeatherMapService.GetCityDataList();
            var cityNameList = GetCityListForPoland(cityDataList);
            comboBoxCity.DataSource = cityNameList;
        }
        
        private List<string> GetCityListForPoland(List <CityData> cityDataList)
        {
            var result = cityDataList.Where(x => x.country == "PL").OrderBy(y => y.name).Select(z => z.name).ToList();

            return result;
        }        

        private void btnWeather_Click(object sender, EventArgs e)
        {           
            if (comboBoxCity.SelectedValue == null)
            {
                MessageBox.Show("Nie zaznaczono miasta!");
                return;
            }
            else
            {
                var cityName = comboBoxCity.SelectedValue.ToString();

                var currentWeather = openWeatherMapService.GetCurrentWeather(cityName);

                var iconId = currentWeather.iconId;
                var weatherIcon = openWeatherMapService.GetWeatherIcon(iconId);

                DisplayWeather(currentWeather, weatherIcon);

                AddDataToField();
            }            
        }

        private void DisplayWeather(CurrentWeather weatherData, Image weatherPicture)
        {
            labelCity.Text = weatherData.cityName.ToString();
            labelTemperature.Text = weatherData.temperature.ToString("N1") + " °C";
            labelPressure.Text = weatherData.pressure.ToString("N0") + " hPa";
            labelWind.Text = weatherData.windSpeed.ToString("N0") + " m/s";
            labelClouds.Text = weatherData.clouds.ToString();
            labelHumidity.Text = weatherData.humidity.ToString() + " %";
            labelSunrise.Text = weatherData.sunrise.ToLocalTime().ToShortTimeString();
            labelSunset.Text = weatherData.sunset.ToLocalTime().ToShortTimeString();
            pictureWeather.Image = weatherPicture;            
        }
        
        private void AddDataToField()
        {
            mainWeatherViewModel.City = labelCity.Text;
            mainWeatherViewModel.Temperature = labelTemperature.Text;
            mainWeatherViewModel.Pressure = labelPressure.Text;
            mainWeatherViewModel.Wind = labelWind.Text;
            mainWeatherViewModel.Clouds = labelClouds.Text;
            mainWeatherViewModel.Humidity = labelHumidity.Text;
            mainWeatherViewModel.Sunrise = labelSunrise.Text;
            mainWeatherViewModel.Sunset = labelSunset.Text;
        }        

        private void btnCSV_Click(object sender, EventArgs e)
        {
            var csvCreator = new CsvCreator();
            csvCreator.CreateFileCsv(mainWeatherViewModel);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            var pdfCreator = new PdfCreator();
            pdfCreator.CreateFilePdf(mainWeatherViewModel);           
        }
        
        private void btnTXT_Click(object sender, EventArgs e)
        {
            var txtCreator = new TxtCreator();
            txtCreator.CreateFileTxt(mainWeatherViewModel);                        
        }        

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            Form5 openForm5 = new Form5();
            openForm5.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
