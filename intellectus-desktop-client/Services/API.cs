using intellectus_desktop_client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intellectus_desktop_client.Services
{
    public static class API
    {
        public static bool Login(string user, string psw)
        {
            var bodyData = new Dictionary<string, string>
            {
                { "username", user },
                { "password", psw }
            };

            string data = JsonConvert.SerializeObject(bodyData);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, "http://localhost:3010/api/auth/login");
                requestM.Content = content;
                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    Operator loggedUser = JsonConvert.DeserializeObject<Operator>(apiResponse);
                    User.MapToStaticClass(loggedUser);
                    return true; 
                }

                return false; 
            }
        }
        
        public static bool StartCall()
        {
            DateTime startTime = DateTime.UtcNow;
            var bodyData = new Dictionary<string, string>
            {
                { "startTime", startTime.ToString("s") }
            };

            string data = JsonConvert.SerializeObject(bodyData);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, "http://localhost:3010/calls");
                requestM.Content = content;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", User.AccessToken);

                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    Call call = JsonConvert.DeserializeObject<Call>(apiResponse);
                    User.Call = call;
                    User.Call.StartTime = startTime;
                    return true;
                }
            }
            return false;
        }

        public static bool EndCall()
        {
            string data = JsonConvert.SerializeObject(User.Call);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpRequestMessage requestM = new HttpRequestMessage(new HttpMethod("PATCH"), string.Format("http://localhost:3010/calls/{0}",User.Call.Id));
                requestM.Content = content;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", User.AccessToken);

                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
