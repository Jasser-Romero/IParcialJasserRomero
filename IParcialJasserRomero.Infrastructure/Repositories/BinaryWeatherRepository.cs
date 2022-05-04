using IParcialJasserRomero.Domain.Entities;
using IParcialJasserRomero.Domain.Interfaces;
using IParcialJasserRomero.Domain.SubModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Infrastructure.Repositories
{
    public class BinaryWeatherRepository : IWeatherModel
    {
        private RAFContext context;
        private RAFContext context2;
        public BinaryWeatherRepository()
        {
            context = new RAFContext("Weather", 700);
            context2 = new RAFContext("DTO", 500);
        }

        public void Create(WeatherHistorial t)
        {
            t.Id = context.GetLastId() + 1;
            WeatherSubModel subModel = WeatherSubModel.Convert(t);
            context.Create(subModel);
        }

        public void CreateDTO(WeatherHistorial t)
        {
            WeatherDTO dto = WeatherDTO.MapWeather(t);
            context2.Create(dto);
        }

        public List<WeatherHistorial> Read()
        {
            List<WeatherSubModel> subModels = context.GetAll<WeatherSubModel>();
            return subModels == null ? new List<WeatherHistorial>() : subModels.Select(x => WeatherSubModel.Convert(x)).ToList();
        }

        public List<WeatherDTO> ReadDTOs()
        {
            return context2.GetAll<WeatherDTO>();
        }
    }
}
