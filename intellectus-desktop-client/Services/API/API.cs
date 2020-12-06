using intellectus_desktop_client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace intellectus_desktop_client.Services.API
{
    public static class API
    {
        private static readonly string URI = "https://intellectus-api.herokuapp.com";

        public static void Login(string user, string psw)
        {
            var bodyData = new Dictionary<string, string>
            {
                { "username", user },
                { "password", psw }
            };

            string data = JsonConvert.SerializeObject(bodyData);
            var content = new StringContent(data, Encoding.UTF8, "application/json");


            HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, URI + "/api/auth/login");
            requestM.Content = content;
            var response = ExecuteRequest(requestM);

            string apiResponse = response.Content.ReadAsStringAsync().Result;
            Operator loggedUser = JsonConvert.DeserializeObject<Operator>(apiResponse);
            Domain.CurrentUser = loggedUser;
        }
        
        public static void StartCall()
        {
            DateTime startTime = DateTime.UtcNow;
            var bodyData = new Dictionary<string, string>
            {
                { "startTime", startTime.ToString("s") }
            };

            string data = JsonConvert.SerializeObject(bodyData);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, URI + "/calls");
            requestM.Content = content;

            var response = ExecuteRequestWithAuth(requestM);
            string apiResponse = response.Content.ReadAsStringAsync().Result;
            Call call = JsonConvert.DeserializeObject<Call>(apiResponse);
            Domain.CurrentUser.Call = call;
            Domain.CurrentUser.Call.StartTime = startTime;
        }

        public static void EndCall()
        {
            string data = JsonConvert.SerializeObject(Domain.CurrentUser.Call);
            var content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpRequestMessage requestM = new HttpRequestMessage(new HttpMethod("PATCH"), string.Format("{0}/calls/{1}", URI, Domain.CurrentUser.Call.Id));
            requestM.Content = content;
            var response = ExecuteRequestWithAuth(requestM);

            string apiResponse = response.Content.ReadAsStringAsync().Result;
            var rData = JsonConvert.DeserializeObject<Call>(apiResponse);
            Domain.CurrentUser.Call.BreakAssigned = rData.BreakAssigned;
            Domain.CurrentUser.Call.MinutesDuration = rData.MinutesDuration;
        }

        public static T Deserialize<T>(HttpResponseMessage response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static void TakeABreak()
        {
            Domain.CurrentUser.Call.BreakAssigned = true;
            HttpRequestMessage requestM = new HttpRequestMessage(HttpMethod.Post, string.Format("{0}/breaks?callId={1}&minutesDuration={2}", URI, Domain.CurrentUser.Call.Id, Domain.CurrentUser.Call.MinutesDuration));

            ExecuteRequestWithAuth(requestM);
        }

        private static HttpResponseMessage ExecuteRequest(HttpRequestMessage request)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.SendAsync(request).Result;
                if (!response.IsSuccessStatusCode)
                    throw new HttpResponseMessageException(response.StatusCode, response);
                return response;
            }
        }
        private static HttpResponseMessage ExecuteRequestWithAuth(HttpRequestMessage request)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Domain.CurrentUser.AccessToken);
              
                HttpResponseMessage response = client.SendAsync(request).Result;
               
                if (!response.IsSuccessStatusCode)
                    throw new HttpResponseMessageException(response.StatusCode, response);

                return response;
            }
        }
    }
}
