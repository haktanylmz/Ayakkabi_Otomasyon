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
    
    public partial class Malzeme : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());

        public Malzeme()
        {
            InitializeComponent();
        }

        private void Malzeme_Load(object sender, EventArgs e)
        {
            LoadGridView();
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
        }
        void resimekle()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {
            resimekle();
        }
        private void btnresimkapat_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Urun_Malzeme", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Urun_Malzeme");
            dataGridView1.DataSource = ds.Tables["Urun_Malzeme"];
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["Fotograf"].Visible = false;
            dataGridView1.Refresh();
            con.Close();
        }
        void ClearTextBoxes()
        {
            pictureBox1.Image = null;
            cmbcilt.Text = "";
            cmbcilt.SelectedIndex = -1;
            cmbcilt.Items.Clear();
            txttaban.Text = "";
            txtrenk.Text = "";
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }
        void eklebutonu()
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation)
                && !string.IsNullOrEmpty(cmbcilt.Text)
                && !string.IsNullOrEmpty(txttaban.Text)
                && !string.IsNullOrEmpty(txtrenk.Text))
            {
                try
                {
                    string queryadd = "INSERT INTO Urun_Malzeme(Fotograf,Cilt,Taban,Renk)VALUES(@Fotograf,@Cilt,@Taban,@Renk)";

                    OleDbCommand cmd = new OleDbCommand(queryadd, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
                    cmd.Parameters.AddWithValue("@Cilt", cmbcilt.Text);
                    cmd.Parameters.AddWithValue("@Taban", txttaban.Text);
                    cmd.Parameters.AddWithValue("@Renk", txtrenk.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    ClearTextBoxes();
                    LoadGridView();

                    MessageBox.Show("İşlem Başarı ile Tamamlanmıştır.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("hata: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void guncellebutonu()
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation)
                && !string.IsNullOrEmpty(cmbcilt.Text)
                && !string.IsNullOrEmpty(txttaban.Text)
                && !string.IsNullOrEmpty(txtrenk.Text))
            {
                
                if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string queryupdate = "UPDATE Urun_Malzeme SET Fotograf=@Fotograf,Cilt=@Cilt,Taban=@Taban,Renk=@Renk WHERE ID=@ID";
                        OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                        cmd.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
                        cmd.Parameters.AddWithValue("@Cilt", cmbcilt.Text);
                        cmd.Parameters.AddWithValue("@Taban", txttaban.Text);
                        cmd.Parameters.AddWithValue("@Renk", txtrenk.Text);
                        cmd.Parameters.AddWithValue("@ID", txtid.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ClearTextBoxes();
                        LoadGridView();
                        MessageBox.Show("Güncelleme İşlemi Başarılı", "Başarılı İşlem", MessageBoxButtons.OK);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hatalı İşlem", hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void silbutonu()
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation)
                && !string.IsNullOrEmpty(cmbcilt.Text)
                && !string.IsNullOrEmpty(txttaban.Text)
                && !string.IsNullOrEmpty(txtrenk.Text))
            {
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM Urun_Malzeme WHERE ID=?", con);
                        cmd.Parameters.Add("DELETE", OleDbType.Integer).Value = dataGridView1.CurrentRow.Cells[0].Value;
                        cmd.ExecuteNonQuery();
                        
                        con.Close();
                        ClearTextBoxes();
                        LoadGridView();
                        MessageBox.Show("Silme İşlemi Başarı İle Gerçekleşmiştir.", "Başarılı İşlem", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HATA :" + ex);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void cmbciltgetir()
        {
            con.Open();
            cmbcilt.Text = "";
            cmbcilt.SelectedIndex = -1;
            cmbcilt.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("Select Cilt From Urun_Cilt Order By ID", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                cmbcilt.Items.Add(read["Cilt"]);
            }
            con.Close();
        }
        void ara()
        {
            con.Open();
            DataTable tbl = new DataTable();

            OleDbDataAdapter ara = new OleDbDataAdapter("Select * from Urun_Malzeme where Cilt like '%" + txtara.Text + "%'", con);
            ara.Fill(tbl);
            con.Close();
            dataGridView1.DataSource = tbl;
        }

        private void cmbcilt_DropDown(object sender, EventArgs e)
        {
            cmbciltgetir();
        }        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbcilt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttaban.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtrenk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }
        private void txtara_TextChanged(object sender, EventArgs e)
        {
            ara();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            eklebutonu();
        }
        private void btnguncelle_Click(object sender, EventArgs e)
        {
            guncellebutonu();
        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            silbutonu();
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void Stok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
