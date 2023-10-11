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
    public partial class FRMFAKULTEEKLEMEFORMU : Form
    {
        public FRMFAKULTEEKLEMEFORMU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // açık olan formu kapar
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=UniversiteOtomasyonuVT;Integrated Security=True");

        private void Btn_Kaydet_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_Kaydet.BackColor = Color.Green;
        }

        private void Btn_Kaydet_MouseLeave(object sender, EventArgs e)
        {
            Btn_Kaydet.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void Btn_Guncelle_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_Guncelle.BackColor = Color.Green;
        }

        private void Btn_Guncelle_MouseLeave(object sender, EventArgs e)
        {
            Btn_Guncelle.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void Btn_Sil_MouseMove(object sender, MouseEventArgs e)
        {
            Btn_Sil.BackColor = Color.Green;
        }

        private void Btn_Sil_MouseLeave(object sender, EventArgs e)
        {
            Btn_Sil.BackColor = Color.FromArgb(17, 28, 43);
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //input Kontrolü
            if (Txt_FakulteName.Text != "")
            {
                //textbox boş değilse yapılacak işlemler:
                //sql komutları arasında bulunan ya da var olan INSERT INTO komutu veritabanına ekleme işlemi gerçekleştiren komut cümlesidir
                // insert into tablo_adi () values () where 
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into Tbl_Fakulteler (FAKULTENAME) VALUES (@p1)", baglanti);
                ekle.Parameters.AddWithValue("@p1", Txt_FakulteName.Text.ToString().ToUpper());
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarlı Bir Şekilde Gerçekleştirildi");
                Txt_FakulteName.Clear();
                Txt_FakulteName.Focus();

                fakulteSayisiArtir();


            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz.");
            }
        }
        void fakulteSayisiArtir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_UniversiteBilgi set UNIFAKULTESAYISI +=1", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (Txt_FakulteName.Text!="") //null değilse
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update Tbl_Fakulteler set FAKULTENAME=@p1 WHERE ID=@p2", baglanti);
                guncelle.Parameters.AddWithValue("@p1", Txt_FakulteName.Text.ToString().ToUpper());
                guncelle.Parameters.AddWithValue("@p2", idNo.ToString());
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı");
                Txt_FakulteName.Clear();
                Txt_FakulteName.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz.");
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            //Silme işlemini Delete komutu ile gerçekleştiriyoruz
            //Delete From Tablo_Adi where silinmekistenen_kayıt

            DialogResult silmeMesaji = MessageBox.Show("Silmek İstedğinize Emin misiniz?" ,"UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (silmeMesaji==DialogResult.Yes)
            {
                //Silme İşlemini Gerçekleştir
                if (Txt_FakulteName.Text != "")
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete From Tbl_Fakulteler WHERE ID=@p1", baglanti);
                    sil.Parameters.AddWithValue("@p1", idNo.ToString());
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem Başarılı");
                    Txt_FakulteName.Clear();
                    Txt_FakulteName.Focus();

                    fakulteSayisiAzalt();
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Değer Giriniz");
                }
            }
        }
        void fakulteSayisiAzalt()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_UniversiteBilgi set UNIFAKULTESAYISI -=1", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        private void FRMFAKULTEEKLEMEFORMU_Load(object sender, EventArgs e)
        {
            fakulteListesiGetir();
        }
        void fakulteListesiGetir()
        {
            //Veri Çeke işlemini bu metodda gerçekleştireceğiz.
           // baglanti.Open(); baglanti kurma işini adapter yapıyo
           //dataset ve datatable verileri sanal bir tablo ile saklayıyo
           //DATASET(veritabanını tümüyle barındırmaya yarıyo) DATATABLE(sadece bir adet tabloyu içerisinde barındırıyo)
            // fiil = doldurma anlamına geliyor
            //order by = sıralama işlemi yapmaya yarayan kod
            //ASC= Alfabetik sıralama yapyor
            //DESC = ters alfabetik sıralama
            SqlCommand komut = new SqlCommand("select * from Tbl_Fakulteler ORDER BY FAKULTENAME ASC", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);

            dataGridView2.DataSource = tablo;

            listeTasarimi();

        }
        void listeTasarimi()
        {
            //Satırların Yükseklğini bir döngü kullanarak yapacağız Foreach döngüsü kullanacağız.

            foreach (DataGridViewRow rows in dataGridView2.Rows)
            {
                rows.Height = 35;
            }

            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.DefaultCellStyle.BackColor = Color.White;
            dataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(17,28,43);
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Columns[0].Visible=false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.DefaultCellStyle.Font = new Font("segoe UI Semibold", 13); 



        }

        private void FRMFAKULTEEKLEMEFORMU_Activated(object sender, EventArgs e)
        {
            fakulteListesiGetir();
        }

        int idNo;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // TRİM= var olan alandaki boş karakterleri boş sayıyor 
            idNo = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            Txt_FakulteName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString().ToUpper().Trim();
        }

       
    }
}
