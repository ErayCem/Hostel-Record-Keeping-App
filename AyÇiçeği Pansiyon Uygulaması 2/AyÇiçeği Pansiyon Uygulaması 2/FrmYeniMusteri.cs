using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace AyÇiçeği_Pansiyon_Uygulaması_2
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ERAYCEM\MSSQLSERVER01;Initial Catalog=AyCicegiPansiyon;Integrated Security=True");

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Dolu Odaları Gösterir.");

        }

        private void MskTxtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);
            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();
            Ucret=Convert.ToInt32(label11.Text)*50;
            TxtUcret.Text=Ucret.ToString();

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text+ "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" +TxtOdaNo.Text + "','" +TxtUcret.Text + "','" +DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" +DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
      komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kayıtı Yapıldı.");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            string[] odaNumaralari = { "101", "102", "103", "104", "105", "106", "107", "108", "109" };
            Button[] odaButonlari = { BtnOda101, BtnOda102, BtnOda103, BtnOda104, BtnOda105, BtnOda106, BtnOda107, BtnOda108, BtnOda109 };

            for (int i = 0; i < odaNumaralari.Length; i++)
            {
                string odaNo = odaNumaralari[i];
                Button odaButonu = odaButonlari[i];

                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT Adi, Soyadi FROM MusteriEkle WHERE OdaNo=@OdaNo", baglanti);
                    komut.Parameters.AddWithValue("@OdaNo", odaNo);
                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        odaButonu.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                        odaButonu.BackColor = Color.Red;
                        odaButonu.Enabled = false; // Dolu odalar için butonu devre dışı bırak
                    }
                    else
                    {
                        odaButonu.Text = odaNo;
                        odaButonu.BackColor = Color.Green; // Oda boşsa yeşil yapıyoruz
                        odaButonu.Enabled = true; // Boş odalar için butonu etkinleştir
                    }

                    baglanti.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }
        }


    }
}





























//Data Source=ERAYCEM\MSSQLSERVER01;Initial Catalog=AyCicegiPansiyon;Integrated Security=True;Trust Server Certificate=True

