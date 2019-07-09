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
        ModelService<RoomModel> _sevice;

        public NotificationsController(IHubContext<NotificationHub> hubContext, IMongoDb service)
        {
            _hubContext = hubContext;
            _sevice = new ModelService<RoomModel>(service);
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
            
            _hubContext.Clients.All.SendAsync("onNotification", new List<string>() {"admin", Request.Query["message"] });

            return Ok(_sevice.Get());
        }

        [Route("send-message")]
        [HttpGet]
        public IActionResult SendMessage([FromQuery] ChatModel chatRequest)
        {

            _hubContext.Clients.All.SendAsync("onMessage", new List<ChatModel>() { chatRequest });

            return Ok(_sevice.Get());
        }

    }
}