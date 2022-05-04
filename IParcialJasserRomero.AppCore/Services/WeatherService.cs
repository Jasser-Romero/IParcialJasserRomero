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
    public class WeatherService : IWeatherService
    {
        private IWeatherModel model;
        public WeatherService(IWeatherModel model)
        {
            this.model = model;
        }
        public void Create(WeatherHistorial t)
        {
            model.Create(t);
        }

        public void CreateDTO(WeatherHistorial t, OpenWeather g)
        {
            model.CreateDTO(t, g);
        }

        public List<WeatherHistorial> Read()
        {
            return model.Read();
        }

        public List<WeatherDTO> ReadDTOs()
        {
            return model.ReadDTOs();
        }
    }
}
