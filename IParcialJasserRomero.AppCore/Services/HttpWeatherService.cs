using IParcialJasserRomero.AppCore.Interfaces;
using IParcialJasserRomero.Domain.Entities;
using IParcialJasserRomero.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.AppCore.Services
{
    public class HttpWeatherService : IHttpWeatherService
    {
        private IHttpWeatherClient httpWeatherClient;
        public HttpWeatherService(IHttpWeatherClient httpWeatherClient)
        {
            this.httpWeatherClient = httpWeatherClient;
        }
        public Task<List<HistoricalWeather>> GetHistoricalWeatherAsync(double lat, double lon)
        {
           return httpWeatherClient.GetHistoricalWeatherAsync(lat, lon);
        }

        public Task<OpenWeather> GetWeatherByCityNameAsync(string city)
        {
            return httpWeatherClient.GetWeatherByCityNameAsync(city);
        }
    }
}
