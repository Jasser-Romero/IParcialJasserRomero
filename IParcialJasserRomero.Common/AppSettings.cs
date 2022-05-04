using System;
using System.Configuration;

namespace IParcialJasserRomero.Common
{
    public class AppSettings
    {
        public static string ApiUrl { get => ConfigurationManager.AppSettings.Get("ApiUrl"); }
        public static string Token { get => ConfigurationManager.AppSettings.Get("Token"); }
        public static string units { get => ConfigurationManager.AppSettings.Get("Units"); }
        public static string OneCallApiUrl { get => ConfigurationManager.AppSettings.Get("OneCallApiUrl"); }
    }
}
