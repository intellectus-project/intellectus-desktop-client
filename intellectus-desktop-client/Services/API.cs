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
        public static Operator Login(string user, string psw)
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
                    return loggedUser;
                }

                return null;
            }
        }
        
        public static bool StartCall(Operator user)
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

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.AccessToken);

                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    Call call = JsonConvert.DeserializeObject<Call>(apiResponse);
                    user.Call = call;
                    user.Call.StartTime = startTime;
                    return true;
                }
            }
            return false;
        }

        public static bool EndCall(Operator user)
        {
            string data = JsonConvert.SerializeObject(user.Call);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpRequestMessage requestM = new HttpRequestMessage(new HttpMethod("PATCH"), string.Format("http://localhost:3010/calls/{0}",user.Call.Id));
                requestM.Content = content;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.AccessToken);

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
