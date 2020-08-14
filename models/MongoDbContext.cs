using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.models
{
    public interface MongoDbContext
    {
        IMongoCollection<Book> books { get; }
    }
}
