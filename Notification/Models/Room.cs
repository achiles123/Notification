﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Models
{
    public class Room:Model
    {
        public Room()
        {
            CollectionName = "room";
        }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("status")]
        public int Status { get; set; } = 1;
    }
}
