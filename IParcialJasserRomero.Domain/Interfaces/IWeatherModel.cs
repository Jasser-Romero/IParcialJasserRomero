using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.Interfaces
{
    public interface IWeatherModel : IModel<WeatherHistorial>
    {
        void CreateDTO(WeatherHistorial t, OpenWeather g);
        List<WeatherDTO> ReadDTOs();
    }
}
