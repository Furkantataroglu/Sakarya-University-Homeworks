using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdresser_Management_System
{
    public class Appointment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime AppointmentTime { get; set; }

        public virtual Customer Customer { get; set; }
    }

}
