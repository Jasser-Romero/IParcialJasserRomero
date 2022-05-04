using IParcialJasserRomero.AppCore.Interfaces;
using IParcialJasserRomero.Domain.Entities;
using IParcialJasserRomero.Infrastructure.Client;
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
    public partial class Form1 : Form
    {
        public HttpWeatherClient httpWeatherClient;
        public OpenWeather openWeather;
        public List<HistoricalWeather> historicalWeather;
        public IWeatherService weatherService;
        public Form1(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
            httpWeatherClient = new HttpWeatherClient();
            InitializeComponent();
        }

        private async Task Request()
        {
            openWeather = await httpWeatherClient.GetWeatherByCityNameAsync(textBox1.Text);
            historicalWeather = await httpWeatherClient.GetHistoricalWeatherAsync(openWeather.Coord.Lat, openWeather.Coord.Lon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel2.Controls.Clear();
                Task.Run(Request).Wait();
                List<WeatherHistorial> list = historicalWeather.Select(x => WeatherHistorial.CreateHistorial(x)).ToList();
                list.ForEach(x => weatherService.Create(x));
                list.ForEach(x => weatherService.CreateDTO(x));

                if (openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                for (int i = 0; i < historicalWeather.Count; i++)
                {

                    DateTime dt = DateTimeOffset.FromUnixTimeSeconds(historicalWeather[i].Current.Dt).DateTime;

                    WeatherPanel weatherPanel = new WeatherPanel();
                    weatherPanel.HistoricalWeather = historicalWeather[i];
                    weatherPanel.lblFecha.Text = dt.ToString();
                    weatherPanel.lblCity.Text = openWeather.Name;
                    weatherPanel.lblTemp.Text = historicalWeather[i].Hourly[i].Temp.ToString();
                    weatherPanel.lblTimezone.Text = historicalWeather[i].Timezone;

                    flowLayoutPanel2.Controls.Add(weatherPanel);

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();

            frmHistorial.weatherService = weatherService;
            frmHistorial.dataGridView1.DataSource = weatherService.ReadDTOs();
            frmHistorial.ShowDialog();

        }
    }
}
