using IParcialJasserRomero.Common;
using IParcialJasserRomero.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Infrastructure.Client
{
    public class HttpWeatherClient
    {
        public async Task<OpenWeather> GetWeatherByCityNameAsync(string city)
        {

            string url = $"{AppSettings.ApiUrl}{city}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";
            string jsonObject = string.Empty;
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return Newtonsoft.Json.JsonConvert.DeserializeObject<OpenWeather>(jsonObject);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<List<HistoricalWeather>> GetHistoricalWeatherAsync(double lat, double lon)
        {
            List<HistoricalWeather> historicalWeather = new List<HistoricalWeather>();
            try
            {
                string jsonObject = string.Empty;
                for (int i = 0; i < 5; i++)
                {
                    string url = $"{AppSettings.OneCallApiUrl}lat={lat}&lon={lon}&dt={GetUnixDateTime()[i]}&units={AppSettings.units}&lang=sp&appid={AppSettings.Token}";


                    using (HttpClient httpClient = new HttpClient())
                    {
                        jsonObject = await httpClient.GetAsync(url).Result.Content.ReadAsStringAsync();
                    }

                    HistoricalWeather hw = Newtonsoft.Json.JsonConvert.DeserializeObject<HistoricalWeather>(jsonObject);
                    historicalWeather.Add(hw);
                }

                if (string.IsNullOrEmpty(jsonObject))
                {
                    throw new NullReferenceException("El objeto json no puede ser null.");
                }

                return historicalWeather;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private long[] GetUnixDateTime()
        {
            //DateTime actual = DateTime.Now;
            //return ((DateTimeOffset)actual).ToUnixTimeSeconds();
            long[] unixDateTimes = new long[5];
            for (int i = 0; i < 5; i++)
            {
                DateTime dt = DateTime.Today.AddDays(-(i));
                unixDateTimes[i] = ((DateTimeOffset)dt).ToUnixTimeSeconds();
            }
            return unixDateTimes;
        }
    }
}
