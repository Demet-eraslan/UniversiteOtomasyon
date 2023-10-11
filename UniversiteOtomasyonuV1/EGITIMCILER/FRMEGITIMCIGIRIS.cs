using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UniversiteOtomasyonuV1.EGITIMCILER
{
    public partial class FRMEGITIMCIGIRIS : Form
    {
        public FRMEGITIMCIGIRIS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar == true)
            {
                TxtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        void GuvenlikKoduOlustur()
        {
            Random rastgele = new Random();
            string karakterler = "0123456789qwertyuıopğüasdfghjklşizxcvbnmöçQWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ";
            string olustur = "";


            for (int i = 0; i < 5; i++)
            {
                olustur += karakterler[rastgele.Next(karakterler.Length)];
            }
            LblGuvenlikKodu.Text = olustur.ToString();
            TxtGuvenlik.Text = olustur.ToString();
        }


        private void FRMEGITIMCIGIRIS_Load(object sender, EventArgs e)
        {
            GuvenlikKoduOlustur();
        }

        private void PbDegistir_Click(object sender, EventArgs e)
        {
            GuvenlikKoduOlustur();
        }

        private void BtnGirisYap_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGirisYap.BackColor = Color.FromArgb(38, 167, 73);

        }

        private void BtnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtEgiNo.Text != "" && TxtSifre.Text != "" && TxtGuvenlik.Text != "")
            {
                if (TxtEgiNo.TextLength < 10)
                {
                    MessageBox.Show("Eğitimci Numarası 10 Karakter Olmalıdır.");

                }
                else
                {
                    if (TxtGuvenlik.Text == LblGuvenlikKodu.Text) //Güvenlik Kodunu Kontrol edecek
                    {
                        //Güvenlik Kodu doğru ise gerçekleştrilecek işlemler.
                        //Select
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("select * from Tbl_Egitimciler where EGINO=@egitimcinumarasi AND EGISIFRE = @egitimciSifre", baglanti);
                        komut.Parameters.AddWithValue("@egitimcinumarasi", TxtEgiNo.Text);
                        komut.Parameters.AddWithValue("@egitimciSifre", TxtSifre.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read()) // okuma başarılıysa: Veritabanındaki bilgiler doğru girildiğini gösterir
                        {
                            //MessageBox.Show(oku["OGRAD"].ToString() + " " + oku["OGRSOYAD"].ToString());

                            string egitimciNo = oku["EGINO"].ToString();
                            string egitimciAdi = oku["EGIAD"].ToString();
                            string egitimciSoyadi = oku["EGISOYAD"].ToString();
                            string egitimciUnvan = oku["EGIUNVAN"].ToString();

                            //Bu alanları kullanacağız.

                            //MessageBox.Show("Eğitimcinin Numarası:" + egitimciNo + " " +
                            //    "Eğitimcinin Ünvanı:" + egitimciUnvan + " " +
                            //    "Eğitimcinin Adı:" + egitimciAdi + 
                            //    "Eğitimcinin Soyadı:" + egitimciSoyadi);

                            //Form yönlendirme, form açma
                            EGITIMCILER.FRMEGITIMCIANAFORM frm = new EGITIMCILER.FRMEGITIMCIANAFORM();
                            frm.egitimcininUnvani = egitimciUnvan;
                            frm.egitimcininAdi = egitimciAdi;
                            frm.egitimcininSoyadi = egitimciSoyadi;
                            frm.egitimcininNumarasi = egitimciNo;

                            frm.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Eğitimci Kaydı Bulunamadı");
                        }


                        baglanti.Close();

                    }
                    else
                    {
                        MessageBox.Show("Güvenlik Kodunu Doğru Giriniz!");
                        // Giriş İşlemlerimizi Bu Kısımda Gerçekleştireceğiz.
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz");

            }
        }

    }
}
