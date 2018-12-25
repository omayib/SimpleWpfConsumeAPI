using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpSample
{
    class ApiController
    {
        static String path = "https://jsonplaceholder.typicode.com";
        static HttpClient httpClient = new HttpClient();

        public static async Task<List<Article>> GetPostAsync()
        {
            List<Article> articles = new List<Article>();
            HttpResponseMessage response = await httpClient.GetAsync(path+"/posts");
            if (response.IsSuccessStatusCode)
            {

                articles = await response.Content.ReadAsAsync<List<Article>>();
            }
            return articles;
        }
        public static async Task<Article> getPostDetailAsync(string Id)
        {
            Article article = null;
            HttpResponseMessage response = await httpClient.GetAsync(path + "/posts/"+Id);
            if (response.IsSuccessStatusCode)
            {

                article = await response.Content.ReadAsAsync<Article>();
            }
            return article;
        }
    }
}
