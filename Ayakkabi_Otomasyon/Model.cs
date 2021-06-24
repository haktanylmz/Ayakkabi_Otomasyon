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
    public partial class Model : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public Model()
        {
            InitializeComponent();
        }

        private void Model_Load(object sender, EventArgs e)
        {
            LoadGridView();
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
            timer1.Start();
        }

 
        void asortigetir()
        {
            try
            {
                cmbasorti.Text = "";
                cmbasorti.SelectedIndex = -1;
                cmbasorti.Items.Clear();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Asorti FROM Model_Asorti", con);
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cmbasorti.Items.Add(read["Asorti"]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asorti Getirmede Sorun Var: " + ex);
            }
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Model ORDER BY Urun_Kod ASC", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Model");
            dataGridView1.DataSource = ds.Tables["Model"];
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["Fotograf"].Visible = false;
            dataGridView1.Refresh();
            con.Close();
        }
        void ClearTextBoxes()
        {
            dataGridView1.ClearSelection();
            pictureBox1.ImageLocation = null;
            cmbasorti.Text = "";
            txturunkod.Text = "";
            txturunsayisi.Text = "";
            txtFiyat.Text = "";
        }
        bool durum;
        void IDKontrol()
        {
            durum = true;
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Model", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (txturunkod.Text == read["Urun_Kod"].ToString())
                {
                    durum = false;
                }
            }
            con.Close();
        }
        void eklebutonu()
        {
            IDKontrol();
            if (durum==true)
            {
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation)
                        && !string.IsNullOrEmpty(cmbasorti.Text)
                        && !string.IsNullOrEmpty(txturunkod.Text)
                        && !string.IsNullOrEmpty(txturunsayisi.Text)
                        && !string.IsNullOrEmpty(txtFiyat.Text))
                {
                    con.Open();
                    OleDbCommand query = new OleDbCommand("SELECT * FROM Model WHERE ([Urun_Kod] = @Urun_Kod)", con);
                    query.Parameters.AddWithValue("@user", txturunkod.Text);
                    OleDbDataReader reader = query.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Girilen Ürün Kodu Kayıtlı.");
                        con.Close();
                    }
                    else
                    {
                        try
                        {
                            con.Close();
                            string queryadd = "INSERT INTO Model(Urun_Kod,Fotograf,Asorti,Urun_sayisi,Fiyat,Ekliyen_Kisi) VALUES(@Urun_Kod,@Fotograf,@Asorti,@Urun_sayisi,@Fiyat,@Ekliyen_Kisi)";
                            OleDbCommand cmd = new OleDbCommand(queryadd, con);
                            con.Open();

                            cmd.Parameters.AddWithValue("@Urun_Kod", txturunkod.Text);
                            cmd.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
                            cmd.Parameters.AddWithValue("@Asorti", cmbasorti.Text);
                            cmd.Parameters.AddWithValue("@Urun_sayisi", txturunsayisi.Text);
                            cmd.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
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

                }
                else
                {
                    MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MessageBox.Show("Aynı Ürün Kodu Mevcut Üstüne Eklemek istiyor Musunuz ?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("UPDATE Model SET Urun_sayisi=Urun_sayisi+'" + int.Parse(txturunsayisi.Text) + "' WHERE Urun_Kod='" + dataGridView1.CurrentRow.Cells["Urun_Kod"].Value + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ClearTextBoxes();
                        LoadGridView();
                        MessageBox.Show("Model Ekleme İşlemi Başarıyla Gerçekleştirildi.");
                    }
                    catch (Exception h)
                    {
                        MessageBox.Show("s" + h);
                    } 
                }
            }
        }
        void güncellebutonu()
        {
            IDKontrol();
            if (durum == true)
            {
                if (!string.IsNullOrEmpty(txtID.Text)
                   && !string.IsNullOrEmpty(pictureBox1.ImageLocation)
                   && !string.IsNullOrEmpty(cmbasorti.Text)
                   && !string.IsNullOrEmpty(txturunkod.Text)
                   && !string.IsNullOrEmpty(txturunsayisi.Text)
                   && !string.IsNullOrEmpty(txtFiyat.Text))
                {
                    if (MessageBox.Show("Güncellemek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            con.Open();
                            string queryupdate = "UPDATE Model SET Urun_Kod=@Urun_Kod,Fotograf=@Fotograf,Asorti=@Asorti,Urun_sayisi=@Urun_sayisi,Fiyat=@Fiyat,Ekliyen_Kisi=@Ekliyen_Kisi WHERE ID=@ID";
                            OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                            cmd.Parameters.AddWithValue("@Urun_Kod", txturunkod.Text);
                            cmd.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
                            cmd.Parameters.AddWithValue("@Asorti", cmbasorti.Text);
                            cmd.Parameters.AddWithValue("@Urun_sayisi", txturunsayisi.Text);
                            cmd.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
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
                            MessageBox.Show("Hatalı İşlem : " + hata, hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (MessageBox.Show("Girilen Ürün Kodu Kayıtlı. Değiştirmek Değiştirmek İstiyor Musunuz ?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        string queryupdate = "UPDATE Model SET Urun_Kod=@Urun_Kod,Fotograf=@Fotograf,Asorti=@Asorti,Urun_sayisi=@Urun_sayisi,Fiyat=@Fiyat WHERE ID=@ID";
                        OleDbCommand cmd = new OleDbCommand(queryupdate, con);
                        cmd.Parameters.AddWithValue("@Urun_Kod", txturunkod.Text);
                        cmd.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
                        cmd.Parameters.AddWithValue("@Asorti", cmbasorti.Text);
                        cmd.Parameters.AddWithValue("@Urun_sayisi", txturunsayisi.Text);
                        cmd.Parameters.AddWithValue("@Fiyat", txtFiyat.Text);
                        cmd.Parameters.AddWithValue("@ID", txtID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ClearTextBoxes();
                        LoadGridView();
                        MessageBox.Show("Güncelleme İşlemi Başarılı", "Başarılı İşlem", MessageBoxButtons.OK);
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hatalı İşlem : " + hata, hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    con.Close();
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
        void resimekle()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
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

        private void cmbasorti_DropDown(object sender, EventArgs e)
        {
            asortigetir();
        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {
            resimekle();
        }


        private void btnresimkapat_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells["Fotograf"].Value.ToString();
            cmbasorti.Text = dataGridView1.CurrentRow.Cells["Asorti"].Value.ToString();
            txturunkod.Text = dataGridView1.CurrentRow.Cells["Urun_Kod"].Value.ToString();
            txturunsayisi.Text = dataGridView1.CurrentRow.Cells["Urun_sayisi"].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
        }

        private void Modeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
