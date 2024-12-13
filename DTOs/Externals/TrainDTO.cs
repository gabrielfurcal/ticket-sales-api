using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_store_api.DTOs.Externals
{
    public record TrainDTO(int Id, string Type, string Capacity, string maxSpeed);
}