using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.Entities
{
    public class WeatherHistorial
    {
        public int Id { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public int Timezone_Off { get; set; }
        public Current Current { get; set; }
        public Hourly Hourly { get; set; }

        public static WeatherHistorial CreateHistorial(HistoricalWeather historicalWeather)
        {
            return new WeatherHistorial()
            {
                Lat = historicalWeather.Lat,
                Lon = historicalWeather.Lon,
                Timezone = historicalWeather.Timezone,
                Timezone_Off = historicalWeather.Timezone_Off,
                Current = historicalWeather.Current,
                Hourly = historicalWeather.Hourly[0]
            };

        }
    }
}
