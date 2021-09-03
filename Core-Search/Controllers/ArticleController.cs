using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Search.Controllers
{   
    [ApiController]
    [Route("[controller]/{searchField}")]
    public class ArticleController : ControllerBase
    {
        public ArticleController()
        {
        }

        [HttpGet]
        public IEnumerable<Article> Get(string searchField)
        {
            //var testing = "https://core.ac.uk:443/api-v2/search/{searchField}?page=1&pageSize=10&apiKey=BMnmqU7poFJc5HVLYNOwdGkE9QiR0DxI";
            var client = new RestClient($"https://core.ac.uk:443/api-v2/search/{searchField}?page=1&pageSize=10&apiKey=BMnmqU7poFJc5HVLYNOwdGkE9QiR0DxI");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return ConvertResponseToArticle(response.Content);
            var testconsole = ConvertResponseToArticle(response.Content);
            Console.WriteLine("ceva");
        }

        public IEnumerable<Article> ConvertResponseToArticle(string content, int articlesNumber = 9)
        {
            var json = JObject.Parse(content)["data"];

            return Enumerable.Range(1, articlesNumber).Select(index => new Article
            {
                Id = json[index]["_source"].Value<int>("id"),
                Author = json[index]["_source"].Value<string>("publisher"),
                Title = json[index]["_source"].Value<string>("title"),
                Description = json[index]["_source"].Value<string>("description"),
                Link = json[index]["_source"].Value<string>("downloadUrl")
            }).ToArray();
        }
    }
}
