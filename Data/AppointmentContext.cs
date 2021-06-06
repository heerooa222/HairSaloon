using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HairSaloon.Business;

namespace HairSaloon.Data
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext (DbContextOptions<AppointmentContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().ToTable("Appointment");
            modelBuilder.Entity<Client>().ToTable("Client");
        }

        //public DbSet<HairSaloon.Business.Appointment> Appointment { get; set; }
    }
}
