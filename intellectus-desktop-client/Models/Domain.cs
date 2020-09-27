using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace intellectus_desktop_client.Models
{
    public static class Domain
    {
        public static Operator CurrentUser { get; set; }
        public static Weather CurrentWeather { get; set; }
    }
}
