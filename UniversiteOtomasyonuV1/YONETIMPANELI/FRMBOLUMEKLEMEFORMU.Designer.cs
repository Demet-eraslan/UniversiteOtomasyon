namespace UniversiteOtomasyonuV1.YONETIMPANELI
{
    partial class FRMBOLUMEKLEMEFORMU
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
            this.Panel_Ust_Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB_FakulteListesi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_FakulteName = new System.Windows.Forms.TextBox();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.Panel_Ust_Menu.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Ust_Menu
            // 
            this.Panel_Ust_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Panel_Ust_Menu.Controls.Add(this.label1);
            this.Panel_Ust_Menu.Controls.Add(this.button1);
            this.Panel_Ust_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Ust_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Ust_Menu.Name = "Panel_Ust_Menu";
            this.Panel_Ust_Menu.Size = new System.Drawing.Size(572, 40);
            this.Panel_Ust_Menu.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bölüm Ekleme Ekranı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(532, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(291, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 210);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BÖLÜM LİSTESİ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(241, 178);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB_FakulteListesi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Txt_FakulteName);
            this.groupBox3.Controls.Add(this.Btn_Sil);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Btn_Guncelle);
            this.groupBox3.Controls.Add(this.Btn_Kaydet);
            this.groupBox3.Location = new System.Drawing.Point(12, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 210);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BÖLÜMLER";
            // 
            // CB_FakulteListesi
            // 
            this.CB_FakulteListesi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CB_FakulteListesi.FormattingEnabled = true;
            this.CB_FakulteListesi.Location = new System.Drawing.Point(61, 62);
            this.CB_FakulteListesi.Name = "CB_FakulteListesi";
            this.CB_FakulteListesi.Size = new System.Drawing.Size(190, 28);
            this.CB_FakulteListesi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "FAKT:";
            // 
            // Txt_FakulteName
            // 
            this.Txt_FakulteName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_FakulteName.Location = new System.Drawing.Point(61, 32);
            this.Txt_FakulteName.Name = "Txt_FakulteName";
            this.Txt_FakulteName.Size = new System.Drawing.Size(190, 26);
            this.Txt_FakulteName.TabIndex = 9;
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Btn_Sil.FlatAppearance.BorderSize = 0;
            this.Btn_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sil.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sil.ForeColor = System.Drawing.Color.White;
            this.Btn_Sil.Location = new System.Drawing.Point(61, 166);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(190, 31);
            this.Btn_Sil.TabIndex = 12;
            this.Btn_Sil.Text = "SİL";
            this.Btn_Sil.UseVisualStyleBackColor = false;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            this.Btn_Sil.MouseLeave += new System.EventHandler(this.Btn_Sil_MouseLeave);
            this.Btn_Sil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Sil_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ADI:";
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Btn_Guncelle.FlatAppearance.BorderSize = 0;
            this.Btn_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Guncelle.ForeColor = System.Drawing.Color.White;
            this.Btn_Guncelle.Location = new System.Drawing.Point(61, 129);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(190, 31);
            this.Btn_Guncelle.TabIndex = 11;
            this.Btn_Guncelle.Text = "GÜNCELLE";
            this.Btn_Guncelle.UseVisualStyleBackColor = false;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            this.Btn_Guncelle.MouseLeave += new System.EventHandler(this.Btn_Guncelle_MouseLeave);
            this.Btn_Guncelle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Guncelle_MouseMove);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.Btn_Kaydet.FlatAppearance.BorderSize = 0;
            this.Btn_Kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Kaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.Btn_Kaydet.Location = new System.Drawing.Point(61, 92);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(190, 31);
            this.Btn_Kaydet.TabIndex = 10;
            this.Btn_Kaydet.Text = "KAYDET";
            this.Btn_Kaydet.UseVisualStyleBackColor = false;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            this.Btn_Kaydet.MouseLeave += new System.EventHandler(this.Btn_Kaydet_MouseLeave);
            this.Btn_Kaydet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Kaydet_MouseMove);
            // 
            // FRMBOLUMEKLEMEFORMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 295);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Panel_Ust_Menu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMBOLUMEKLEMEFORMU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMBOLUMEKLEMEFORMU";
            this.Activated += new System.EventHandler(this.FRMBOLUMEKLEMEFORMU_Activated);
            this.Load += new System.EventHandler(this.FRMBOLUMEKLEMEFORMU_Load);
            this.Panel_Ust_Menu.ResumeLayout(false);
            this.Panel_Ust_Menu.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel_Ust_Menu;
        private Label label1;
        private Button button1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private GroupBox groupBox3;
        private ComboBox CB_FakulteListesi;
        private Label label3;
        private TextBox Txt_FakulteName;
        private Button Btn_Sil;
        private Label label2;
        private Button Btn_Guncelle;
        private Button Btn_Kaydet;
    }
}