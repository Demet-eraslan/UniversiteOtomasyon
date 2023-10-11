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
    public partial class FRMREKTORADIDEGISTIR : Form
    {
        public FRMREKTORADIDEGISTIR()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMREKTORADIDEGISTIR_Load(object sender, EventArgs e)
        {
            BilgiGetirmeMetodu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Güncelleme işlemlerini burada yapacağız güncelleme için ise update komutunu kullanacağız
            baglanti.Open();
            SqlCommand update = new SqlCommand("UPDATE Tbl_UniversiteBilgi SET UNIREKTOR=@p1 where ID=1   ", baglanti);// UPDATE Tablo_Adi SET Değiştirilecek_alanAdi where ID  
            update.Parameters.AddWithValue("@p1", Txt_RektorName.Text.ToString().ToUpper());
            //ToUpper komutu: var olan tüm karakterleri büyük karakterlere veya büyük harflere çevirir
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başaralı");
            BilgiGetirmeMetodu();

        }
        void BilgiGetirmeMetodu()
        {
            //veritabanında olan kaydı çekip textbox a yazdıracağız.
            //veri çekme işlemi gerçekleştireceğiz(Select Komutu kullanarak yapacağız);

            baglanti.Open();
            SqlCommand getir = new SqlCommand("select  UNIREKTOR from Tbl_UniversiteBilgi where ID=1", baglanti);
            SqlDataReader oku = getir.ExecuteReader();
            while (oku.Read())
            {
                // MessageBox.Show(oku["UNIREKTOR"].ToString());
                Txt_RektorName.Text = oku["UNIREKTOR"].ToString();


            }
            baglanti.Close();
        }
    }
}
