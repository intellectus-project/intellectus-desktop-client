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
        private static readonly string URI = "https://intellectus-api.herokuapp.com";

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
                HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, URI + "/api/auth/login");
                requestM.Content = content;
                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    Operator loggedUser = JsonConvert.DeserializeObject<Operator>(apiResponse);
                    Domain.CurrentUser = loggedUser;
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
                HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, URI + "/calls");
                requestM.Content = content;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Domain.CurrentUser.AccessToken);

                HttpResponseMessage response = client.SendAsync(requestM).Result;
                //response.StatusCode = System.Net.HttpStatusCode.OK;
                Call call = new Call();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    call = JsonConvert.DeserializeObject<Call>(apiResponse);
                    
                }
                
                Domain.CurrentUser.Call = call;
                Domain.CurrentUser.Call.StartTime = startTime;
                return true;
            }
            return false;
        }

        public static bool EndCall()
        {
            string data = JsonConvert.SerializeObject(Domain.CurrentUser.Call);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                HttpRequestMessage requestM = new HttpRequestMessage(new HttpMethod("PATCH"), string.Format("{0}/calls/{1}", URI, Domain.CurrentUser.Call.Id));
                requestM.Content = content;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Domain.CurrentUser.AccessToken);

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
