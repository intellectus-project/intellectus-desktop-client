using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace intellectus_desktop_client.Models
{
    public class Operator
    {
        public Operator() { }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }


    }
}
