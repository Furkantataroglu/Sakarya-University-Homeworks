using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdresser_Management_System
{
    public class Customer : Person
    {
        public ICollection<Service> Services { get; set; }  // Çoktan çoğa ilişki

        public Customer()
        {
            Services = new HashSet<Service>();
        }
    }

}
