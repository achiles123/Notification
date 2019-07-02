using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Interfaces
{
    interface IMongoCollection
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
