/****************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2023-2024 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........:1. Proje
**				��RENC� ADI............:Furkan Tataro�lu
**				��RENC� NUMARASI.......:g201210089
**                         DERS�N ALINDI�I GRUP...:1C
****************************************************************************/
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddCustomer();
            

        }



        private void AddCustomer()
        {
            using (AddCustomer addCustomerForm = new AddCustomer())
            {
                addCustomerForm.ShowDialog();
            }
            LoadCustomers();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = true;

            using (var context = new AppDbContext())
            {
                var customers = context.Customers.ToList();
                dataGridView1.DataSource = customers;
            }

        }

        private void LoadCustomers()
        {
            using (var context = new AppDbContext())
            {
                var customers = context.Customers.ToList();
                dataGridView1.DataSource = customers;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DeleteForm deleteForm = new DeleteForm())
            {
                deleteForm.ShowDialog();
            }
            LoadCustomers();  // Form kapand�ktan sonra verileri yeniden y�kle

        }

        private void LoadAppointments()
        {
            using (var context = new AppDbContext())
            {
                var appointments = context.Appointments
                    .Include(a => a.AppointmentServices)
                    .ThenInclude(p => p.Service)
                    .Select(a => new
                    {
                        a.CustomerFirstName,
                        a.CustomerLastName,
                        a.TotalPrice,
                        a.Profit,
                        ServiceNames = string.Join(", ", a.AppointmentServices.Select(p => p.Service.ServiceName)),
                        PersonnelName = a.Personnel.Name,
                        a.Time,
                        
                    })
                    .ToList();

                dataGridView1.DataSource = appointments;

                dataGridView1.Columns["CustomerFirstName"].HeaderText = "First Name";
                dataGridView1.Columns["CustomerLastName"].HeaderText = "Last Name";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Total Price";
                dataGridView1.Columns["Profit"].HeaderText = "Profit";
                dataGridView1.Columns["ServiceNames"].HeaderText = "Services";
                dataGridView1.Columns["PersonnelName"].HeaderText = "Personnel Name";




            }
        }

        private void appointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = false;

            LoadAppointments();
        }

        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = false;

            using (var context = new AppDbContext())
            {
                var personnel = context.Personnel.ToList();
                dataGridView1.DataSource = personnel;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int customerId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                using (var updateForm = new UpdateCustomerForm(customerId))
                {
                    updateForm.ShowDialog();
                }
                LoadCustomers(); // G�ncelleme sonras� verileri yeniden y�kleyin
            }
            else
            {
                MessageBox.Show("G�ncellemek i�in bir m��teri se�in", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            using (var context = new AppDbContext())
            {
                var services = context.Services.ToList();
                dataGridView1.DataSource = services;
                dataGridView1.Columns["ServiceName"].HeaderText = "Services";


            }
        }
    }
}
