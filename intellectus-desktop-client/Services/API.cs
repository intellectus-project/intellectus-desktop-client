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
                HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, "http://localhost:3010/calls");
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
                HttpRequestMessage requestM = new HttpRequestMessage(new HttpMethod("PATCH"), string.Format("http://localhost:3010/calls/{0}",Domain.CurrentUser.Call.Id));
                requestM.Content = content;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Domain.CurrentUser.AccessToken);

                HttpResponseMessage response = client.SendAsync(requestM).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string apiResponse = response.Content.ReadAsStringAsync().Result;
                    var rData = JsonConvert.DeserializeObject<Call>(apiResponse);
                    Domain.CurrentUser.Call.BreakAssigned = rData.BreakAssigned;
                    return true;
                }
            }
            return false;
        }
    }
}
