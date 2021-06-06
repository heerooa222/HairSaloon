using HairSaloon.Business;
using System;
using System.Linq;

namespace HairSaloon.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClientContext context)
        {
            // Look for any students.
            if (context.Clients.Any())
            {
                return;   // DB has been seeded
            }

            var clients = new Client[]
            {
                new Client{FirstMidName="Carson",LastName="Alexander",AppointmentDate=DateTime.Parse("2019-09-01")},
                new Client{FirstMidName="Meredith",LastName="Alonso",AppointmentDate=DateTime.Parse("2017-09-01")},
                new Client{FirstMidName="Arturo",LastName="Anand",AppointmentDate=DateTime.Parse("2018-09-01")},
                new Client{FirstMidName="Gytis",LastName="Barzdukas",AppointmentDate=DateTime.Parse("2017-09-01")},
               
            };

            context.Clients.AddRange(clients);
            context.SaveChanges();

           

            var appointments = new Appointment[]
            {
                new Appointment{AppointmentID=1,ClientID=1050,AppointmentDay=DateTime.Parse("2020-01-20")},
                new Appointment{AppointmentID=1,ClientID=4022,AppointmentDay=DateTime.Parse("2020-04-20")},
                new Appointment{AppointmentID=1,ClientID=4041,AppointmentDay=DateTime.Parse("2020-01-20")},
               
            };

            context.Appointments.AddRange(appointments);
            context.SaveChanges();
        }
    }
}