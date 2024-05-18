using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdresser_Management_System
{
    public class Customer : Person
    {
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }

}
