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
    public partial class FRMEGITIMCIBILGIGUNCELLEME : Form
    {
        public FRMEGITIMCIBILGIGUNCELLEME()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");

        private void Btn_Cikis_Yap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string egitimciNumarasi;

        private void FRMEGITIMCIBILGIGUNCELLEME_Load(object sender, EventArgs e)
        {
            egitimciSifreveResimBirlikteGetir();
        }
        string sifreEski, resimYeni, sifreYeni, resimEski;
        void egitimciSifreveResimBirlikteGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Tbl_Egitimciler.EGISIFRE, Tbl_EgitimciDetay.EGIRESIM FROM Tbl_Egitimciler inner join Tbl_EgitimciDetay ON Tbl_Egitimciler.EGINO=Tbl_EgitimciDetay.EGINO WHERE Tbl_Egitimciler.EGINO=@egitimciNumarasiLazim  ", baglanti);
            komut.Parameters.AddWithValue("@egitimciNumarasiLazim", egitimciNumarasi);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sifreEski = oku["EGISIFRE"].ToString();

                TXT_Sifre_Degistirme.Text = oku["EGISIFRE"].ToString();
                TXT_Resim_Degistirme.Text = oku["EGIRESIM"].ToString();
                PB_Egitimci_Resim.ImageLocation = oku["EGIRESIM"].ToString();
            }
            baglanti.Close();
        }

        private void BTN_Guncelle_MouseMove(object sender, MouseEventArgs e)
        {
            BTN_Guncelle.BackColor = Color.Green;

        }

        private void BTN_Guncelle_MouseLeave(object sender, EventArgs e)
        {
            BTN_Guncelle.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void PB_Ressim_Ekle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme Ekranı";
            ofd.Filter = "PNG | *.png | JPG | *.jpg;*.jpeg | All Files | *.* ";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TXT_Resim_Degistirme.Text = ofd.FileName;
                PB_Egitimci_Resim.Image = new Bitmap(ofd.FileName);
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi.");
            }
        }

        private void BTN_Guncelle_Click(object sender, EventArgs e)
        {
            ogrenciSifreveResimGuncelle();

        }
        void ogrenciSifreveResimGuncelle()
        {
            if (TXT_Sifre_Degistirme.Text != "")
            {

                if (TXT_Sifre_Degistirme.Text != sifreEski)
                {
                    baglanti.Open();
                    SqlCommand komutSifre = new SqlCommand("UPDATE Tbl_Egitimciler SET EGISIFRE = @password WHERE EGINO=@number ", baglanti);
                    komutSifre.Parameters.AddWithValue("@password", TXT_Sifre_Degistirme.Text.ToString());
                    komutSifre.Parameters.AddWithValue("@number", egitimciNumarasi);
                    komutSifre.ExecuteNonQuery();
                    baglanti.Close();
                    sifreYeni = TXT_Sifre_Degistirme.Text.ToString();
                    MessageBox.Show(egitimciNumarasi + " Numaralı Eğitimciye Ait " + sifreEski + " -" + sifreYeni + " İle Değiştirildi");
                }

                if (TXT_Resim_Degistirme.Text != resimEski)
                {
                    baglanti.Open();
                    SqlCommand komutResim = new SqlCommand("UPDATE Tbl_EgitimciDetay SET EGIRESIM=@picture WHERE EGINO=@number", baglanti);
                    komutResim.Parameters.AddWithValue("@picture", TXT_Resim_Degistirme.Text.ToString());
                    komutResim.Parameters.AddWithValue("@number", egitimciNumarasi);
                    komutResim.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show(egitimciNumarasi + " Numaralı Eğitimciye Ait Resim Değiştirildi");


                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Şifre Oluşturunuz.");
            }
        }
    }
}
