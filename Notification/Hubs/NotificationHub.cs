using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Notification.Hubs
{
    public class NotificationHub:Hub
    {
        public async Task SendMessage(String message)
        {
            await Clients.All.SendAsync("Notification", message);
        }
    }
}
