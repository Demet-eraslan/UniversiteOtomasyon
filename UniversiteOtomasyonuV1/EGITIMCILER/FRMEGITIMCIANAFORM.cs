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

namespace UniversiteOtomasyonuV1.EGITIMCILER
{
    public partial class FRMEGITIMCIANAFORM : Form
    {
        public FRMEGITIMCIANAFORM()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string egitimcininNumarasi, egitimcininUnvani, egitimcininAdi, egitimcininSoyadi;

        private void PB_Egitimci_Bilgi_Ekrani_Click(object sender, EventArgs e)
        {
            if (Panel_Genel.Visible==false)
            {
                Panel_Genel.Visible = true;
            }
            else
            {
                Panel_Genel.Visible = false;
            }
        }

        private void BTN_BilgiGuncelle_MouseLeave(object sender, EventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void BTN_BilgiGuncelle_Click(object sender, EventArgs e)
        {
            Panel_Genel.Visible = false;
            EGITIMCILER.FRMEGITIMCIBILGIGUNCELLEME frm = new EGITIMCILER.FRMEGITIMCIBILGIGUNCELLEME();
            frm.egitimciNumarasi = egitimcininNumarasi;
            frm.ShowDialog();

        }

        private void FRMEGITIMCIANAFORM_Activated(object sender, EventArgs e)
        {
            egitimciBilgileriGetir();
            universiteBilgiGetir();
        }

        private void BTN_BilgiGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.FromArgb(38,167,73);
        }

        private void FRMEGITIMCIANAFORM_Load(object sender, EventArgs e)
        {
            Panel_Genel.Visible = false;

            LBL_EgitimciAdiSoyadi.Text = egitimcininUnvani + " " + egitimcininAdi + " " + egitimcininSoyadi;
            LBL_EgitimciNo.Text = egitimcininNumarasi;

            egitimciBilgileriGetir();

        }
        void universiteBilgiGetir()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Tbl_UniversiteBilgi",baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                St_RektorAdi.Text = oku[1].ToString();
                St_OgrenciSayi.Text = oku[2].ToString();
                StEgiSayi.Text = oku[3].ToString();
                St_Fakulte_Sayi.Text = oku[4].ToString();

            }
            baglanti.Close();
        }
        void egitimciBilgileriGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_EgitimciDetay where EGINO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", egitimcininNumarasi);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                
               LBL_EgitimciFakulte.Text = dr["EGIFAKULTE"].ToString();
               LBL_Egitimci_Bolum.Text = dr["EGIBOLUM"].ToString();
                Pb_EgitimciResim.ImageLocation = dr["EGIRESIM"].ToString();

            }
            baglanti.Close();
        }
    }
}
