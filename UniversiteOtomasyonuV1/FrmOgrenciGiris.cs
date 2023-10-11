using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //SQL K�t�phanesi


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
            string karakterler = "0123456789qwertyu�op��asdfghjkl�izxcvbnm��QWERTYUIOP��ASDFGHJKL��ZXCVBNM��";
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
                    MessageBox.Show("��renci Numaras� 10 Karakter Olmal�d�r.");

                }
                else
                {
                    if (TxtGuvenlik.Text==LblGuvenlikKodu.Text)
                    {
                        //Sql Tabnl� Kullan�c� Giri� ��lemleri
                        //Select
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Ogrenciler WHERE OGRNO=@P1 AND OGRSIFRE=@P2",baglanti);
                        komut.Parameters.AddWithValue("@P1",TxtOgrNo.Text);
                        komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
                        SqlDataReader oku = komut.ExecuteReader();

                        if (oku.Read()) // okuma ba�ar�l�ysa: Veritaban�ndaki bilgiler do�ru girildi�ini g�sterir
                        {
                            //MessageBox.Show(oku["OGRAD"].ToString() + " " + oku["OGRSOYAD"].ToString());

                            string ogrenciAdi = oku["OGRAD"].ToString();
                            string ogrenciSoyadi = oku["OGRSOYAD"].ToString();
                            string ogrenciNumarasi = oku["OGRNO"].ToString();
                            //Bu alanlar� kullanaca��z.

                            FRMOGRENCIANAFORM frm = new FRMOGRENCIANAFORM();
                            frm.ogrencininAdi = ogrenciAdi;
                            frm.ogrencininSoyadi = ogrenciSoyadi;
                            frm.ogrencininNumarasi = ogrenciNumarasi;
                            frm.Show();
                            this.Hide();// �zerinde Bulundu�umuz formu gizler(hide yapar).
                            //this.Close(); // �zerinde Bulundu�umuz Formu Kapat�r.
                            //Application.Exit(); //T�m Program� Kapat�r.


                        }
                        else
                        {
                            MessageBox.Show("��renci Kayd� Bulunamad�");
                        }


                        baglanti.Close();

                    }
                    else
                    {
                        MessageBox.Show("G�venlik Kodunu Do�ru Giriniz!");
                        // Giri� ��lemlerimizi Bu K�s�mda Ger�ekle�tirece�iz.
                    }
                }
            }
            else
            {
                MessageBox.Show("Alanlar� Bo� Ge�meyiniz");
                
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