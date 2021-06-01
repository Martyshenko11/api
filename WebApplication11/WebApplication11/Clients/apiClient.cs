using System;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;
using Newtonsoft.Json;

namespace WebApplication1.Clients
{
    public class apiClient
    {
        private HttpClient _client;
        private static string _address;
        public static string _apikey;


        public apiClient()
        {
            _address = Constants.address;
            _apikey = Constants.apiKey;

            _client = new HttpClient();
            _client.BaseAddress = new Uri(_address);
        }

        public async Task<Parameters> GetArticles()
        {
            var response = await _client.GetAsync($"/svc/mostpopular/v2/viewed/30.json?api-key={_apikey}");
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (System.Net.Http.HttpRequestException)
            {
                Console.WriteLine("System.Net.Http.HttpRequestException");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<Parameters>(content);

            return result;
        }
 

        public async Task<Parameters3> GetArticles3()
        {
            var response = await _client.GetAsync($"/svc/books/v3/lists/current/hardcover-fiction.json?api-key={_apikey}");

            response.EnsureSuccessStatusCode();

            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<Parameters3>(content);

            return result;
        }


        public async Task<Parameters4> GetArticles4(string Name)
        {
            var response = await _client.GetAsync($"/svc/movies/v2/reviews/search.json?query={Name}&api-key={_apikey}");
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (System.Net.Http.HttpRequestException)
            {
                Console.WriteLine("System.Net.Http.HttpRequestException");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<Parameters4>(content);

            return result;
        }
   

        public async Task<Parameters6> GetArticles6(string Name)
        {
            var response = await _client.GetAsync($"/svc/topstories/v2/{Name}.json?api-key={_apikey}");
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (System.Net.Http.HttpRequestException)
            {
                Console.WriteLine("System.Net.Http.HttpRequestException");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<Parameters6>(content);

            return result;
        }


        public async Task<Parameters7> GetArticles7(string Name)
        {
            var response = await _client.GetAsync($"/svc/community/v3/user-content/url.json?api-key={_apikey}&offset=0&url={Name}");
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (System.Net.Http.HttpRequestException)
            {
                Console.WriteLine("System.Net.Http.HttpRequestException");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            var result = JsonConvert.DeserializeObject<Parameters7>(content);

            return result;
        }

    }
}