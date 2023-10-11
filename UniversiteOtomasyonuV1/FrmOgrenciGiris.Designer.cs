namespace UniversiteOtomasyonuV1
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrNo = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGuvenlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGuvenlikKodu = new System.Windows.Forms.Label();
            this.PbDegistir = new System.Windows.Forms.PictureBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDegistir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ GİRİŞ EKRANI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(405, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRENCİ NUMARASI:";
            // 
            // TxtOgrNo
            // 
            this.TxtOgrNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtOgrNo.Location = new System.Drawing.Point(201, 60);
            this.TxtOgrNo.MaxLength = 10;
            this.TxtOgrNo.Name = "TxtOgrNo";
            this.TxtOgrNo.Size = new System.Drawing.Size(187, 25);
            this.TxtOgrNo.TabIndex = 2;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtSifre.Location = new System.Drawing.Point(201, 94);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(187, 25);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(135, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE:";
            // 
            // TxtGuvenlik
            // 
            this.TxtGuvenlik.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtGuvenlik.Location = new System.Drawing.Point(201, 125);
            this.TxtGuvenlik.Name = "TxtGuvenlik";
            this.TxtGuvenlik.Size = new System.Drawing.Size(83, 25);
            this.TxtGuvenlik.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "GÜVENLİK KODU:";
            // 
            // LblGuvenlikKodu
            // 
            this.LblGuvenlikKodu.AutoSize = true;
            this.LblGuvenlikKodu.Location = new System.Drawing.Point(290, 125);
            this.LblGuvenlikKodu.Name = "LblGuvenlikKodu";
            this.LblGuvenlikKodu.Size = new System.Drawing.Size(64, 25);
            this.LblGuvenlikKodu.TabIndex = 7;
            this.LblGuvenlikKodu.Text = "label5";
            // 
            // PbDegistir
            // 
            this.PbDegistir.Image = ((System.Drawing.Image)(resources.GetObject("PbDegistir.Image")));
            this.PbDegistir.Location = new System.Drawing.Point(360, 122);
            this.PbDegistir.Name = "PbDegistir";
            this.PbDegistir.Size = new System.Drawing.Size(28, 28);
            this.PbDegistir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbDegistir.TabIndex = 8;
            this.PbDegistir.TabStop = false;
            this.PbDegistir.Click += new System.EventHandler(this.PbDegistir_Click);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.BtnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGirisYap.ForeColor = System.Drawing.Color.White;
            this.BtnGirisYap.Location = new System.Drawing.Point(201, 156);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(187, 37);
            this.BtnGirisYap.TabIndex = 9;
            this.BtnGirisYap.Text = "GİRİŞ YAP";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            this.BtnGirisYap.MouseLeave += new System.EventHandler(this.BtnGirisYap_MouseLeave);
            this.BtnGirisYap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnGirisYap_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(248, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(140, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Şifre Göster/Gizle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.PbDegistir);
            this.Controls.Add(this.LblGuvenlikKodu);
            this.Controls.Add(this.TxtGuvenlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOgrNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOgrenciGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDegistir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox TxtOgrNo;
        private TextBox TxtSifre;
        private Label label3;
        private TextBox TxtGuvenlik;
        private Label label4;
        private Label LblGuvenlikKodu;
        private PictureBox PbDegistir;
        private Button BtnGirisYap;
        private CheckBox checkBox1;
    }
}