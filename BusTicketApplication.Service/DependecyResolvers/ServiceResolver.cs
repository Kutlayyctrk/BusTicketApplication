using BusTicketApplication.Core.ServiceInterfaces;
using BusTicketApplication.Service.Mapping;
using BusTicketApplication.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.Service.DependecyResolvers
{
    public static class ServiceResolver
    {
        public static void AddBusinessService(this IServiceCollection services)

        {
            services.AddAutoMapper(typeof(MapProfile));

            services.AddScoped(typeof(IService<,>), typeof(Service<,>));

            services.AddScoped<IBusService, BusService>();
        }
    }
}
