namespace WinFormsApp1
{
    partial class stok
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunadi = new System.Windows.Forms.TextBox();
            this.urunadedi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tedarikeden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet:";
            // 
            // urunadi
            // 
            this.urunadi.Location = new System.Drawing.Point(119, 85);
            this.urunadi.Name = "urunadi";
            this.urunadi.Size = new System.Drawing.Size(203, 27);
            this.urunadi.TabIndex = 2;
            this.urunadi.TextChanged += new System.EventHandler(this.urunadi_TextChanged);
            // 
            // urunadedi
            // 
            this.urunadedi.Location = new System.Drawing.Point(119, 121);
            this.urunadedi.Name = "urunadedi";
            this.urunadedi.Size = new System.Drawing.Size(84, 27);
            this.urunadedi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tedarik Eden:";
            // 
            // tedarikeden
            // 
            this.tedarikeden.Location = new System.Drawing.Point(119, 48);
            this.tedarikeden.Name = "tedarikeden";
            this.tedarikeden.Size = new System.Drawing.Size(203, 27);
            this.tedarikeden.TabIndex = 6;
            // 
            // stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tedarikeden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunadedi);
            this.Controls.Add(this.urunadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stok Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox urunadi;
        private TextBox urunadedi;
        private Button button1;
        private Label label3;
        private TextBox tedarikeden;
    }
}