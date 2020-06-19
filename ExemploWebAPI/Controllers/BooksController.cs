using ExemploWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class BooksController : ApiController
    {
        private static List<Books> books = new List<Books>();
        
       

        public Books Get()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "C:\Users\caiot\source\repos\ExemploWebAPI\ExemploWebAPI\books.json");

            var books = JsonConvert.DeserializeObject(json);
            Books b = books as Books;

            return b;
        }
       

        public void Post(string name)
        {
            if(!string.IsNullOrEmpty(name))
            books.Add(new Books(name));
        }
    }
}
