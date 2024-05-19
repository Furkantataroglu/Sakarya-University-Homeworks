using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateCustomerForm : Form
    {
        private int customerId;
        public UpdateCustomerForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            LoadServices();
            LoadPersonnel();

            using (var context = new AppDbContext())
            {
                var appointment = context.Appointments.FirstOrDefault(a => a.CustomerId == customerId);
                if (appointment != null)
                {
                    txtTime.Text = appointment.Time;
                    comboBoxPersonnel.SelectedValue = appointment.PersonnelId;

                    var selectedServiceIds = context.AppointmentServices
                        .Where(p => p.AppointmentId == appointment.Id)
                        .Select(p => p.ServiceId)
                        .ToList();

                    foreach (var serviceId in selectedServiceIds)
                    {
                        var service = context.Services.FirstOrDefault(s => s.Id == serviceId);
                        if (service != null)
                        {
                            checkedListBoxServices.SetItemChecked(
                                checkedListBoxServices.Items.IndexOf(service.ServiceName), true);
                        }
                    }
                }
            }
        }
        private void LoadPersonnel()
        {
            using (var context = new AppDbContext())
            {
                var personnel = context.Personnel.ToList();
                comboBoxPersonnel.DataSource = personnel;
                comboBoxPersonnel.DisplayMember = "Name";
                comboBoxPersonnel.ValueMember = "Id";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTime.Text) ||
    comboBoxPersonnel.SelectedIndex == -1 ||
    checkedListBoxServices.CheckedItems.Count == 0)
            {
                MessageBox.Show("Boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string time = txtTime.Text;
            int personnelId = (int)comboBoxPersonnel.SelectedValue;

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

            using (var context = new AppDbContext())
            {
                var appointment = context.Appointments.FirstOrDefault(a => a.CustomerId == customerId);
                if (appointment != null)
                {
                    appointment.Time = time;
                    appointment.PersonnelId = personnelId;

                    var oldServices = context.AppointmentServices.Where(p => p.AppointmentId == appointment.Id).ToList();
                    context.AppointmentServices.RemoveRange(oldServices);

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
            }

            MessageBox.Show("Güncelleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
