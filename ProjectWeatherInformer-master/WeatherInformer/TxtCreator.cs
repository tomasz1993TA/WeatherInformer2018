using System;
using System.Collections.Generic;
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Plik TXT został zapisany!");

            string filePath = saveFileDialog.FileName;

            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath);
            streamWriter.Write("Miasto: " + mainWeatherViewModel.City + Environment.NewLine);
            streamWriter.Write("Temperatura: " + mainWeatherViewModel.Temperature + Environment.NewLine);
            streamWriter.Write("Ciśnienie: " + mainWeatherViewModel.Pressure + Environment.NewLine);
            streamWriter.Write("Wiatr: " + mainWeatherViewModel.Wind + Environment.NewLine);
            streamWriter.Write("Zachmurzenie: " + mainWeatherViewModel.Clouds + Environment.NewLine);
            streamWriter.Write("Wilgotność: " + mainWeatherViewModel.Humidity + Environment.NewLine);
            streamWriter.Write("Wschód Słońca: " + mainWeatherViewModel.Sunrise + Environment.NewLine);
            streamWriter.Write("Zachód Słońca: " + mainWeatherViewModel.Sunset + Environment.NewLine);

            streamWriter.Close();
        }
    }
}
