using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EastFive.AzureADB2C
{
    public static class AppSettings
    {
        public const string ClientId = "b2c:ClientId";
        /// <summary>
        /// This can only be accessed when the Key is created
        /// AD UI -> App Registrations -> [APP] -> All Settings -> Keys -> [New Key]
        /// </summary>
        public const string ClientSecret = "b2c:ClientSecret";
        public const string Tenant = "b2c:Tenant";
    }
}

