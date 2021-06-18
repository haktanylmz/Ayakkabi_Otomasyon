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
    public partial class Satis_Listele : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());

        public Satis_Listele()
        {
            InitializeComponent();
        }

        private void Satis_Listele_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Satis", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Satis");
            dataGridView1.DataSource = ds.Tables["Satis"];
            dataGridView1.Refresh();
            con.Close();
        }

        private void Satis_Listele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
