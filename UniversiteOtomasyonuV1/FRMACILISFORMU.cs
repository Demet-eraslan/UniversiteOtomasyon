using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversiteOtomasyonuV1.EGITIMCILER;

namespace UniversiteOtomasyonuV1
{
    public partial class FRMACILISFORMU : Form
    {
        public FRMACILISFORMU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Ogrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris frm = new FrmOgrenciGiris();
            frm.Show();
            this.Hide();

        }

        private void BTN_Akademisyen_Click(object sender, EventArgs e)
        {
            EGITIMCILER.FRMEGITIMCIGIRIS frm = new EGITIMCILER.FRMEGITIMCIGIRIS();
            frm.Show();
            this.Hide();
        }

        private void BTN_Idari_Click(object sender, EventArgs e)
        {
            YONETIMPANELI.FRMIDARIGIRIS frm = new YONETIMPANELI.FRMIDARIGIRIS();
            frm.Show();
            this.Hide();
        }
    }
}
