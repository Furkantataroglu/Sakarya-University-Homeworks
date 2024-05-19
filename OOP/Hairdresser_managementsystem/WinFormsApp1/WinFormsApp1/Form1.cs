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
            LoadCustomers();  // Form kapandýktan sonra verileri yeniden yükle

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
                        a.Time
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
            LoadAppointments();
        }

        private void personnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var personnel = context.Personnel.ToList();
                dataGridView1.DataSource = personnel;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                LoadCustomers(); // Güncelleme sonrasý verileri yeniden yükleyin
            }
            else
            {
                MessageBox.Show("Güncellemek için bir müþteri seçin", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
