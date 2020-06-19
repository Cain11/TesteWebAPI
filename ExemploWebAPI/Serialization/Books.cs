using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebAPI.Models
{
    public class Books
    {
        public Books(string name)
        {
            Name = name;
        }

        public Books(long id, string name, double price, Specifications specifications)
        {
            Id = id;
            Name = name;
            Price = price;
            Specifications = specifications;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Specifications Specifications { get; set; }
    }
}