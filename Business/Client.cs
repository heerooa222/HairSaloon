using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSaloon.Business
{
    public class Client
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime AppointmentDate { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
