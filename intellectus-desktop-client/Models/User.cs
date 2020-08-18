using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace intellectus_desktop_client.Models
{
    public static class User
    {
       
        
        [JsonProperty("name")]
        public static string Name { get; set; }

        [JsonProperty("lastname")]
        public static string LastName { get; set; }

        [JsonProperty("email")]
        public static string Email { get; set; }

        [JsonProperty("id")]
        public static long Id { get; set; }

        [JsonProperty("accessToken")]
        public static string AccessToken { get; set; }

        public static Call Call { get; set; }

        public static void MapToStaticClass(Operator source)
        {
            var sourceProperties = source.GetType().GetProperties();

            //Key thing here is to specify we want the static properties only
            var destinationProperties = typeof(User)
                .GetProperties(BindingFlags.Public | BindingFlags.Static);

            foreach (var prop in sourceProperties)
            {
                //Find matching property by name
                var destinationProp = destinationProperties
                    .Single(p => p.Name == prop.Name);

                //Set the static property value
                destinationProp.SetValue(null, prop.GetValue(source));
            }
        }

    }
}
