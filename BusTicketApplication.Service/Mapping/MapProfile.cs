using AutoMapper;
using BusTicketApplication.Core.Models.Dtos;
using BusTicketApplication.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Bus, BusDto>().ReverseMap();
            CreateMap<Passenger,PassengerDto>().ReverseMap();
            CreateMap<Route,RouteDto>().ReverseMap();
            CreateMap<Trip,TripDto>().ReverseMap();
            CreateMap<Ticket,TicketDto>().ReverseMap();


        }
    }
}
