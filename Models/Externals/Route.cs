using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_store_api.Models.Externals
{
    public class Route
    {
        public int Id { get; set; }
        public int StartStationId { get; set; }
        public int EndStationId { get; set; }
        public float Distance { get; set; }
    }
}