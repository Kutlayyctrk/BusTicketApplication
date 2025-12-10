using BusTicketApplication.Core.Models.Entities;
using BusTicketApplication.DAL.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketApplication.DAL.ContextClasses
{
    public class MyContext : DbContext

    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new RouteConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            modelBuilder.ApplyConfiguration(new TripConfiguration());
           
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Route> Routes { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
