using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Notification.Hubs;

namespace Notification.Controllers
{
    
    public class NotificationsController : ControllerBase
    {
        IHubContext<NotificationHub> _hubContext;
        public  NotificationsController(IHubContext<NotificationHub> hubContext) => _hubContext = hubContext;

        [Route("notification")]
        [HttpGet]
        public IActionResult index()
        {
            _hubContext.Clients.All.SendAsync("Notification", "ok");
            return Ok("ok");
        }

        [Route("test")]
        [HttpGet]
        public IActionResult test()
        {
            //_hubContext.Clients.All.SendAsync("Notification", "ok");
            return Ok("ok");
        }

    }
}