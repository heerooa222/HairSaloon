using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HairSaloon.Business
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int ClientID { get; set; }
        public DateTime AppointmentDay { get; set; }
        public Client Client { get; set; }
    }
}
