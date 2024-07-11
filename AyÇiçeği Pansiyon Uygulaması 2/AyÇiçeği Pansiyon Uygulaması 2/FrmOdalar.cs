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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=ERAYCEM\MSSQLSERVER01;Initial Catalog=AyCicegiPansiyon;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
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
                    }
                    else
                    {
                        odaButonu.Text = odaNo;
                        odaButonu.BackColor = Color.Green; // Oda boşsa yeşil yapıyoruz
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
