using System.Collections.Generic;

namespace ExemploWebAPI.Models
{
    public partial struct Genres
    {
        public string String;
        public List<string> StringArray;

        public static implicit operator Genres(string String) => new Genres { String = String };
        public static implicit operator Genres(List<string> StringArray) => new Genres { StringArray = StringArray };
    }
}

