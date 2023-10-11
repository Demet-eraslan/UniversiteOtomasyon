using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //SQL Kütüphanesi


namespace UniversiteOtomasyonuV1
{
    public partial class FrmOgrenciGiris : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");
        

        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtSifre.UseSystemPasswordChar ==true)
            {
                TxtSifre.UseSystemPasswordChar = false;

            }
            else
            {
                TxtSifre.UseSystemPasswordChar = true;
            }
        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        { 
            GuvenlikKoduOlustur();
        }

        void GuvenlikKoduOlustur()
        {
            Random rastgele = new Random();
            string karakterler = "0123456789qwertyuýopðüasdfghjklþizxcvbnmöçQWERTYUIOPÐÜASDFGHJKLÞÝZXCVBNMÖÇ";
            string olustur = "";

            for (int i = 0; i < 6; i++)
            {
                olustur += karakterler[rastgele.Next(karakterler.Length)]; 

            }
            LblGuvenlikKodu.Text = olustur.ToString();

        }

        private void PbDegistir_Click(object sender, EventArgs e)
        {
            GuvenlikKoduOlustur();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtOgrNo.Text != "" && TxtSifre.Text!="" && TxtGuvenlik.Text !="")
            {
                if (TxtOgrNo.TextLength<10)
                {
                    MessageBox.Show("Öðrenci Numarasý 10 Karakter Olmalýdýr.");

                }
                else
                {
                    if (TxtGuvenlik.Text==LblGuvenlikKodu.Text)
                    {
                        //Sql Tabnlý Kullanýcý Giriþ Ýþlemleri
                        //Select
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogrenciler WHERE OGRNO=@P1 AND OGRSIFRE=@P2",baglanti);
                        komut.Parameters.AddWithValue("@P1",TxtOgrNo.Text);
                        komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read()) // okuma baþarýlýysa: Veritabanýndaki bilgiler doðru girildiðini gösterir
                        {
                            //MessageBox.Show(oku["OGRAD"].ToString() + " " + oku["OGRSOYAD"].ToString());

                            string ogrenciAdi = oku["OGRAD"].ToString();
                            string ogrenciSoyadi = oku["OGRSOYAD"].ToString();
                            string ogrenciNumarasi = oku["OGRNO"].ToString();
                            //Bu alanlarý kullanacaðýz.

                            FRMOGRENCIANAFORM frm = new FRMOGRENCIANAFORM();
                            frm.ogrencininAdi = ogrenciAdi;
                            frm.ogrencininSoyadi = ogrenciSoyadi;
                            frm.ogrencininNumarasi = ogrenciNumarasi;
                            frm.Show();
                            this.Hide();// Üzerinde Bulunduðumuz formu gizler(hide yapar).
                            //this.Close(); // Üzerinde Bulunduðumuz Formu Kapatýr.
                            //Application.Exit(); //Tüm Programý Kapatýr.


                        }
                        else
                        {
                            MessageBox.Show("Öðrenci Kaydý Bulunamadý");
                        }


                        baglanti.Close();

                    }
                    else
                    {
                        MessageBox.Show("Güvenlik Kodunu Doðru Giriniz!");
                        // Giriþ Ýþlemlerimizi Bu Kýsýmda Gerçekleþtireceðiz.
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanlarý Boþ Geçmeyiniz");
                
            }
        }

        private void BtnGirisYap_MouseMove(object sender, MouseEventArgs e)
        {
            BtnGirisYap.BackColor = System.Drawing.ColorTranslator.FromHtml("#26A749");
        }
         
        private void BtnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = System.Drawing.ColorTranslator.FromHtml("#111C2B");

        }
    }
}