using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.AppCore.Interfaces
{
    public interface IHttpWeatherService
    {
        Task<OpenWeather> GetWeatherByCityNameAsync(string city);
        Task<List<HistoricalWeather>> GetHistoricalWeatherAsync(double lat, double lon);
    }
}
