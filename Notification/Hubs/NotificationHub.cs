using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Notification.Models;
using Newtonsoft.Json;

namespace Notification.Hubs
{
    public class NotificationHub:Hub
    {
        public void SendNotification(String name, String message)
        {
            Clients.All.SendAsync("onNotification", new List<string>() { name, message });
        }

        public void SendMessage(string chat)
        {
            ChatModel obj = JsonConvert.DeserializeObject<ChatModel>(chat);
            Clients.All.SendAsync("onMessage", new List<ChatModel>() { obj });
        }
    }
}
