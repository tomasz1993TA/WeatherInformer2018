using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherInformer.ViewModels;
using static WeatherInformer.MainWeatherView;

namespace WeatherInformer
{
    public class CsvCreator : IFileCreator
    {        
        public void CreateFile(MainWeatherViewModel mainWeatherViewModel)
        {
            var filePath = GetFilePath();
            if (filePath == "")
            {
                MessageBox.Show("Nie podano nazwy pliku!");
                return;
            }
            else
                CreateFile(filePath);
            
            AddTextToFile(mainWeatherViewModel, filePath);

            MessageBox.Show("Plik CSV został zapisany!");
        }

        private string GetFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.csv)|*.csv";
            saveFileDialog.ShowDialog();
            string filePath = saveFileDialog.FileName;

            return filePath;
        }

        private void CreateFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        private void AddTextToFile(MainWeatherViewModel mainWeatherViewModel, string filePath)
        {
            var stringBuilder = new StringBuilder();

            string[] weatherArray = { mainWeatherViewModel.City, mainWeatherViewModel.Temperature, mainWeatherViewModel.Pressure , mainWeatherViewModel.Wind ,
                mainWeatherViewModel.Clouds , mainWeatherViewModel.Humidity , mainWeatherViewModel.Sunrise , mainWeatherViewModel.Sunset };

            stringBuilder.Append(string.Join(";", weatherArray));            
            
            File.AppendAllText(filePath, stringBuilder.ToString());
        }                
    }
}
