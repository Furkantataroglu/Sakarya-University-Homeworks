using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairdresser_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            addCustomer.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                // Veritabanına bağlanmayı dene ve bağlantının başarılı olup olmadığını kontrol et.
                try
                {
                    var services = context.Services.ToList();
                    // Veritabanına başarıyla bağlandınız ve tabloya erişebiliyorsunuz
                    // Bu bağlantı testi sırasında herhangi bir işlem yapılmıyor.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı başarısız: " + ex.Message);
                }
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCustomer.Visible = false;
            using (var context = new AppDbContext())
            {
                var services = context.Services
                    .Select(s => new { s.ServiceName, s.Price, s.Cost })
                    .ToList();

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ServiceName",
                    HeaderText = "Service"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Price",
                    HeaderText = "Price"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Cost",
                    HeaderText = "Cost"
                });
                dataGridView1.DataSource = services;
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                addCustomer.Visible = true;
                var customers = context.Customers
                    .Select(c => new
                    {

                        c.Name,
                        c.Surname,
                        c.PhoneNumber,
                        ServiceName = c.Service.ServiceName
                    })
                    .ToList();

                // DataGridView'in AutoGenerateColumns özelliğini false yapın
                dataGridView1.AutoGenerateColumns = false;

                // DataGridView sütunlarını manuel olarak ekleyin
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Name",
                    HeaderText = "Name"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Surname",
                    HeaderText = "Surname"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PhoneNumber",
                    HeaderText = "Phone Number"
                });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ServiceName",
                    HeaderText = "Service"
                });

                // Verileri DataGridView'e bağlayın
                dataGridView1.DataSource = customers;
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }
    }
}