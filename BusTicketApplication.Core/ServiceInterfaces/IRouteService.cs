using BusTicketApplication.Core.Models.Dtos;
using BusTicketApplication.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Core.ServiceInterfaces
{
    public interface IRouteService:IService<Route,RouteDto>
    {
    }
}
