using intellectus_desktop_client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace intellectus_desktop_client.Services
{
    public static class API
    {
        public static Operator Login(string user, string psw)
        {
            var bodyData = new Dictionary<string, string>
            {
                { "username", user },
                { "password", psw }
            };

            string prueba = JsonConvert.SerializeObject(bodyData);
            var content = new StringContent(prueba, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, "http://localhost:3010/api/auth/login");
                requestM.Content = content;
                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    Operator loggedUser = JsonConvert.DeserializeObject<Operator>(apiResponse);
                    return loggedUser;
                }

                return null;
            }
        }
    }
}
