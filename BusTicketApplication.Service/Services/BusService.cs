using AutoMapper;
using BusTicketApplication.Core.Models.Dtos;
using BusTicketApplication.Core.Models.Entities;
using BusTicketApplication.Core.RepositoryInterfaces;
using BusTicketApplication.Core.ServiceInterfaces;
using BusTicketApplication.Core.UnitOfWorkInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Service.Services
{
    public class BusService(IBusRepository busRepository,IUnitOfWork unitOfWork, IMapper mapper) : Service<Bus,BusDto>(busRepository, unitOfWork, mapper),IBusService
    {
    }
}
