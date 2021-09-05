using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Core_Search.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        public ArticleController()
        {
        }

        [HttpGet("{searchField}")]
        public IEnumerable<Article> Get(string searchField)
        {
            var client = new RestClient($"https://core.ac.uk:443/api-v2/search/{searchField}?page=1&pageSize=10&apiKey=BMnmqU7poFJc5HVLYNOwdGkE9QiR0DxI");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            return ConvertResponseToArticle(response.Content);
        }

        public IEnumerable<Article> ConvertResponseToArticle(string content, int articlesNumber = 9)
        {
            if (content == null)
            {
                return null;
            }
            var json = JObject.Parse(content)["data"];

            return Enumerable.Range(0, articlesNumber).Select(index =>
            {
                var JsonSource = json[index]["_source"];
                JArray categories = (JArray)JsonSource["authors"];
                Console.WriteLine(categories);
                return new Article
                {
                    Id = JsonSource.Value<int>("id"),
                    Author = categories.Select(c => (string)c).ToList(),
                    //Author = JsonSource.Value<string>("publisher"),
                    Title = JsonSource.Value<string>("title"),
                    Description = JsonSource.Value<string>("description"),
                    Link = JsonSource.Value<string>("downloadUrl")
                };
            }).ToArray();
        }
    }
}
