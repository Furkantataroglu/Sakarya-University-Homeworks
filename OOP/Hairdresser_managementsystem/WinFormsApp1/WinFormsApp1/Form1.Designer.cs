namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            customersToolStripMenuItem = new ToolStripMenuItem();
            appointmentsToolStripMenuItem = new ToolStripMenuItem();
            personnelToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(780, 304);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 0;
            button1.Text = "New Appointment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { customersToolStripMenuItem, appointmentsToolStripMenuItem, personnelToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1130, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(76, 20);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // appointmentsToolStripMenuItem
            // 
            appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            appointmentsToolStripMenuItem.Size = new Size(95, 20);
            appointmentsToolStripMenuItem.Text = "Appointments";
            appointmentsToolStripMenuItem.Click += appointmentsToolStripMenuItem_Click;
            // 
            // personnelToolStripMenuItem
            // 
            personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            personnelToolStripMenuItem.Size = new Size(71, 20);
            personnelToolStripMenuItem.Text = "Personnel";
            personnelToolStripMenuItem.Click += personnelToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(730, 380);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(780, 333);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 3;
            button2.Text = "Delete Appointment";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(780, 367);
            button3.Name = "button3";
            button3.Size = new Size(125, 40);
            button3.TabIndex = 4;
            button3.Text = "Update Appointment";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 478);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Management";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem customersToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button2;
        private ToolStripMenuItem appointmentsToolStripMenuItem;
        private ToolStripMenuItem personnelToolStripMenuItem;
        private Button button3;
    }
}
