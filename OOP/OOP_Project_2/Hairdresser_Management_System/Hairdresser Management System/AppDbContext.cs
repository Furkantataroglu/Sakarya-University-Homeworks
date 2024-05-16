using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdresser_Management_System
{
    public class AppDbContext : DbContext
    {
        // Veritabanı bağlantı dizesini belirtin
        public AppDbContext() : base("name=LocalDatabase")
        {
        }

        // DbSet özelliklerini tanımlayın
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }

}

