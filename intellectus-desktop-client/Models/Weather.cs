using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_client.Models
{
    public class Weather
    {
        public Weather() { }

        [JsonProperty("description")]
        public string Descrption { get; set; }

        [JsonProperty("currentTemperature")]
        public float CurrentTemperature { get; set; }

        [JsonProperty("image")]
        public string ImagePath { get; set; }
    }
}
