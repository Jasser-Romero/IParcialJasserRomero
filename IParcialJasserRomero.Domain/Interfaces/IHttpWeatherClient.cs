using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.Interfaces
{
    public interface IHttpWeatherClient
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(string city);
        Task<List<HistoricalWeather>> GetHistoricalWeatherAsync(double lat, double lon);
    }
}
