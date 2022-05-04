using IParcialJasserRomero.Domain.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.SubModel
{
    public class WeatherSubModel
    {
        public int Id { get; set; }
        public string Json { get; set; }

        public static WeatherSubModel Convert(WeatherHistorial t)
        {
            if (t == null)
            {
                return null;
            }
            WeatherSubModel subModel = new WeatherSubModel();
            subModel.Id = t.Id;
            subModel.Json = JsonConvert.SerializeObject(t);

            return subModel;
        }

        public static WeatherHistorial Convert(WeatherSubModel t)
        {
            if (t == null)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(t.Json))
            {
                return null;
            }
            return JsonConvert.DeserializeObject<WeatherHistorial>(t.Json);
        }
    }
}
