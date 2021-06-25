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
    public partial class Kullanici : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());

        public Kullanici()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            LoadGridView();
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
            timer1.Start();
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Kullanici", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kullanici");
            dataGridView1.DataSource = ds.Tables["Kullanici"];
            this.dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Refresh();
            con.Close();
        }
        void ClearTextBoxes()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtkullaniciad.Text = "";
            txtsifre.Text="";
            txtsifre1.Text = "";
            cmbYetki.Text = "";
            cmbYetki.SelectedIndex = -1;
            cmbYetki.SelectedItem = -1;
            dataGridView1.ClearSelection();
        }
        void eklebutonu()
        {
            if (!string.IsNullOrEmpty(txtad.Text)
                && !string.IsNullOrEmpty(txtsoyad.Text)
                && !string.IsNullOrEmpty(txtkullaniciad.Text)
                && !string.IsNullOrEmpty(cmbYetki.Text)
                && !string.IsNullOrEmpty(txtsifre.Text)
                && !string.IsNullOrEmpty(txtsifre1.Text))
            {
                try
                {
                    if (txtsifre.Text==txtsifre1.Text)
                    {
                        string queryadd = "INSERT INTO Kullanici(Ad,Soyad,Kullaniciad,Sifre,Yetki)VALUES(@Ad,@Soyad,@Kuladi,@Sifre,@Yetki)";

                        OleDbCommand cmd = new OleDbCommand(queryadd, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@Ad", txtad.Text);
                        cmd.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                        cmd.Parameters.AddWithValue("@Kuladi", txtkullaniciad.Text);
                        cmd.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                        cmd.Parameters.AddWithValue("@Yetki", cmbYetki.Text);

                        cmd.ExecuteNonQuery();
                        con.Close();

                        ClearTextBoxes();
                        LoadGridView();

                        MessageBox.Show("İşlem Başarı ile Tamamlanmıştır.");
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Şifreyi Kontrol Ediniz!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);   
                    }
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
        void güncellebutonu()
        {

            if (!string.IsNullOrEmpty(txtad.Text)
                && !string.IsNullOrEmpty(txtsoyad.Text)
                && !string.IsNullOrEmpty(txtkullaniciad.Text)
                && !string.IsNullOrEmpty(cmbYetki.Text)
                && !string.IsNullOrEmpty(txtsifre.Text)
                && !string.IsNullOrEmpty(txtsifre1.Text))
            {

                if (txtsifre.Text==txtsifre1.Text)
                {
                    if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            string queryupdate = "UPDATE Kullanici SET AD=@Ad,Soyad=@Soyad,Kullaniciad=@Kuladi,Sifre=@Sifre,Yetki=@Yetki WHERE ID=@ID";
                            OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                            cmd.Parameters.AddWithValue("@Ad", txtad.Text);
                            cmd.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                            cmd.Parameters.AddWithValue("@Kuladi", txtkullaniciad.Text);
                            cmd.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                            cmd.Parameters.AddWithValue("@Yetki", cmbYetki.Text);
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
                    MessageBox.Show("Girdiğiniz Şifreyi Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void silbutonu()
        {

            if (!string.IsNullOrEmpty(txtad.Text)
                && !string.IsNullOrEmpty(txtsoyad.Text)
                && !string.IsNullOrEmpty(txtkullaniciad.Text)
                && !string.IsNullOrEmpty(cmbYetki.Text)
                && !string.IsNullOrEmpty(txtsifre.Text))
            {
                if (MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM Kullanici WHERE ID=?", con);
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
      
        private void btnekle_Click(object sender, EventArgs e)
        {
            eklebutonu();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            güncellebutonu();
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
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtkullaniciad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbYetki.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void Kullanici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void cmbYetki_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
