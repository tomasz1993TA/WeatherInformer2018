using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherInformer.ViewModels;

namespace WeatherInformer
{
    public class PdfCreator
    {               
        public void CreateFilePdf(MainWeatherViewModel mainWeatherViewModel)
        {            
            PdfDocument pdfDocument = new PdfDocument();
            pdfDocument.Info.Title = "Created with PDFsharp";
            
            PdfPage page = pdfDocument.AddPage();

            XGraphics xGraphics = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            xGraphics.DrawString("Miasto: " + mainWeatherViewModel.City, font, XBrushes.Black, 30, 50);
            xGraphics.DrawString("Temperatura: " + mainWeatherViewModel.Temperature, font, XBrushes.Black, 30, 80);
            xGraphics.DrawString("Ciśnienie: " + mainWeatherViewModel.Pressure, font, XBrushes.Black, 30, 110);
            xGraphics.DrawString("Wiatr: " + mainWeatherViewModel.Wind, font, XBrushes.Black, 30, 140);
            xGraphics.DrawString("Zachmurzenie: " + mainWeatherViewModel.Clouds, font, XBrushes.Black, 30, 170);
            xGraphics.DrawString("Wilgotność: " + mainWeatherViewModel.Humidity, font, XBrushes.Black, 30, 200);
            xGraphics.DrawString("Wschód Słońca: " + mainWeatherViewModel.Sunrise, font, XBrushes.Black, 30, 230);
            xGraphics.DrawString("Zachód Słońca " + mainWeatherViewModel.Sunset, font, XBrushes.Black, 30, 260);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pdf Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Plik PDF został zapisany!");

            string filename = saveFileDialog.FileName;

            pdfDocument.Save(filename);
        }
    }
}
