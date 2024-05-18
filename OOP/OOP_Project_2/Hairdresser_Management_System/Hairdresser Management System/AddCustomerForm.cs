using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hairdresser_Management_System
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(AddCustomerForm_Load);
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var services = context.Services
                    .Select(s => new { s.Id, s.ServiceName })
                    .ToList();

                checkedListBox1.Items.Clear();
                foreach (var service in services)
                {
                    checkedListBox1.Items.Add(new { service.Id, service.ServiceName}, false);
                }

                checkedListBox1.DisplayMember = "ServiceName";
                checkedListBox1.ValueMember = "Id";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Tüm alanların dolu olup olmadığını kontrol edin
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // En az bir servis seçildiğini kontrol edin
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir servis seçin.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var customer = new Customer
                {
                    Name = textBox1.Text,
                    Surname = textBox2.Text,
                    PhoneNumber = textBox3.Text,
                    Services = new List<Service>()
                };

                foreach (var item in checkedListBoxServices.CheckedItems)
                {
                    var service = (dynamic)item;
                    var selectedService = context.Services.Find(service.Id);
                    if (selectedService != null)
                    {
                        customer.Services.Add(selectedService);
                    }
                }

                context.Customers.Add(customer);
                context.SaveChanges();
            }

            MessageBox.Show("Müşteri başarıyla eklendi!");
            this.Close();
        }
    }
}
