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
        public MainWeatherViewModel MainWeatherViewModel { get; set; }
        private OpenWeatherMapService openWeatherMapService { get; set; }

        public MainWeatherView()
        {
            InitializeComponent();
            MainWeatherViewModel = new MainWeatherViewModel();
            openWeatherMapService = new OpenWeatherMapService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCitiesCombobox();
        }

        private void InitializeCitiesCombobox()
        {
            var cityDataList = openWeatherMapService.GetCityDataList();
            var cityNameList = cityDataList.Where(x => x.country == "PL").OrderBy(y => y.name).Select(z => z.name).ToList();
            comboBoxCity.DataSource = cityNameList;
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

                var weatherIcon = openWeatherMapService.GetWeatherIcon();

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
            MainWeatherViewModel.City = labelCity.Text;
            MainWeatherViewModel.Temperature = labelTemperature.Text;
            MainWeatherViewModel.Pressure = labelPressure.Text;
            MainWeatherViewModel.Wind = labelWind.Text;
            MainWeatherViewModel.Clouds = labelClouds.Text;
            MainWeatherViewModel.Humidity = labelHumidity.Text;
            MainWeatherViewModel.Sunrise = labelSunrise.Text;
            MainWeatherViewModel.Sunset = labelSunset.Text;
        }        

        private void btnCSV_Click(object sender, EventArgs e)
        {
            var csvCreator = new CsvCreator();
            csvCreator.CreateFileCsv(MainWeatherViewModel);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            var pdfCreator = new PdfCreator();
            pdfCreator.CreateFilePdf(MainWeatherViewModel);           
        }
        
        private void btnTXT_Click(object sender, EventArgs e)
        {
            var txtCreator = new TxtCreator();
            txtCreator.CreateFileTxt(MainWeatherViewModel);                        
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
