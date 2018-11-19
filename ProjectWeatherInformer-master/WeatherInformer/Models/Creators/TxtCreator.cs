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
    public class TxtCreator : IFileCreator
    {        
        public void CreateFile(MainWeatherViewModel mainWeatherViewModel)
        {
            StreamWriter txt;

            var filePath = GetFilePath();
            if (filePath == "")
            {
                MessageBox.Show("Nie podano nazwy pliku!");
                return;
            }
            else
                txt = CreateFile(filePath);            

            AddTextToFile(txt, mainWeatherViewModel);

            MessageBox.Show("Plik TXT został zapisany!");
        }

        private string GetFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text|*.txt";
            saveFileDialog.ShowDialog();                
            string filePath = saveFileDialog.FileName;

            return filePath;
        }

        private StreamWriter CreateFile(string filePath)
        {
            var txt = new StreamWriter(filePath);

            return txt;
        }

        private void AddTextToFile(StreamWriter txt, MainWeatherViewModel mainWeatherViewModel)
        {
            txt.Write("Miasto: " + mainWeatherViewModel.City + Environment.NewLine);
            txt.Write("Temperatura: " + mainWeatherViewModel.Temperature + Environment.NewLine);
            txt.Write("Ciśnienie: " + mainWeatherViewModel.Pressure + Environment.NewLine);
            txt.Write("Wiatr: " + mainWeatherViewModel.Wind + Environment.NewLine);
            txt.Write("Zachmurzenie: " + mainWeatherViewModel.Clouds + Environment.NewLine);
            txt.Write("Wilgotność: " + mainWeatherViewModel.Humidity + Environment.NewLine);
            txt.Write("Wschód Słońca: " + mainWeatherViewModel.Sunrise + Environment.NewLine);
            txt.Write("Zachód Słońca: " + mainWeatherViewModel.Sunset + Environment.NewLine);

            txt.Close();
        }        
    }
}
