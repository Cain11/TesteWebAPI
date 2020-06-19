using ExemploWebAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ExemploWebAPI.Controllers
{
    public class Program
    {

        static void Main(String[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "@\books.json");

            var books = JsonConvert.DeserializeObject<List<Books>>(json);
        }
    }
}