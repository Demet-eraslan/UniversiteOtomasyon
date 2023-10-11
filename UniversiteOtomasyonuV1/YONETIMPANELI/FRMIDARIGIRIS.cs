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

namespace UniversiteOtomasyonuV1.YONETIMPANELI
{
    public partial class FRMIDARIGIRIS : Form
    {
        public FRMIDARIGIRIS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtIKSifre.UseSystemPasswordChar == false)
            {
                TxtIKSifre.UseSystemPasswordChar = true;
            }
            else
            {
                TxtIKSifre.UseSystemPasswordChar = false;
            }
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtIKNo.Text != "" && TxtIKSifre.Text != "" && TxtGuvenlik.Text != "")
            {
                if (TxtIKNo.TextLength < 10)
                {
                    MessageBox.Show("İdareci Numarası 10 Karakter Olmalıdır.");

                }
                else
                {
                    if (TxtGuvenlik.Text == LblGuvenlikKodu.Text) //Güvenlik Kodunu Kontrol edecek
                    {
                        //Güvenlik Kodu doğru ise gerçekleştrilecek işlemler.
                        //Select
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("select * from Tbl_IdariKisiler where IKNO=@p1 AND IKSIFRE =@p2", baglanti);
                        komut.Parameters.AddWithValue("@p1", TxtIKNo.Text);
                        komut.Parameters.AddWithValue("@p2", TxtIKSifre.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read()) // okuma başarılıysa: Veritabanındaki bilgiler doğru girildiğini gösterir
                        {
                            //MessageBox.Show(oku["OGRAD"].ToString() + " " + oku["OGRSOYAD"].ToString());

                            string idariKisiNo = oku["IKNO"].ToString();
                            string idariKisiAdi = oku["IKAD"].ToString();
                            string idariKisiSoyadi = oku["IKSOYAD"].ToString();

                            YONETIMPANELI.FRMIDARIANAFORMU frm = new YONETIMPANELI.FRMIDARIANAFORMU();
                            frm.idariKisininNumarasi = idariKisiNo;
                            frm.idariKisininAdi = idariKisiAdi;
                            frm.idariKisininSoyadi = idariKisiSoyadi;
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

        private void PbDegistir_Click(object sender, EventArgs e)
        {
            GuvenlikKoduOlustur();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGirisYap_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGirisYap.BackColor = Color.Green;
        }

        private void BtnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.FromArgb(17, 28, 43);        }

        private void FRMIDARIGIRIS_Load(object sender, EventArgs e)
        {
            GuvenlikKoduOlustur();
        }
    }
}
