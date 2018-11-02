using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherInformer.ViewModels;

namespace WeatherInformer
{
    public class CsvCreator
    {        
        public void CreateFileCsv(MainWeatherViewModel mainWeatherViewModel)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.csv)|*.csv";
            saveFileDialog.ShowDialog();
            string filePath = saveFileDialog.FileName;

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.City));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Temperature));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Pressure));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Wind));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Clouds));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Humidity));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Sunrise));
            stringBuilder.AppendLine(string.Join(";", mainWeatherViewModel.Sunset));

            File.AppendAllText(filePath, stringBuilder.ToString());
        }
    }
}
