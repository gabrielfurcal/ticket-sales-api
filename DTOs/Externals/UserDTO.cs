using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_store_api.DTOs.Externals
{
    public record UserDTO(int Id, string UserName, string Password);
}