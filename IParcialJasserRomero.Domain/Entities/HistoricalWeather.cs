using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.Entities
{
    public class HistoricalWeather
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Timezone { get; set; }
        public int Timezone_Off { get; set; }
        public Current Current { get; set; }
        public List<Hourly> Hourly { get; set; }
    }
    public class Current
    {
        public long Dt { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Dew_Point { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public double Wind_Speed { get; set; }
        public List<Weather> Weather { get; set; }
    }

    public class Hourly
    {
        public long Dt { get; set; }
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Dew_Point { get; set; }
        public int Clouds { get; set; }
        public int Visibility { get; set; }
        public double Wind_Speed { get; set; }
        public List<Weather> Weather { get; set; }
    }
}
