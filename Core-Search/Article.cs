using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Search.Controllers
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<string> Author { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
