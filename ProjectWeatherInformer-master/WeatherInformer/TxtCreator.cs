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
    public class TxtCreator
    {        
        public void CreateFileTxt(MainWeatherViewModel mainWeatherViewModel)
        {
            var filePath = GetFilePath();

            var txt = CreateFile(filePath);

            AddTextToTxt(txt, mainWeatherViewModel);
        }

        private string GetFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Plik TXT został zapisany!");
            string filePath = saveFileDialog.FileName;

            return filePath;
        }

        private StreamWriter CreateFile(string filePath)
        {
            var txt = new StreamWriter(filePath);

            return txt;
        }

        private void AddTextToTxt(StreamWriter txt, MainWeatherViewModel mainWeatherViewModel)
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
