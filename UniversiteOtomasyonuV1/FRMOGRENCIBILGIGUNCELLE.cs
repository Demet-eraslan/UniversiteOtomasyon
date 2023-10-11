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
    public partial class FRMOGRENCIBILGIGUNCELLE : Form
    {
        public FRMOGRENCIBILGIGUNCELLE()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");


        private void Btn_Cikis_Yap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Guncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_Guncelle.BackColor = Color.Green;
        }

        private void BTN_Guncelle_MouseLeave(object sender, EventArgs e)
        {
            BTN_Guncelle.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        public string ogrenciNumarasi;

        private void FRMOGRENCIBILGIGUNCELLE_Load(object sender, EventArgs e)
        {
            // Veritabanı İşlemleri
            //ogrenciSifreGetir();
            //ogrenciResimGetir();
            ogrenciSifreveResimBirlikteGetir();
        }
        // tablo birleştirme işlemleri(innerjoin) iki ve ikiden fazla tabloyu inner join komutuyla birleştirebiliz bir araya getirebiliriz
        //1.tablo_adi.sutun_adi,2.tablo_adi.sutun_adi1
        void ogrenciSifreveResimBirlikteGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Tbl_Ogrenciler.OGRSIFRE, Tbl_OgrenciDetay.OGRESIM FROM Tbl_Ogrenciler inner join Tbl_OgrenciDetay ON Tbl_Ogrenciler.OGRNO=Tbl_OgrenciDetay.OGRNO WHERE Tbl_Ogrenciler.OGRNO=@ogrenciNumarasiLazim  ", baglanti);
            komut.Parameters.AddWithValue("@ogrenciNumarasiLazim", ogrenciNumarasi);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sifreEski = oku["OGRSIFRE"].ToString();
                TXT_Sifre_Degistirme.Text = oku["OGRSIFRE"].ToString();
                TXT_Resim_Degistirme.Text = oku["OGRESIM"].ToString();
                PB_Ogrenci_Resim.ImageLocation = oku["OGRESIM"].ToString();
            }
            baglanti.Close();
        }
        void ogrenciResimGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT OGRESIM FROM Tbl_OgrenciDetay WHERE OGRNO =@ogrenciNumarasi " ,baglanti);
            komut.Parameters.AddWithValue("@ogrenciNumarasi",ogrenciNumarasi);
            // SqlDataReader read = komut.ExecuteReader();
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())//Read() : okuma işlemine ait bir metod !

            {
                
               TXT_Resim_Degistirme.Text =  read["OGRESIM"].ToString();
                PB_Ogrenci_Resim.ImageLocation = read["OGRESIM"].ToString();

            }
            baglanti.Close();

        }
        void ogrenciSifreGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT OGRSIFRE FROM Tbl_Ogrenciler WHERE OGRNO = @ogrencino", baglanti);
            komut.Parameters.AddWithValue("@ogrencino", ogrenciNumarasi);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TXT_Sifre_Degistirme.Text = oku["OGRSIFRE"].ToString();
            }
            baglanti.Close();
        }

        private void PB_Ressim_Ekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme Ekranı";
            ofd.Filter = "PNG | *.png | JPG | *.jpg;*.jpeg | All Files | *.* ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TXT_Resim_Degistirme.Text = ofd.FileName;
                PB_Ogrenci_Resim.Image = new Bitmap(ofd.FileName);
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi.");
            }
            
            //ofd.Filter = "PNG | *.png";
            //ofd.Filter = "JPG | *.jpg;*.jpeg";
            //ofd.Filter = "PNG ve JPG | *.png;*.jpg";
            //ofd.Filter = "All Files | *.*";
            // | = AltGr + <> 


        }

        private void BTN_Guncelle_Click(object sender, EventArgs e)
        {
            // Güncelle İşlemleri
            ogrenciSifreveResimGuncelle();

        }
        string sifreEski, sifreYeni, resimEski;

        void ogrenciSifreveResimGuncelle()
        {
            if (TXT_Sifre_Degistirme.Text!="")
            {

                if (TXT_Sifre_Degistirme.Text != sifreEski)
                {
                    baglanti.Open();
                    SqlCommand komutSifre = new SqlCommand("UPDATE Tbl_Ogrenciler SET OGRSIFRE = @password WHERE OGRNO=@number ", baglanti);
                    komutSifre.Parameters.AddWithValue("@password", TXT_Sifre_Degistirme.Text.ToString());
                    komutSifre.Parameters.AddWithValue("@number", ogrenciNumarasi);
                    komutSifre.ExecuteNonQuery();
                    baglanti.Close();
                    sifreYeni = TXT_Sifre_Degistirme.Text.ToString();
                    MessageBox.Show(ogrenciNumarasi + " Numaralı Öğrenciye Ait " + sifreEski + " -" + sifreYeni + " İle Değiştirildi");
                }

                if (TXT_Resim_Degistirme.Text!=resimEski)
                {
                    baglanti.Open();
                    SqlCommand komutResim = new SqlCommand("UPDATE Tbl_OgrenciDetay SET OGRESIM=@picture WHERE OGRNO=@number", baglanti);
                    komutResim.Parameters.AddWithValue("@picture", TXT_Resim_Degistirme.Text.ToString());
                    komutResim.Parameters.AddWithValue("@number", ogrenciNumarasi);
                    komutResim.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show(ogrenciNumarasi + " Numaralı Öğrenciye Ait Resim Değiştirildi");


                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Şifre Oluşturunuz.");
            }
        }
    }
}
