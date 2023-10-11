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
    public partial class FRMBOLUMEKLEMEFORMU : Form
    {
        public FRMBOLUMEKLEMEFORMU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void FRMBOLUMEKLEMEFORMU_Load(object sender, EventArgs e)
        {
            fakulteListesiGetir();
            bolumListesiGetir();
            fakulteKaydiSorgulama();
        }
        void fakulteKaydiSorgulama()
        {
            int fakulteSayisi = CB_FakulteListesi.Items.Count;
            if (fakulteSayisi ==0)
            {
                this.Close();
                MessageBox.Show("Lütfen Bir Fakülte Kayıdı Gerçekleştiriniz");
            }
        }

        void bolumListesiGetir()
        {
            //sqldataAdapter 
            SqlCommand komut = new SqlCommand("select * from Tbl_Bolumler ORDER BY BOLUMNAME ASC", baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adapter.Fill(tablo);
            dataGridView2.DataSource = tablo;
            listeTasarimi();
        }

        void fakulteListesiGetir()
        {
            CB_FakulteListesi.Items.Clear();
            baglanti.Open();
            SqlCommand getir = new SqlCommand("select FAKULTENAME from Tbl_Fakulteler ORDER BY FAKULTENAME ASC", baglanti);
            SqlDataReader dr = getir.ExecuteReader();
            while (dr.Read())
            {
                CB_FakulteListesi.Items.Add(dr["FAKULTENAME"]);
            }
            baglanti.Close();
        }

        private void FRMBOLUMEKLEMEFORMU_Activated(object sender, EventArgs e)
        {
            fakulteListesiGetir();
            bolumListesiGetir();
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
            dataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(17, 28, 43);
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
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.DefaultCellStyle.Font = new Font("segoe UI Semibold", 13);



        }

        int idNo;

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idNo = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            Txt_FakulteName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString().Trim();
            CB_FakulteListesi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString().Trim();

        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            if (Txt_FakulteName.Text!= "" && CB_FakulteListesi.Text!="")
            {
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into Tbl_Bolumler(BOLUMNAME,FAKULTENAME) VALUES (@p1,@p2)", baglanti);
                kayit.Parameters.AddWithValue("@p1", Txt_FakulteName.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p2", CB_FakulteListesi.Text.ToString().ToUpper());
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");
                Txt_FakulteName.Text = "";
                CB_FakulteListesi.Text = "";
                Txt_FakulteName.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (Txt_FakulteName.Text != "" && CB_FakulteListesi.Text != "")
            {
                baglanti.Open();
                SqlCommand guncelle = new SqlCommand("update Tbl_Bolumler SET BOLUMNAME=@p1, FAKULTENAME=@p2 WHERE ID =@p3 ", baglanti);
                guncelle.Parameters.AddWithValue("@p1",Txt_FakulteName.Text.ToString().ToUpper());
                guncelle.Parameters.AddWithValue("@p2",CB_FakulteListesi.Text.ToString().ToUpper());
                guncelle.Parameters.AddWithValue("@p3",idNo);
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Başarılı");
                Txt_FakulteName.Text = "";
                CB_FakulteListesi.Text = "";
                Txt_FakulteName.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            if (Txt_FakulteName.Text != "" && CB_FakulteListesi.Text != "")
            {
                //DialogResult Silme işlemi gerçekleştirilirken emin olup olmadığımızı kontrol etmek için kullanılır
                DialogResult result = MessageBox.Show("Silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("delete from Tbl_Bolumler WHERE ID =@p1", baglanti);
                    sil.Parameters.AddWithValue("@p1", idNo);
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Silme İşlemi Başarılı");
                    Txt_FakulteName.Text = "";
                    CB_FakulteListesi.Text = "";
                    Txt_FakulteName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
        }
    }
}
