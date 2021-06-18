using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Ayakkabi_Otomasyon
{

    public partial class Menu : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            lblkullaniciad.Text = "";
            lblkullaniciad.Text = Giris.username;
            timer1.Start();
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris Giris = new Giris();
            Giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Malzeme malzeme = new Malzeme();
            malzeme.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.Show();
            this.Hide();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
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
            Model model = new Model();
            model.Show();
            this.Hide();
        }

        private void StokTSMI_Click(object sender, EventArgs e)
        {
            Malzeme malzeme = new Malzeme();
            malzeme.Show();
            this.Hide();
        }

        private void KullaniciTSMI_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Show();
            this.Hide();
        }

        private void satisTSMI_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis();
            satis.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            timer1.Stop();
        }

        private void btnMusteriPanel_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            this.Hide();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.Show();
            this.Hide();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele_Model listelemodel = new Listele_Model();
            listelemodel.Show();
            this.Hide();
        }
        private void satışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listele_Satis listelesatis = new Listele_Satis();
            listelesatis.Show();
            this.Hide();
        }
        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listele_Stok listelestok = new Listele_Stok();
            listelestok.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
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
