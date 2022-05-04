using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.Entities
{
    public class WeatherDTO
    {
        public int Id { get; set; }
        public string Timezone { get; set; }
        public double Temp { get; set; }
        public string Weather { get; set; }
        public string Description { get; set; }
        public double Feels_Like { get; set; }
        public int Pressure { get; set; }
        public int Clouds { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Wind_Speed { get; set; }

        public static WeatherDTO MapWeather(WeatherHistorial weather)
        {
            if (weather == null)
            {
                throw new ArgumentNullException(nameof(weather));
            }

            WeatherDTO subModel = new WeatherDTO()
            {
                Timezone = weather.Timezone,
                Temp = weather.Current.Temp,
                Weather = weather.Current.Weather[0].Main,
                Description = weather.Current.Weather[0].Description,
                Feels_Like = weather.Current.Feels_Like,
                Pressure = weather.Current.Pressure,
                Clouds = weather.Current.Clouds,
                Lat = weather.Lat,
                Lon = weather.Lon,
                Wind_Speed = weather.Current.Wind_Speed
            };

            return subModel;
        }


    }
}
