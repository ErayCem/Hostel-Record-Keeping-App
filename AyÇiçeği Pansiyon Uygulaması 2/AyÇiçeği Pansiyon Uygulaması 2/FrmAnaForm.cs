using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyÇiçeği_Pansiyon_Uygulaması_2
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMüsteriler frm = new FrmMüsteriler();
            frm.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ay Çiçeği Otel Kayıt Uygulaması /2024 - Bursa");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle frm = new FrmRadyoDinle();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmGazeteler frm = new FrmGazeteler();
            frm.Show();
        }
    }
}