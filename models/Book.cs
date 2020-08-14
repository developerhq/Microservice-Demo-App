using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.models
{
    public class Book
    {
        
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Name { get; set; }

        public string Publisher { get; set; }

        public int Price { get; set; }

    }
}
