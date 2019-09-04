using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CubeSummationApp.WebUI.Utils
{
    public class ApiCaller
    {
        private readonly HttpClient _httpClient;

        public ApiCaller()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44390")
            };

            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public async Task<T> GetServiceResponseById<T>(string controller, int id)
        {
            var response = await _httpClient.GetAsync(string.Format("/api/{0}/{1}", controller, id));

            if (!response.IsSuccessStatusCode)
                return default(T);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> PostService<T>(string controller, object data)
        {
            var myContent = JsonConvert.SerializeObject(data);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = _httpClient.PostAsync(string.Format("/api/{0}", controller), byteContent).Result;

            if (!response.IsSuccessStatusCode)
                return default(T);

            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
