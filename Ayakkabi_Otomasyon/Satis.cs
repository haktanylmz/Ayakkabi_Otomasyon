using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Ayakkabi_Otomasyon
{
    public partial class Satis : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        public double empty = 0;
        public Satis()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.kontrol();
            this.Hide();
        }
        void cmbkdvgetir()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * from Model_Kdv", con);
            DataTable table = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(table);
            cmbkdv.DataSource = table;
            cmbkdv.DisplayMember = "Yüzde";
            cmbkdv.ValueMember = "Kdv";
            con.Close();
            if (cmbkdv.Text == "")
            {
                cmbkdv.Text = "";
                lblkdv.Text = "";
            }
        }
        private void Satis_Load(object sender, EventArgs e)
        {
            lblkullanici.Text = "";
            lblkullanici.Text = Giris.username;
            lblkdv.Text = "";
            LoadGridView();
            hesapla();
            tcgetir();
            urunkodgetir();
            timer1.Start();
        }
        void tcgetir()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Tc FROM Musteri",con);
            OleDbDataReader read = cmd.ExecuteReader();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            while (read.Read())
            {
                collection.Add(read.GetString(0));
            }
            txtTc.AutoCompleteCustomSource = collection;
            con.Close();
        }
        void urunkodgetir()
        {
            try
            {
                cmbUrunKod.Text = "";
                cmbUrunKod.SelectedIndex = -1;
                cmbUrunKod.Items.Clear();
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT Urun_Kod FROM Model Order By Urun_Kod ASC", con);
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    cmbUrunKod.Items.Add(read["Urun_Kod"]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Urun Kod Getirmede hata :" + ex);
            }
        }

        void HerseyiTemizle()
        {
            cmbkdv.Text = "";
            cmbkdv.SelectedIndex = -1;
            lblkdv.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
            dataGridView1.ClearSelection();
            txtTc.Text = "";
            txtAd.Text = "";
            txtTelefon.Text = "";
            pictureBox1.ImageLocation = null;
            cmbUrunKod.Text = "";
            txtAsorti.Text = "";
            txtOzeloran.Text = "";
            txtOzeloran.Visible = false;
            lblOzeloran.Visible = false;
            lblyuzde.Visible = false;
        }
        void TemizleMusteri()
        {
            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
        }
        void TemizleUrun()
        {
            pictureBox1.ImageLocation = null;
            cmbUrunKod.Text = "";
            txtAsorti.Text = "";
            txtAdet.Text = "";
            txtFiyat.Text = "";
            txtToplamFiyat.Text = "";
        }


       
        bool durum;
        void modelkontrol()
        {
            
            durum = true;
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Sepet", con);
            OleDbDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (cmbUrunKod.Text == read["Urun_Kod"].ToString())
                {
                    durum = false;
                }
            }
            con.Close();
            
        }
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            SepetEkle();
        }

        void SepetEkle()
        {
            modelkontrol();
            if (durum == true)
            {
                try
                {
                    if (!string.IsNullOrEmpty(txtTc.Text)
                           && !string.IsNullOrEmpty(txtAd.Text)
                           && !string.IsNullOrEmpty(txtSoyad.Text)
                           && !string.IsNullOrEmpty(txtTelefon.Text)
                           && !string.IsNullOrEmpty(pictureBox1.ImageLocation)
                           && !string.IsNullOrEmpty(cmbUrunKod.Text)
                           && !string.IsNullOrEmpty(txtAsorti.Text)
                           && !string.IsNullOrEmpty(txtFiyat.Text)
                           && !string.IsNullOrEmpty(txtAdet.Text)
                           && !string.IsNullOrEmpty(cmbkdv.Text)
                           && !string.IsNullOrEmpty(txtToplamFiyat.Text)
                           && !string.IsNullOrEmpty(lblkdv.Text))
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("insert into Sepet(Tc,Musteri_Ad,Musteri_Soyad,Musteri_tel,Fotograf,Urun_Kod,Asorti,Adet,Fiyat,Kdv_Yüzde,Kdv_Toplam_Fiyat,Toplam_Fiyat,Tarih,Ekliyen_Kisi)" +
                            " Values(@Tc,@Musteri_Ad,@Musteri_Soyad,@Musteri_tel,@Fotograf,@Urun_Kod,@Asorti,@Adet,@Fiyat,@Kdv_Yüzde,@Kdv_Toplam_Fiyat,@Toplam_Fiyat,@Tarih,@Ekliyen_Kisi)", con);
                        cmd.Parameters.AddWithValue("@Tc", txtTc.Text);
                        cmd.Parameters.AddWithValue("@Musteri_Ad", txtAd.Text);
                        cmd.Parameters.AddWithValue("@Musteri_Soyad", txtSoyad.Text);
                        cmd.Parameters.AddWithValue("@Musteri_tel", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@Fotograf", pictureBox1.ImageLocation);
                        cmd.Parameters.AddWithValue("@Urun_Kod", cmbUrunKod.Text);
                        cmd.Parameters.AddWithValue("@Asorti", txtAsorti.Text);
                        cmd.Parameters.AddWithValue("@Adet", int.Parse(txtAdet.Text));
                        cmd.Parameters.AddWithValue("@Fiyat", double.Parse(txtFiyat.Text));
                        cmd.Parameters.AddWithValue("@Kdv_Yüzde", empty);
                        cmd.Parameters.AddWithValue("@Kdv_Toplam_Fiyat", double.Parse(lblkdv.Text));
                        cmd.Parameters.AddWithValue("@Toplam_Fiyat", double.Parse(txtToplamFiyat.Text));
                        cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@Ekliyen_Kisi", lblkullanici.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        LoadGridView();
                        HerseyiTemizle();
                        hesapla();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Boşlukları Doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata :" + ex);
                }
            }
            else
            {
                MessageBox.Show("Girilen Ürün Önceden Eklenmiş. Tekrar Girilemez! ", "Hata");

                //if (MessageBox.Show("Girilen Ürün Önceden Eklenmiş. Üzerine Eklemek İstiyor Musunuz? ","Mesaj",MessageBoxButtons.YesNo)==DialogResult.Yes)
                //{
                //EklemeKontrol();
                //if (durum1==false)
                //{
                //    //try
                //    //{
                //    //    con.Open();
                //    //    OleDbCommand cmd = new OleDbCommand("UPDATE Sepet SET Adet=Adet+'" + int.Parse(txtAdet.Text) + "' WHERE Urun_Kod='" + dataGridView1.CurrentRow.Cells["Urun_Kod"].Value + "'", con);
                //    //    cmd.ExecuteNonQuery();
                //    //    OleDbCommand cmd2 = new OleDbCommand("UPDATE Sepet SET Toplam_Fiyat=Adet*Fiyat,Kdv_Toplam_Fiyat=Toplam_Fiyat*() WHERE Urun_Kod='" + dataGridView1.CurrentRow.Cells["Urun_Kod"].Value + "'", con);
                //    //    cmd2.ExecuteNonQuery();
                //    //    con.Close();
                //    //    HerseyiTemizle();
                //    //    LoadGridView();
                //    //    MessageBox.Show("Ürün Ekleme İşlemi Başarıyla Gerçekleştirilmiştir.");
                //    //}
                //    //catch (Exception h)
                //    //{
                //    //    MessageBox.Show("s" + h);
                //    //} 
                //} 
                //}
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            HerseyiTemizle();
        }
        
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["Musteri_Ad"].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells["Musteri_Soyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Musteri_tel"].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells["Fotograf"].Value.ToString();
            cmbUrunKod.Text = dataGridView1.CurrentRow.Cells["Urun_Kod"].Value.ToString();
            txtAsorti.Text = dataGridView1.CurrentRow.Cells["Asorti"].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
            cmbkdv.Text = dataGridView1.CurrentRow.Cells["Kdv_Yüzde"].Value.ToString();
            lblkdv.Text = dataGridView1.CurrentRow.Cells["Kdv_Toplam_Fiyat"].Value.ToString();
            txtToplamFiyat.Text = dataGridView1.CurrentRow.Cells["Toplam_Fiyat"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (dataGridView1.CurrentRow.Cells["Urun_Kod"].Value.ToString()==null)
                    {
                        MessageBox.Show("Seçili Bir Ürün Yok.");
                    }
                    else
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("DELETE FROM Sepet WHERE Urun_Kod='" + dataGridView1.CurrentRow.Cells["Urun_Kod"].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Ürün sepetten çıkarıldı.");
                        LoadGridView();
                        HerseyiTemizle();
                        hesapla();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SİLME İŞLEMİNDE HATA :" + ex);
                }
            }
        }
        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Satışı İptal Etmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM Sepet ", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ürünler sepetten çıkarıldı.");
                    LoadGridView();
                    HerseyiTemizle();
                    hesapla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA :" + ex);
                }
            }
        }
        void hesapla()
        {
           
            try
            {
                con.Open();
                double sayi = 0;
                if (sayi == 0)
                {
                    
                    OleDbCommand cmd = new OleDbCommand("select sum(Kdv_Toplam_Fiyat)from Sepet", con);
                    sayi = Convert.ToDouble(cmd.ExecuteScalar());
                    sayi = Math.Round(sayi, 3);
                    txtGenelToplam.Text = Convert.ToString(sayi) + " ₺";
                }
                

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Genel Toplam Hesabında Hata : "+ex);
            }
        }
        void LoadGridView()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Sepet", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sepet");
            dataGridView1.DataSource = ds.Tables["Sepet"];
            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView1.Columns["Tc"].Visible = false;
            this.dataGridView1.Columns["Musteri_Ad"].Visible = false;
            this.dataGridView1.Columns["Musteri_Soyad"].Visible = false;
            this.dataGridView1.Columns["Musteri_tel"].Visible = false;
            this.dataGridView1.Columns["Fotograf"].Visible = false;

            dataGridView1.Refresh();
            con.Close();
        }
        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into Satis(Tc,Musteri_Ad,Musteri_Soyad,Musteri_tel,Fotograf,Urun_Kod,Asorti,Adet,Fiyat,Kdv_Yüzde,Kdv_Toplam_Fiyat,Toplam_Fiyat,Tarih,Ekliyen_Kisi)" +
                        " Values(@Tc,@Musteri_Ad,@Musteri_Soyad,@Musteri_tel,@Fotograf,@Urun_Kod,@Asorti,@Adet,@Fiyat,@Kdv_Yüzde,@Kdv_Toplam_Fiyat,@Toplam_Fiyat,@Tarih,@Ekliyen_Kisi)", con);
                    cmd.Parameters.AddWithValue("@Tc", dataGridView1.Rows[i].Cells["Tc"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Musteri_Ad", dataGridView1.Rows[i].Cells["Musteri_Ad"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Musteri_Soyad", dataGridView1.Rows[i].Cells["Musteri_Soyad"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Musteri_tel", dataGridView1.Rows[i].Cells["Musteri_tel"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Fotograf", dataGridView1.Rows[i].Cells["Fotograf"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Urun_Kod", dataGridView1.Rows[i].Cells["Urun_Kod"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Asorti", dataGridView1.Rows[i].Cells["Asorti"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Adet", int.Parse(dataGridView1.Rows[i].Cells["Adet"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Fiyat", double.Parse(dataGridView1.Rows[i].Cells["Fiyat"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Kdv_Yüzde", dataGridView1.Rows[i].Cells["Kdv_Yüzde"].Value.ToString());
                    cmd.Parameters.AddWithValue("@Kdv_Toplam_Fiyat", double.Parse(dataGridView1.Rows[i].Cells["Kdv_Toplam_Fiyat"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Toplam_Fiyat", double.Parse(dataGridView1.Rows[i].Cells["Toplam_Fiyat"].Value.ToString()));
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@Ekliyen_Kisi", lblkullanici.Text);

                    cmd.ExecuteNonQuery();
                    OleDbCommand cmd1 = new OleDbCommand("UPDATE Model SET Urun_sayisi=Urun_sayisi-'" + int.Parse(dataGridView1.Rows[i].Cells["Adet"].Value.ToString()) + "' WHERE Urun_Kod='" + dataGridView1.Rows[i].Cells["Urun_Kod"].Value.ToString() + "'", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata Var:" + ex);
                    con.Close();
                }

            }
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand("DELETE from Sepet", con);
            cmd2.ExecuteNonQuery();
            con.Close();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Sepet", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Sepet");
            ds.Tables["Sepet"].Clear();
            LoadGridView();
            hesapla();
        }

        private void Satis_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSatisListele_Click(object sender, EventArgs e)
        {
            Listele_Satis sl = new Listele_Satis();
            sl.Show();
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                TemizleMusteri();
            }
            try
            {
                con.Open();
                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
                OleDbCommand cmd1 = new OleDbCommand("Select ID from Musteri", con);
                OleDbDataReader read = cmd1.ExecuteReader();
                while (read.Read())
                {
                    Collection.Add(read["ID"].ToString());
                }
                OleDbCommand cmd = new OleDbCommand("Select * From Musteri Where Tc like '" + txtTc.Text + "'", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtAd.Text = rd["Ad"].ToString();
                    txtSoyad.Text = rd["Soyad"].ToString();
                    txtTelefon.Text = rd["Telefon"].ToString();
                }
                rd.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata :" + ex);
            }
        }

        private void cmbUrunKod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUrunKod.Text == "")
            {
                TemizleUrun();
            }
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Model Where Urun_Kod like '" + cmbUrunKod.Text + "'", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    pictureBox1.ImageLocation = rd["Fotograf"].ToString();
                    txtAsorti.Text = rd["Asorti"].ToString();
                    txtFiyat.Text = rd["Fiyat"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata: " + ex);
            }
        }
        private void cmbUrunKod_TextChanged(object sender, EventArgs e)
        {
            if (cmbUrunKod.Text == "")
            {
                TemizleUrun();
            }
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Model Where Urun_Kod like '" + cmbUrunKod.Text + "'", con);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    pictureBox1.ImageLocation = rd["Fotograf"].ToString();
                    txtAsorti.Text = rd["Asorti"].ToString();
                    txtFiyat.Text = rd["Fiyat"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata: " + ex);
            }
        }
        private void txtAdet_TextChanged(object sender, EventArgs e)
        {

            if (txtAdet.Text!="" && int.Parse(txtAdet.Text) != 0 && txtAdet.Text!=null)
            {
                if (!string.IsNullOrEmpty(cmbUrunKod.Text)
                    && !string.IsNullOrEmpty(txtAsorti.Text)
                    && !string.IsNullOrEmpty(txtFiyat.Text))
                {
                    try
                    {
                        txtToplamFiyat.Text = (double.Parse(txtAdet.Text) * double.Parse(txtFiyat.Text)).ToString();

                        if (cmbkdv.SelectedIndex != -1 && cmbkdv.SelectedIndex != 4)
                        {
                            if (empty != 0)
                            {
                                empty = 0;
                                empty = 100 * (double.Parse(cmbkdv.SelectedValue.ToString()) - 1);
                            }
                            else
                            {
                                empty = 100 * (double.Parse(cmbkdv.SelectedValue.ToString()) - 1);
                            }

                            lblkdv.Text = Convert.ToString(double.Parse(txtToplamFiyat.Text) * double.Parse(cmbkdv.SelectedValue.ToString()));
                        }
                        else
                        {
                            lblkdv.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Toplam Fiyatta Hata : " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Eksik Bilgileri Tamamlayınız!");
                    HerseyiTemizle();
                } 
            }
           

        }
        
        private void cmbkdv_DropDownClosed(object sender, EventArgs e)
        {
            cmbkdvhesapla();
        }

        private void cmbkdvhesapla()
        {
            if (!string.IsNullOrEmpty(txtFiyat.Text)
                            && !string.IsNullOrEmpty(txtToplamFiyat.Text)
                            && !string.IsNullOrEmpty(cmbUrunKod.Text)
                            && !string.IsNullOrEmpty(txtAsorti.Text))
            {
                if (cmbkdv.SelectedIndex == 4)
                {
                    lblkdv.Text = "";

                    txtOzeloran.Visible = true;
                    lblOzeloran.Visible = true;
                    lblyuzde.Visible = true;
                }
                else
                {
                    lblkdv.Text = "";
                    txtOzeloran.Visible = false;
                    lblOzeloran.Visible = false;
                    lblyuzde.Visible = false;
                }
                if (cmbkdv.SelectedIndex != -1)
                {
                    try
                    {
                        if (empty != 0)
                        {
                            empty = 0;
                            empty = 100 * (double.Parse(cmbkdv.SelectedValue.ToString()) - 1);

                        }
                        else
                        {
                            empty = 100 * (double.Parse(cmbkdv.SelectedValue.ToString()) - 1);
                        }
                        if (cmbkdv.SelectedIndex != 4)
                        {
                            lblkdv.Text = Convert.ToString(double.Parse(txtToplamFiyat.Text) * double.Parse(cmbkdv.SelectedValue.ToString()));

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata burda mı: " + ex);
                    }
                }
                else
                {
                    cmbkdv.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eksik Bilgileri Tamamlayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbkdv.Text = "";
                cmbkdv.SelectedItem = "";
                cmbkdv.SelectedIndex = -1;
            }
        }

       
        private void cmbkdv_DropDown(object sender, EventArgs e)
        {
            cmbkdvgetir();
        }
        
        private void txtOzeloran_TextChanged(object sender, EventArgs e)
        {
            if (txtOzeloran.Text == "")
            {
                txtOzeloran.Text = "";
                lblkdv.Text = "";
            }else
            {
                if (empty != 0)
                {
                    empty = 0;
                    empty = Convert.ToDouble(txtOzeloran.Text);
                }
                else
                {
                    empty = Convert.ToDouble(txtOzeloran.Text);
                }
                double ozeloran = Convert.ToDouble(txtOzeloran.Text);
                double kdvlifiyat;
                double fiyat = double.Parse(txtFiyat.Text);
                kdvlifiyat = fiyat + (fiyat * (ozeloran / 100));
                lblkdv.Text = Convert.ToString(kdvlifiyat);
            }

        }

        #region Özel Oran Textbox Karakter Sınırlaması
        private void txtOzeloran_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) ;
        }
        #endregion

        private void cmbkdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled=char.IsLetterOrDigit(e.KeyChar))
            {
                MessageBox.Show("Değer Girilemez!","Hata",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
            else
            {
                e.Handled=false;
            }
        }

        private void cmbkdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbkdv.Text=="")
            {
                lblOzeloran.Visible = false;
                lblyuzde.Visible = false;
                txtOzeloran.Visible = false;
                txtOzeloran.Text = "";
            }
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
