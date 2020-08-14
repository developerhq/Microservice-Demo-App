using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Configuration
{
    public class ServerConfig
    {
        public MongoDbConfig MongoDB { get; set; } = new MongoDbConfig();
    }
}
