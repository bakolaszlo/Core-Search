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
        [NonAction]
        public IEnumerable<Article> ConvertResponseToArticle(string content, int articlesNumber = 9)
        {
            var status = JObject.Parse(content)["status"];

            if (content == null)
            {
                return null;
            }

            if(status.ToString() == "OK")
            {
                var json = JObject.Parse(content)["data"];

                return Enumerable.Range(0, articlesNumber).Select(index =>
                {
                    var JsonSource = json[index]["_source"];
                    JArray authors = (JArray)JsonSource["authors"];
                    return new Article
                    {
                        Id = JsonSource.Value<int>("id"),
                        Authors = authors.Select(c => (string)c).ToList(),
                        Title = JsonSource.Value<string>("title"),
                        Description = JsonSource.Value<string>("description"),
                        Link = JsonSource.Value<string>("downloadUrl")
                    };
                }).ToArray();
            }
            else
            {
                return null;
            }
            
            
        }
    }
}
