using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayakkabi_Otomasyon
{
    public partial class Listele_Stok : Form
    {
        //Database Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public Listele_Stok()
        {
            InitializeComponent();
        }
        private void Listele_Stok_Load(object sender, EventArgs e)
        {
            LoadGridView();
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Urun_Stok", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Urun_Stok");
            dataGridView1.DataSource = ds.Tables["Urun_Stok"];
            this.dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Refresh();
            con.Close();
        }
        
    }
}
