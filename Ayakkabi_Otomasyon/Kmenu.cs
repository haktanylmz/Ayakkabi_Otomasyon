using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayakkabi_Otomasyon
{
    public partial class Kmenu : Form
    {
        public Kmenu()
        {
            InitializeComponent();
        }

        private void Kmenu_Load(object sender, EventArgs e)
        {
            lblkullaniciad.Text = "";
            lblkullaniciad.Text = Giris.username;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void menuTSMI_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }

        private void modelTSMI_Click(object sender, EventArgs e)
        {
            Model modeller = new Model();
            modeller.Show();
            this.Hide();
        }

        private void StokTSMI_Click(object sender, EventArgs e)
        {
            Malzeme malzeme = new Malzeme();
            malzeme.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model modeller = new Model();
            modeller.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Malzeme malzeme = new Malzeme();
            malzeme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
            this.Hide();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
            this.Hide();
        }

        private void Kmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            timer1.Stop();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele_Model lm = new Listele_Model();
            lm.Show();
            this.Hide();
        }

        private void satışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listele_Satis ls = new Listele_Satis();
            ls.Show();
            this.Hide();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele_Stok lstok = new Listele_Stok();
            lstok.Show();
            this.Hide();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.Show();
            this.Hide();
        }

        private void stokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stok stok = new Stok();
            stok.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
