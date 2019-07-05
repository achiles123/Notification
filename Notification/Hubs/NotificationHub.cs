using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Notification.Hubs
{
    public class NotificationHub:Hub
    {
        public void SendNotification(String name, String message)
        {
            Clients.All.SendAsync("onNotification", new List<string>() { name, message });
        }

        public void SendMessage(String name, String message)
        {
            Clients.All.SendAsync("onMessage", new List<string>() { name, message });
        }
    }
}
