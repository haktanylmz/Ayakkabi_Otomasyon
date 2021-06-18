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
using System.Configuration;
using System.Data.SqlClient;

namespace Ayakkabi_Otomasyon
{
    public partial class Giris : Form
    {
        // Database Yolu Tanımlama
        OleDbConnection con = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Connection"].ToString());
        
        public Giris()
        {
            InitializeComponent();
        }
        private void Giris_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #region Show Password
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
        }
        #endregion


        public static string username;
        public void giris()
        {
            if (txtAd.Text == "")
            {
                MessageBox.Show("Kullanıcı Adınız Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string query = "Select * From Kullanici Where Kullaniciad=@KullaniciAdi ";
                OleDbParameter prm = new OleDbParameter("Kullaniciad", txtAd.Text.Trim());

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.Add(prm);

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    if (txtSifre.Text == "")
                    {
                        MessageBox.Show("Şifreniz Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        con.Open();
                        string query2 = "Select * From Kullanici Where  Sifre=@Sifre";
                        OleDbParameter prm2 = new OleDbParameter("Sifre", txtSifre.Text.Trim());

                        OleDbCommand cmd2 = new OleDbCommand(query2, con);
                        cmd2.Parameters.Add(prm2);

                        DataTable dt2 = new DataTable();
                        OleDbDataAdapter da2 = new OleDbDataAdapter(cmd2);
                        da2.Fill(dt2);
                        con.Close();
                        if (dt2.Rows.Count > 0)
                        {
                            con.Open();
                            OleDbDataReader read;
                            read = cmd.ExecuteReader();
                            if (read.Read() == true)
                            {
                                if (read["Yetki"].ToString() == "Admin")
                                {
                                    username = "";
                                    username = txtAd.Text;
                                    Menu menu = new Menu();
                                    menu.Show();
                                    this.Hide();
                                    MessageBox.Show("Admin Girişi Başarılı" + " " + txtAd.Text, "Hoşgeldiniz.");
                                }
                                else if (read["Yetki"].ToString() == "Kullanıcı")
                                {
                                    username = "";
                                    username = txtAd.Text;
                                    Kmenu kmenu = new Kmenu();
                                    kmenu.Show();
                                    this.Hide();
                                    MessageBox.Show("Giriş Başarılı" + " " + txtAd.Text, "Hoşgeldiniz.");
                                }

                            }
                            con.Close();
                        }

                        else
                        {
                            MessageBox.Show("Şifreniz Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void kontrol()
        {
            con.Open();
            
            string query = "Select * From Kullanici Where Kullaniciad=@KullaniciAdi ";
            OleDbParameter prm = new OleDbParameter("Kullaniciad", username);
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.Add(prm);

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                con.Open();
                OleDbDataReader read;
                read = cmd.ExecuteReader();
                if (read.Read() == true)
                {
                    if (read["Yetki"].ToString() == "Admin")
                    {
                        Menu menu = new Menu();
                        if (menu.lblkullaniciad.Text != "" && menu.lblkullaniciad.Text == "")
                        {
                            menu.lblkullaniciad.Text = username;
                        }
                        menu.Show();
                        this.Hide();
                    }
                    else if (read["Yetki"].ToString() == "Kullanıcı")
                    {
                        Kmenu kmenu = new Kmenu();
                        if (kmenu.lblkullaniciad.Text != "" && kmenu.lblkullaniciad.Text=="")
                        {
                            kmenu.lblkullaniciad.Text = username;
                        }
                        kmenu.Show();
                        this.Hide();
                    }

                }
                con.Close();
            }
        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            giris();
        }

        #region Saat
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        } 
        #endregion

        #region Enter Keydown

        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSifre.Focus();
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }



        #endregion

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
