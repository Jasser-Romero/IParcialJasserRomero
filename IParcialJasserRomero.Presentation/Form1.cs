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
        public OpenWeather openWeather;
        public List<HistoricalWeather> historicalWeather;
        public IWeatherService weatherService;
        private IHttpWeatherService httpWeatherService;
        public Form1(IWeatherService weatherService, IHttpWeatherService httpWeatherService)
        {
            this.weatherService = weatherService;
            this.httpWeatherService = httpWeatherService;
            InitializeComponent();
        }

        private async Task Request()
        {
            openWeather = await httpWeatherService.GetWeatherByCityNameAsync(textBox1.Text);
            historicalWeather = await httpWeatherService.GetHistoricalWeatherAsync(openWeather.Coord.Lat, openWeather.Coord.Lon);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanel2.Controls.Clear();
                Task.Run(Request).Wait();

                List<WeatherHistorial> list = historicalWeather.Select(x => WeatherHistorial.CreateHistorial(x)).ToList();

                if (openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                for (int i = 0; i < historicalWeather.Count; i++)
                {
                    DateTime dt = DateTimeOffset.FromUnixTimeSeconds(historicalWeather[i].Current.Dt).DateTime.Date;

                    WeatherPanel weatherPanel = new WeatherPanel();
                    weatherPanel.HistoricalWeather = historicalWeather[i];
                    weatherPanel.lblFecha.Text = dt.ToString("d");
                    weatherPanel.lblCity.Text = openWeather.Name;
                    weatherPanel.lblTemp.Text = historicalWeather[i].Current.Temp.ToString() + "°C";
                    weatherPanel.lblTimezone.Text = historicalWeather[i].Timezone;
                    weatherPanel.pictureBox1.ImageLocation = GetWeatherImage(historicalWeather[i].Current.Weather[0].Icon);

                    flowLayoutPanel2.Controls.Add(weatherPanel);
                }

                if(!weatherService.Read().Any())
                {
                    list.ForEach(x => weatherService.Create(x));
                    list.ForEach(x => weatherService.CreateDTO(x, openWeather));
                    return;
                }

                List<WeatherHistorial> list2 = weatherService.Read().Where(x => (x.Lat == list[0].Lat)).Select(x => x).ToList();

                if (!list2.Any())
                {
                    list.ForEach(x => weatherService.Create(x));
                    list.ForEach(x => weatherService.CreateDTO(x, openWeather));
                    return;
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Current.Dt != list2[i].Current.Dt)
                    {
                        weatherService.Create(list[i]);
                        weatherService.CreateDTO(list[i], openWeather);
                    } 
                }

                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();

            frmHistorial.weatherService = weatherService;
            frmHistorial.dataGridView1.DataSource = weatherService.ReadDTOs();
            frmHistorial.ShowDialog();

        }

        private string GetWeatherImage(string icon)
        {
            string image = "https://openweathermap.org/img/w/" + icon + ".png";

            return image;
        }
    }
}
