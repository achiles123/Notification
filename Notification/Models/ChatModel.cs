using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Models
{
    public class ChatModel
    {
        public string roomId { get; set; }
        public string userName { get; set; }
        public string userId { get; set; }
        public string message { get; set; }
        public int messageType { get; set; }
        public DateTime dateCreate { get; set; }
    }
}
