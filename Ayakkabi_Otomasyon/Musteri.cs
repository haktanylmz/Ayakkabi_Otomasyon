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
using System.Net.Mail;

namespace Ayakkabi_Otomasyon
{
    public partial class Musteri : Form
    {
        //Database Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        
        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            LoadGridView();
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
        }

        private void Musteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void ClearTextBoxes()
        {
            dataGridView1.ClearSelection();
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            txtAdres.Text = "";
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Musteri", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dataGridView1.DataSource = ds.Tables["Musteri"];
            this.dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Refresh();
            con.Close();

        }
        
        void eklebutonu()
        {
            
            if (!string.IsNullOrEmpty(txtTc.Text)
                && !string.IsNullOrEmpty(txtAd.Text)
                && !string.IsNullOrEmpty(txtSoyad.Text)
                && !string.IsNullOrEmpty(txtTelefon.Text)
                && !string.IsNullOrEmpty(txtEmail.Text)
                && !string.IsNullOrEmpty(txtAdres.Text))
            {
                int tc = txtTc.TextLength;
                if (tc == 11)
                {
                        if (txtEmail.Text.Contains("@"))
                        {
                            if (txtEmail.Text.Contains("."))
                            {
                                try
                                {
                                    string queryadd = "INSERT INTO Musteri(Tc,Ad,Soyad,Telefon,Email,Adres,Ekliyen_Kisi) VALUES(@Tc,@Ad,@Soyad,@Telefon,@Email,@Adres,@Ekliyen_Kisi)";

                                    OleDbCommand cmd = new OleDbCommand(queryadd, con);
                                    con.Open();
                                    cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
                                    cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                                    cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                                    cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                                    cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                                    cmd.Parameters.AddWithValue("@Ekliyen_Kisi", lblkullanici.Text);
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
                                MessageBox.Show("Emailinizi Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Emailinizi Kontrol Ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                else
                {
                    MessageBox.Show("Tc'yi Eksik Girdiniz.");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void guncellebutonu()
        {
            if (!string.IsNullOrEmpty(txtTc.Text)
                && !string.IsNullOrEmpty(txtAd.Text)
                && !string.IsNullOrEmpty(txtSoyad.Text)
                && !string.IsNullOrEmpty(txtTelefon.Text)
                && !string.IsNullOrEmpty(txtEmail.Text)
                && !string.IsNullOrEmpty(txtAdres.Text))
            {

                if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int tc = txtTc.TextLength;
                    if (tc==11)
                    {
                        try
                        {
                            con.Open();
                            string queryupdate = "UPDATE Musteri SET Tc=@Tc,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,Email=@Email,Adres=@Adres,Ekliyen_Kisi=@Ekliyen_Kisi WHERE ID=@ID";
                            OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                            cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
                            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                            cmd.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                            cmd.Parameters.AddWithValue("@Ekliyen_Kisi", lblkullanici.Text);
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
                    else
                    {
                        MessageBox.Show("Tc'yi Eksik Girdiniz.");
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
            
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM Musteri WHERE ID=?", con);
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
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
        }
        void ara()
        {
            con.Open();
            DataTable tbl = new DataTable();
            OleDbDataAdapter ara = new OleDbDataAdapter("Select * from Musteri where AD like '%" + txtara.Text + "%'", con);
            ara.Fill(tbl);
            con.Close();
            dataGridView1.DataSource = tbl;
        }
        private void txtara_TextChanged(object sender, EventArgs e)
        {
            ara();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }
    }
}
