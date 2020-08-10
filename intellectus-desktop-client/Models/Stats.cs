using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_client.Models
{
    public class Stats
    {

        [JsonProperty("sadness")]
        public float Sadness { get; set; }
        [JsonProperty("happiness")]
        public float Happiness { get; set; }
        [JsonProperty("fear")]
        public float Fear { get; set; }
        [JsonProperty("neutrality")]
        public float Neutrality { get; set; }
        [JsonProperty("anger")]
        public float Anger { get; set; }
    }
}
