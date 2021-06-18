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
    public partial class Listele_Model : Form
    {
        //Database Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public Listele_Model()
        {
            InitializeComponent();
        }

        private void Listele_Model_Load(object sender, EventArgs e)
        {
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
            LoadGridView();
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Model", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Model");
            dataGridView1.DataSource = ds.Tables["Model"];
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
    }
}
