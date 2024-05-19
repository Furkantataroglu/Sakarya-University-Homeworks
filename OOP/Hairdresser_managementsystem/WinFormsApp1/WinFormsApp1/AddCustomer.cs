using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }


        private void AddCustomer_Load_1(object sender, EventArgs e)
        {
            LoadServices();
            LoadPersonnel();
        }

        private void LoadPersonnel()
        {
            using (var context = new AppDbContext())
            {
                var personnel = context.Personnel.ToList();
                comboBox1.DataSource = personnel;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }
        private void LoadServices()
        {
            using (var context = new AppDbContext())
            {
                var services = context.Services.ToList();
                checkedListBoxServices.Items.Clear();
                foreach (var service in services)
                {
                    checkedListBoxServices.Items.Add(service.ServiceName, false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) ||
            string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBox3.Text, out int phoneNumber))
            {
                MessageBox.Show("Geçerli bir telefon numarası giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkedListBoxServices.CheckedItems.Count == 0)
            {
                MessageBox.Show("En az bir servis seçmelisiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            int personnelId = (int)comboBox1.SelectedValue;
            string time = textBox4.Text;

            var selectedServices = new List<Service>();
            foreach (var item in checkedListBoxServices.CheckedItems)
            {
                var serviceName = item.ToString();
                using (var context = new AppDbContext())
                {
                    var service = context.Services.FirstOrDefault(s => s.ServiceName == serviceName);
                    if (service != null)
                    {
                        selectedServices.Add(service);
                    }
                }
            }

            decimal totalPrice = selectedServices.Sum(s => s.Price);
            decimal totalCost = selectedServices.Sum(s => s.Cost);
            decimal profit = totalPrice - totalCost;

            using (var context = new AppDbContext())
            {
                var customer = new Customer
                {
                    Name = firstName,
                    Surname = lastName,
                    Number = phoneNumber,
                };
                context.Customers.Add(customer);
                context.SaveChanges();

                var appointment = new Appointment
                {
                    CustomerFirstName = firstName,
                    CustomerLastName = lastName,
                    TotalPrice = totalPrice,
                    Profit = profit,
                    CustomerId = customer.Id,
                    PersonnelId = personnelId,
                    Time = time
                };
                context.Appointments.Add(appointment);
                context.SaveChanges();

                foreach (var service in selectedServices)
                {
                    var appointmentService = new AppointmentService
                    {
                        AppointmentId = appointment.Id,
                        ServiceId = service.Id
                    };
                    context.AppointmentServices.Add(appointmentService);
                }
                context.SaveChanges();
            }

            MessageBox.Show("Ekleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
