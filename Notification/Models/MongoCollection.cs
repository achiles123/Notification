using Notification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Models
{
    public class MongoCollection : IMongoDb
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
