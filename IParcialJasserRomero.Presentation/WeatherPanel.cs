using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcialJasserRomero.Presentation
{
    public partial class WeatherPanel : UserControl
    {
        public HistoricalWeather HistoricalWeather { get; set; }
        private string[] details = { "Description", "Feels like", "Pressure", "Clouds", "Dew Point", "Wind speed", "Humidity", "Visibility" };
        public WeatherPanel()
        {
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            try
            {
                string[] detailsValues = { $"{HistoricalWeather.Current.Weather[0].Description}", $"{HistoricalWeather.Current.Feels_Like}°C", $"{HistoricalWeather.Current.Pressure} hPa", $"{HistoricalWeather.Current.Clouds}%", $"{HistoricalWeather.Current.Dew_Point}°C", $"{HistoricalWeather.Current.Wind_Speed} m/s",
                $"{HistoricalWeather.Current.Humidity}%", $"{HistoricalWeather.Current.Visibility}"};

                for (int i = 0; i < details.Length; i++)
                {
                    DetailsWeather detailsWeather = new DetailsWeather();
                    detailsWeather.lblDetail.Text = details[i] + ":";
                    detailsWeather.lblDetailValue.Text = detailsValues[i];

                    flowLayoutPanel1.Controls.Add(detailsWeather);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
