namespace Ayakkabi_Otomasyon
{
    partial class Kullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici));
            this.btntemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.lblkullaniciad = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtsifre1 = new System.Windows.Forms.TextBox();
            this.lblsifre2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.lblYetki = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntemizle
            // 
            this.btntemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntemizle.ImageIndex = 3;
            this.btntemizle.ImageList = this.ımageList1;
            this.btntemizle.Location = new System.Drawing.Point(145, 430);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(81, 33);
            this.btntemizle.TabIndex = 8;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ekle.png");
            this.ımageList1.Images.SetKeyName(1, "güncelle.png");
            this.ımageList1.Images.SetKeyName(2, "sil.png");
            this.ımageList1.Images.SetKeyName(3, "temizle.png");
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.ImageIndex = 2;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(64, 431);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(81, 32);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.ImageIndex = 1;
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(145, 393);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(81, 32);
            this.btnguncelle.TabIndex = 6;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 426);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(99, 97);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 0;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(56, 100);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(26, 13);
            this.lblad.TabIndex = 21;
            this.lblad.Text = "Ad :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(99, 148);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 1;
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(39, 151);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(43, 13);
            this.lblsoyad.TabIndex = 21;
            this.lblsoyad.Text = "Soyad :";
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Location = new System.Drawing.Point(99, 199);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(100, 20);
            this.txtkullaniciad.TabIndex = 2;
            // 
            // lblkullaniciad
            // 
            this.lblkullaniciad.AutoSize = true;
            this.lblkullaniciad.Location = new System.Drawing.Point(12, 202);
            this.lblkullaniciad.Name = "lblkullaniciad";
            this.lblkullaniciad.Size = new System.Drawing.Size(70, 13);
            this.lblkullaniciad.TabIndex = 21;
            this.lblkullaniciad.Text = "Kullanıcı Adı :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(99, 302);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(100, 20);
            this.txtsifre.TabIndex = 3;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(48, 305);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(34, 13);
            this.lblsifre.TabIndex = 21;
            this.lblsifre.Text = "Şifre :";
            // 
            // txtsifre1
            // 
            this.txtsifre1.BackColor = System.Drawing.SystemColors.Window;
            this.txtsifre1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtsifre1.Location = new System.Drawing.Point(99, 353);
            this.txtsifre1.Name = "txtsifre1";
            this.txtsifre1.PasswordChar = '*';
            this.txtsifre1.Size = new System.Drawing.Size(100, 20);
            this.txtsifre1.TabIndex = 4;
            // 
            // lblsifre2
            // 
            this.lblsifre2.AutoSize = true;
            this.lblsifre2.Location = new System.Drawing.Point(14, 356);
            this.lblsifre2.Name = "lblsifre2";
            this.lblsifre2.Size = new System.Drawing.Size(68, 13);
            this.lblsifre2.TabIndex = 21;
            this.lblsifre2.Text = "Şifre Tekrar :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(99, 46);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(61, 49);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 21;
            this.lblid.Text = "ID:";
            this.lblid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(462, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kullanıcılar";
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Ayakkabi_Otomasyon.Properties.Resources.back;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(20, 469);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(30, 30);
            this.btngeri.TabIndex = 22;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnekle.ImageIndex = 0;
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(64, 393);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(81, 32);
            this.btnekle.TabIndex = 5;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kullanıcı:";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(733, 486);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(35, 13);
            this.lblkullanici.TabIndex = 36;
            this.lblkullanici.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Saat:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(721, 18);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(37, 13);
            this.lblsaat.TabIndex = 65;
            this.lblsaat.Text = "lblsaat";
            this.lblsaat.Click += new System.EventHandler(this.lblsaat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbYetki
            // 
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] {
            "Admin",
            "Kullanıcı"});
            this.cmbYetki.Location = new System.Drawing.Point(99, 250);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(100, 21);
            this.cmbYetki.TabIndex = 67;
            this.cmbYetki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbYetki_KeyPress);
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(45, 253);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(37, 13);
            this.lblYetki.TabIndex = 68;
            this.lblYetki.Text = "Yetki :";
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.lblsifre2);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txtsifre1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciad);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kullanici_FormClosing);
            this.Load += new System.EventHandler(this.Kullanici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.Label lblkullaniciad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtsifre1;
        private System.Windows.Forms.Label lblsifre2;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.Label lblYetki;
    }
}