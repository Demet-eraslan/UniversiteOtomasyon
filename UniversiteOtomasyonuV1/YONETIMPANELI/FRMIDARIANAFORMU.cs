   using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversiteOtomasyonuV1.YONETIMPANELI
{
    public partial class FRMIDARIANAFORMU : Form
    {
        public FRMIDARIANAFORMU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");

        public string idariKisininNumarasi, idariKisininAdi, idariKisininSoyadi;

        private void FRMIDARIANAFORMU_Activated(object sender, EventArgs e)
        {
            universiteBilgiGetir();
        }

        private void BTN_BilgiGuncelle_Click(object sender, EventArgs e)
        {
            YONETIMPANELI.FRMREKTORADIDEGISTIR frm = new YONETIMPANELI.FRMREKTORADIDEGISTIR();
            frm.ShowDialog();

        }

        private void BTN_BilgiGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.Green;
        }

        private void BTN_BilgiGuncelle_MouseLeave(object sender, EventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Green;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YONETIMPANELI.FRMFAKULTEEKLEMEFORMU eklemeFormu = new YONETIMPANELI.FRMFAKULTEEKLEMEFORMU();
            eklemeFormu.ShowDialog();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.Green;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YONETIMPANELI.FRMBOLUMEKLEMEFORMU frm = new YONETIMPANELI.FRMBOLUMEKLEMEFORMU();
            frm.ShowDialog();
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = Color.Green;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YONETIMPANELI.FRMOGRENCIKAYITFORMU frm = new YONETIMPANELI.FRMOGRENCIKAYITFORMU();
            frm.ShowDialog();
        }

        private void FRMIDARIANAFORMU_Load(object sender, EventArgs e)
        {
            universiteBilgiGetir();
           // MessageBox.Show(idariKisininNumarasi + " " + idariKisininAdi + " " + idariKisininSoyadi);
        }

        void universiteBilgiGetir()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Tbl_UniversiteBilgi ", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                //MessageBox.Show(oku[1].ToString());
                St_RektorAdi.Text = oku[1].ToString();
                St_OgrenciSayi.Text = oku[2].ToString();
                StEgiSayi.Text = oku[3].ToString();
                St_Fakulte_Sayi.Text = oku[4].ToString();
            }
            baglanti.Close();

        }
    }
}
