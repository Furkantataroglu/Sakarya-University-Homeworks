namespace WinFormsApp1
{
    partial class UpdateCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            txtTime = new TextBox();
            comboBoxPersonnel = new ComboBox();
            checkedListBoxServices = new CheckedListBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 88);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 26;
            label6.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 117);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 25;
            label5.Text = "Personnel";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(129, 85);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(100, 23);
            txtTime.TabIndex = 24;
            // 
            // comboBoxPersonnel
            // 
            comboBoxPersonnel.FormattingEnabled = true;
            comboBoxPersonnel.Location = new Point(130, 114);
            comboBoxPersonnel.Name = "comboBoxPersonnel";
            comboBoxPersonnel.Size = new Size(121, 23);
            comboBoxPersonnel.TabIndex = 23;
            // 
            // checkedListBoxServices
            // 
            checkedListBoxServices.FormattingEnabled = true;
            checkedListBoxServices.Location = new Point(131, 143);
            checkedListBoxServices.Name = "checkedListBoxServices";
            checkedListBoxServices.Size = new Size(120, 94);
            checkedListBoxServices.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(131, 243);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 46);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 14;
            label1.Text = "Update Customer";
            label1.Click += label1_Click;
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTime);
            Controls.Add(comboBoxPersonnel);
            Controls.Add(checkedListBoxServices);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomerForm";
            Load += UpdateCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TextBox txtTime;
        private ComboBox comboBoxPersonnel;
        private CheckedListBox checkedListBoxServices;
        private Button button1;
        private Label label1;
    }
}