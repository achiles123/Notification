using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Notification.Hubs;
using Notification.Models;

namespace Notification.Controllers
{
    
    public class NotificationsController : ControllerBase
    {
        IHubContext<NotificationHub> _hubContext;
        ModelService<Room> _sevice;

        public NotificationsController(IHubContext<NotificationHub> hubContext, IMongoDb service)
        {
            _hubContext = hubContext;
            _sevice = new ModelService<Room>(service);
        }

        //[Route("notification")]
        //[HttpGet]
        //public IActionResult index()
        //{
        //    _hubContext.Clients.All.SendAsync("Notification", new object[] { "ok", "ok" });
        //    return Ok("ok");
        //}

        [Route("test")]
        [HttpGet]
        public IActionResult test()
        {
            
            _hubContext.Clients.All.SendAsync("Notification", new List<string>() {"admin", Request.Query["message"] });
            _sevice.Create(new Room() {
                Name = "abcd",
            });
            return Ok(_sevice.Get());
        }

    }
}