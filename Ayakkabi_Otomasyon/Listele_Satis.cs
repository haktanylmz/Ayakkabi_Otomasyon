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

namespace Ayakkabi_Otomasyon
{
    public partial class Listele_Satis : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());

        public Listele_Satis()
        {
            InitializeComponent();
        }

        private void Satis_Listele_Load(object sender, EventArgs e)
        {
            LoadGridView();
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
            timer1.Start();
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Satis Order By ID ASC", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Satis");
            dataGridView1.DataSource = ds.Tables["Satis"];
            this.dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Refresh();
            con.Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblsaat_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
