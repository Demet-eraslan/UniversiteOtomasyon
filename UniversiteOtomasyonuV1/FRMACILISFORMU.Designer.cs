namespace UniversiteOtomasyonuV1
{
    partial class FRMACILISFORMU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMACILISFORMU));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Ogrenci = new System.Windows.Forms.Button();
            this.BTN_Akademisyen = new System.Windows.Forms.Button();
            this.BTN_Idari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 40);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(614, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "BİLİM VE TEKNOLOJİ ÜNİVERSİTESİ";
            // 
            // BTN_Ogrenci
            // 
            this.BTN_Ogrenci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTN_Ogrenci.FlatAppearance.BorderSize = 0;
            this.BTN_Ogrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ogrenci.ForeColor = System.Drawing.Color.White;
            this.BTN_Ogrenci.Location = new System.Drawing.Point(12, 192);
            this.BTN_Ogrenci.Name = "BTN_Ogrenci";
            this.BTN_Ogrenci.Size = new System.Drawing.Size(178, 49);
            this.BTN_Ogrenci.TabIndex = 1;
            this.BTN_Ogrenci.Text = "ÖĞRENCİ";
            this.BTN_Ogrenci.UseVisualStyleBackColor = false;
            this.BTN_Ogrenci.Click += new System.EventHandler(this.BTN_Ogrenci_Click);
            // 
            // BTN_Akademisyen
            // 
            this.BTN_Akademisyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTN_Akademisyen.FlatAppearance.BorderSize = 0;
            this.BTN_Akademisyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Akademisyen.ForeColor = System.Drawing.Color.White;
            this.BTN_Akademisyen.Location = new System.Drawing.Point(12, 266);
            this.BTN_Akademisyen.Name = "BTN_Akademisyen";
            this.BTN_Akademisyen.Size = new System.Drawing.Size(178, 49);
            this.BTN_Akademisyen.TabIndex = 2;
            this.BTN_Akademisyen.Text = "AKADEMİSYEN";
            this.BTN_Akademisyen.UseVisualStyleBackColor = false;
            this.BTN_Akademisyen.Click += new System.EventHandler(this.BTN_Akademisyen_Click);
            // 
            // BTN_Idari
            // 
            this.BTN_Idari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.BTN_Idari.FlatAppearance.BorderSize = 0;
            this.BTN_Idari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Idari.ForeColor = System.Drawing.Color.White;
            this.BTN_Idari.Location = new System.Drawing.Point(12, 337);
            this.BTN_Idari.Name = "BTN_Idari";
            this.BTN_Idari.Size = new System.Drawing.Size(178, 49);
            this.BTN_Idari.TabIndex = 3;
            this.BTN_Idari.Text = "İDARİ";
            this.BTN_Idari.UseVisualStyleBackColor = false;
            this.BTN_Idari.Click += new System.EventHandler(this.BTN_Idari_Click);
            // 
            // FRMACILISFORMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 498);
            this.Controls.Add(this.BTN_Idari);
            this.Controls.Add(this.BTN_Akademisyen);
            this.Controls.Add(this.BTN_Ogrenci);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMACILISFORMU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMACILISFORMU";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button BTN_Ogrenci;
        private Button BTN_Akademisyen;
        private Button BTN_Idari;
    }
}