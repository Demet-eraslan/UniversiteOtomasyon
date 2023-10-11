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

namespace UniversiteOtomasyonuV1
{
    public partial class FRMOGRENCIANAFORM : Form
    {
        public FRMOGRENCIANAFORM()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string ogrencininNumarasi, ogrencininAdi, ogrencininSoyadi;

        private void FRMOGRENCIANAFORM_Load(object sender, EventArgs e)
        {
            universiteBilgiGetir();

            LBL_OgrenciAdiSoyadi.Text = ogrencininAdi + " " + ogrencininSoyadi;
            LBL_OgrenciNo.Text = ogrencininNumarasi;

            ogrenciBilgiGetir();

            Panel_Genel.Visible = false;
            ortalamaKontrol();
        }
        void universiteBilgiGetir()
        {
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select * from Tbl_UniversiteBilgi", baglanti);
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

        void ogrenciBilgiGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_OgrenciDetay WHERE OGRNO=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1",ogrencininNumarasi);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                LBL_OgrenciFakulte.Text = dr["OGRFAKULTE"].ToString();
                LBL_Bolum.Text = dr["OGRBOLUM"].ToString();
                LBL_DonemOrt.Text = dr["OGRDONEM"].ToString();
                LBL_GenelOrt.Text = dr["OGRGENEL"].ToString();
                LBL_OgrenciSinif.Text = dr["OGRSINIF"].ToString()+". Sınıf";
                Pb_OgrenciResim.ImageLocation = dr["OGRESIM"].ToString();
            }
            baglanti.Close();
        }
        void ortalamaKontrol()
        {
            double donemOrt = Convert.ToDouble(LBL_DonemOrt.Text);
            double genelOrt = Convert.ToDouble(LBL_GenelOrt.Text);

                if (donemOrt < 2.00)
            {
                LBL_DonemOrt.ForeColor = Color.Red;
            }
            else
            {
                LBL_DonemOrt.ForeColor = Color.Green;

            }

            if (genelOrt<2.00)
            {
                LBL_GenelOrt.ForeColor = Color.Red;

            }
            else
            {
                LBL_GenelOrt.ForeColor = Color.Green;
            }
        }

        private void BTN_BilgiGuncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.FromArgb(38, 167, 73);
        }

        private void BTN_BilgiGuncelle_MouseLeave(object sender, EventArgs e)
        {
            BTN_BilgiGuncelle.BackColor = Color.FromArgb(17,28, 43);
        }

        private void BTN_BilgiGuncelle_Click(object sender, EventArgs e)
        {
            Panel_Genel.Visible = false;  


            FRMOGRENCIBILGIGUNCELLE frm = new FRMOGRENCIBILGIGUNCELLE();
            frm.ogrenciNumarasi = ogrencininNumarasi;
            frm.ShowDialog();
        }

        private void FRMOGRENCIANAFORM_Activated(object sender, EventArgs e)
        {
            ogrenciBilgiGetir();
            ogrenciBilgiGetir();
        }

        private void PB_Ogrenci_Bilgi_Ekrani_Click(object sender, EventArgs e)
        {

            if (Panel_Genel.Visible == false) //Kapalıysa
            {
                Panel_Genel.Visible = true;        //aç   
            }
            else //Kapalı değilse 
            {
                Panel_Genel.Visible = false; // Kapat
            }
        }


    }
}

