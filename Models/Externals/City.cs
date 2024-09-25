using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_store_api.Models.Externals
{
    public class City
    {
        public int Id { get; set; }
        public required string CityName { get; set; }
        public required string Province { get; set; }
        public required string Country { get; set; }
    }
}