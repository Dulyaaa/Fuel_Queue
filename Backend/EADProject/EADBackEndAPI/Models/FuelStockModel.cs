﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EADBackEndAPI.Models
{
    public class FuelStockModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FuelStockId { get; set; }
        public string ShedId { get; set; }
        public string FuelType { get; set; }
        public string Stock { get; set; }
        public string ArrivalTime { get; set; }
        public string FinishTime { get; set; }
        public string Status { get; set; }
    }
}
