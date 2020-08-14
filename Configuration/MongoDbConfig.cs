using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Configuration
{
    public class MongoDbConfig
    {
        public string Host { get; set; }
        public int Port { get; set; }

        public string User { get; set; }
        public string Password { get; set; }

        public string Database { get; set; }

        public string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Password))
                    return $@"mongodb://{Host}:{Port}";
                return $@"mongodb://@{Host}:{Port}/@{User}/@{Password}";
            }
        }



    }
}
