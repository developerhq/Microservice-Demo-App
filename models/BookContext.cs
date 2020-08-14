using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryAPI.Configuration;
using MongoDB.Driver;

namespace LibraryAPI.models
{
    public class BookContext : MongoDbContext
    {
        private readonly IMongoDatabase _db;
        public BookContext(MongoDbConfig config)
        {
            var client = new MongoClient(config.ConnectionString);
            _db = client.GetDatabase(config.Database);
        }
        //creating collection named as books
        public IMongoCollection<Book> books => _db.GetCollection<Book>("books");
    }
}
