using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.AppCore.Interfaces
{
    public interface IWeatherService : IService<WeatherHistorial>
    {
        void CreateDTO(WeatherHistorial t);
        List<WeatherDTO> ReadDTOs();
    }
}
