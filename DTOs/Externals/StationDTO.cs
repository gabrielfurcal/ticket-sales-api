using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_store_api.DTOs.Externals
{
    public record StationDTO(int Id, string Name, string CountryCode, string Phone, string PostalCode, string Latitude, string Longitude);
}