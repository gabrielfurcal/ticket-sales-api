using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_store_api.Models.Externals
{
    public class Schedule
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int RouteId { get; set; }
        public int StatusId { get; set; }
        public required string DepartureTime { get; set; }
        public required string ArrivalTime { get; set; }
    }
}