namespace UniversiteOtomasyonuV1.YONETIMPANELI
{
    partial class FRMREKTORADIDEGISTIR
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
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_RektorName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Panel_Ust_Menu.SuspendLayout();
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
            this.Panel_Ust_Menu.Size = new System.Drawing.Size(360, 40);
            this.Panel_Ust_Menu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rektör Değiştirme Ekranı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(320, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "REKTÖR:";
            // 
            // Txt_RektorName
            // 
            this.Txt_RektorName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_RektorName.Location = new System.Drawing.Point(107, 87);
            this.Txt_RektorName.Name = "Txt_RektorName";
            this.Txt_RektorName.Size = new System.Drawing.Size(174, 25);
            this.Txt_RektorName.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(107, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 46);
            this.button2.TabIndex = 9;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FRMREKTORADIDEGISTIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 210);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_RektorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel_Ust_Menu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FRMREKTORADIDEGISTIR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMREKTORADIDEGISTIR";
            this.Load += new System.EventHandler(this.FRMREKTORADIDEGISTIR_Load);
            this.Panel_Ust_Menu.ResumeLayout(false);
            this.Panel_Ust_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panel_Ust_Menu;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox Txt_RektorName;
        private Button button2;
    }
}