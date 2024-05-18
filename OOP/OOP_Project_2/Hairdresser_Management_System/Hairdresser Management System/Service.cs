using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdresser_Management_System
{
    public class Service
    {

        public int Id { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public ICollection<Customer> Customers { get; set; }  // Çoktan çoğa ilişki

        public Service()
        {
            Customers = new HashSet<Customer>();
        }
    }

}
