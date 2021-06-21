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
    public partial class Stok : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public Stok()
        {
            InitializeComponent();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
            LoadGridView();
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
        private void Stok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }
        void ClearTextBoxes()
        {
            txtID.Text = "";
            cmbTip.Text = "";
            txtAd.Text = "";
            txtAdet.Text = "";
            txtDesi.Text = "";
            this.dataGridView1.ClearSelection();
        }
        void eklebutonu()
        {
            if (txtDesi.Visible==true)
            {
                if (!string.IsNullOrEmpty(cmbTip.Text)
                    && !string.IsNullOrEmpty(txtAd.Text)
                    && !string.IsNullOrEmpty(txtAdet.Text)
                    && !string.IsNullOrEmpty(txtDesi.Text))
                {
                    try
                    {
                        string queryadd = "INSERT INTO Urun_Stok(Malzeme_Tipi,Malzeme_Ad,Adet,Desi)VALUES(@Malzeme_Tipi,@Malzeme_Ad,@Adet,@Desi)";

                        OleDbCommand cmd = new OleDbCommand(queryadd, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@Malzeme_Tipi", cmbTip.Text);
                        cmd.Parameters.AddWithValue("@Malzeme_Ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@Adet", txtAdet.Text);
                        cmd.Parameters.AddWithValue("@Desi", txtDesi.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        ClearTextBoxes();
                        LoadGridView();

                        MessageBox.Show("İşlem Başarı ile Tamamlanmıştır.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(cmbTip.Text)
                   && !string.IsNullOrEmpty(txtAd.Text)
                   && !string.IsNullOrEmpty(txtAdet.Text))
                {
                    try
                    {
                        string queryadd = "INSERT INTO Urun_Stok(Malzeme_Tipi,Malzeme_Ad,Adet)VALUES(@Malzeme_Tipi,@Malzeme_Ad,@Adet)";

                        OleDbCommand cmd = new OleDbCommand(queryadd, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@Malzeme_Tipi", cmbTip.Text);
                        cmd.Parameters.AddWithValue("@Malzeme_Ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@Adet", txtAdet.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        ClearTextBoxes();
                        LoadGridView();

                        MessageBox.Show("İşlem Başarı ile Tamamlanmıştır.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Hata: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
        void guncellebutonu()
        {
            if (txtDesi.Visible == true)
            {
                if (!string.IsNullOrEmpty(cmbTip.Text)
                    && !string.IsNullOrEmpty(txtAd.Text)
                    && !string.IsNullOrEmpty(txtAdet.Text)
                    && !string.IsNullOrEmpty(txtDesi.Text))
                {
                    if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            string queryupdate = "UPDATE Urun_Stok SET Malzeme_Tipi=@Malzeme_Tipi,Malzeme_Ad=@Malzeme_Ad,Adet=@Adet,Desi=@Desi WHERE ID=@ID";
                            OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                            cmd.Parameters.AddWithValue("@Malzeme_Tipi", cmbTip.Text);
                            cmd.Parameters.AddWithValue("@Malzeme_Ad", txtAd.Text);
                            cmd.Parameters.AddWithValue("@Adet", txtAdet.Text);
                            cmd.Parameters.AddWithValue("@Desi", txtDesi.Text);
                            cmd.Parameters.AddWithValue("@ID", txtID.Text);
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
            else
            {
                if (!string.IsNullOrEmpty(cmbTip.Text)
                   && !string.IsNullOrEmpty(txtAd.Text)
                   && !string.IsNullOrEmpty(txtAdet.Text))
                {
                    if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            string queryupdate = "UPDATE Urun_Stok SET Malzeme_Tipi=@Malzeme_Tipi,Malzeme_Ad=@Malzeme_Ad,Adet=@Adet,Desi=@Desi WHERE ID=@ID";
                            OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                            cmd.Parameters.AddWithValue("@Malzeme_Tipi", cmbTip.Text);
                            cmd.Parameters.AddWithValue("@Malzeme_Ad", txtAd.Text);
                            cmd.Parameters.AddWithValue("@Adet", txtAdet.Text);
                            cmd.Parameters.AddWithValue("@Desi", txtDesi.Text);
                            cmd.Parameters.AddWithValue("@ID", txtID.Text);
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
            
        }
        void silbutonu()
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM Model WHERE ID=?", con);
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



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            cmbTip.Text = dataGridView1.CurrentRow.Cells["Malzeme_Tipi"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["Malzeme_Ad"].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();
            txtDesi.Text = dataGridView1.CurrentRow.Cells["Desi"].Value.ToString();
        }

        private void cmbTip_DropDown(object sender, EventArgs e)
        {
            try
            {
                cmbTip.Text = "";
                cmbTip.SelectedIndex = -1;
                cmbTip.Items.Clear();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Malzeme_Tipi FROM Urun_Stok_Malzeme_Tip", con);
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cmbTip.Items.Add(read["Malzeme_Tipi"]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme Tipi Getirmede Sorun Var: " + ex);
            }
        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.Text == "Deri")
            {
                txtDesi.Visible = true;
                lblDesi.Visible = true;
            }
            else
            {
                txtDesi.Visible = false;
                lblDesi.Visible = false;
            }
            if (cmbTip.Text == "")
            {
                txtDesi.Visible = false;
                lblDesi.Visible = false;
                txtDesi.Text = "";
            }
        }

        private void cmbTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = char.IsLetterOrDigit(e.KeyChar))
            {
                MessageBox.Show("Değer Girilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cmbTip_TextChanged(object sender, EventArgs e)
        {
            if (cmbTip.Text == "Deri")
            {
                txtDesi.Visible = true;
                lblDesi.Visible = true;
            }
            else
            {
                txtDesi.Visible = false;
                lblDesi.Visible = false;
            }
            if (cmbTip.Text == "")
            {
                txtDesi.Visible = false;
                lblDesi.Visible = false;
                txtDesi.Text = "";
            }
        }
    }
}
