namespace Ayakkabi_Otomasyon
{
    partial class Model
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Model));
            this.lblfotograf = new System.Windows.Forms.Label();
            this.lblasorti = new System.Windows.Forms.Label();
            this.lblurunsayisi = new System.Windows.Forms.Label();
            this.cmbasorti = new System.Windows.Forms.ComboBox();
            this.txturunsayisi = new System.Windows.Forms.TextBox();
            this.txturunkod = new System.Windows.Forms.TextBox();
            this.lblurunkod = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnresimkapat = new System.Windows.Forms.Button();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btntemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfotograf
            // 
            this.lblfotograf.AutoSize = true;
            this.lblfotograf.Location = new System.Drawing.Point(23, 126);
            this.lblfotograf.Name = "lblfotograf";
            this.lblfotograf.Size = new System.Drawing.Size(52, 13);
            this.lblfotograf.TabIndex = 2;
            this.lblfotograf.Text = "Fotoğraf :";
            // 
            // lblasorti
            // 
            this.lblasorti.AutoSize = true;
            this.lblasorti.Location = new System.Drawing.Point(36, 239);
            this.lblasorti.Name = "lblasorti";
            this.lblasorti.Size = new System.Drawing.Size(39, 13);
            this.lblasorti.TabIndex = 3;
            this.lblasorti.Text = "Asorti :";
            // 
            // lblurunsayisi
            // 
            this.lblurunsayisi.AutoSize = true;
            this.lblurunsayisi.Location = new System.Drawing.Point(14, 307);
            this.lblurunsayisi.Name = "lblurunsayisi";
            this.lblurunsayisi.Size = new System.Drawing.Size(61, 13);
            this.lblurunsayisi.TabIndex = 4;
            this.lblurunsayisi.Text = "Ürün Adet :";
            // 
            // cmbasorti
            // 
            this.cmbasorti.FormattingEnabled = true;
            this.cmbasorti.Location = new System.Drawing.Point(97, 235);
            this.cmbasorti.Name = "cmbasorti";
            this.cmbasorti.Size = new System.Drawing.Size(114, 21);
            this.cmbasorti.TabIndex = 5;
            this.cmbasorti.DropDown += new System.EventHandler(this.cmbasorti_DropDown);
            // 
            // txturunsayisi
            // 
            this.txturunsayisi.Location = new System.Drawing.Point(97, 304);
            this.txturunsayisi.Name = "txturunsayisi";
            this.txturunsayisi.Size = new System.Drawing.Size(114, 20);
            this.txturunsayisi.TabIndex = 6;
            // 
            // txturunkod
            // 
            this.txturunkod.Location = new System.Drawing.Point(97, 270);
            this.txturunkod.Name = "txturunkod";
            this.txturunkod.Size = new System.Drawing.Size(114, 20);
            this.txturunkod.TabIndex = 7;
            // 
            // lblurunkod
            // 
            this.lblurunkod.AutoSize = true;
            this.lblurunkod.Location = new System.Drawing.Point(14, 273);
            this.lblurunkod.Name = "lblurunkod";
            this.lblurunkod.Size = new System.Drawing.Size(61, 13);
            this.lblurunkod.TabIndex = 8;
            this.lblurunkod.Text = "Ürün Kod : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Ayakkabi_Otomasyon.Properties.Resources.back;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(12, 469);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(30, 30);
            this.btngeri.TabIndex = 18;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnresimkapat
            // 
            this.btnresimkapat.BackgroundImage = global::Ayakkabi_Otomasyon.Properties.Resources.cancel;
            this.btnresimkapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresimkapat.Location = new System.Drawing.Point(186, 195);
            this.btnresimkapat.Name = "btnresimkapat";
            this.btnresimkapat.Size = new System.Drawing.Size(25, 23);
            this.btnresimkapat.TabIndex = 14;
            this.btnresimkapat.UseVisualStyleBackColor = true;
            this.btnresimkapat.Click += new System.EventHandler(this.btnresimkapat_Click);
            // 
            // btnresimekle
            // 
            this.btnresimekle.Image = global::Ayakkabi_Otomasyon.Properties.Resources.iconfinder_image_add_36117;
            this.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnresimekle.Location = new System.Drawing.Point(97, 195);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(83, 23);
            this.btnresimekle.TabIndex = 13;
            this.btnresimekle.Text = "resim ekle";
            this.btnresimekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresimekle.UseVisualStyleBackColor = true;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(97, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(733, 486);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(35, 13);
            this.lblkullanici.TabIndex = 24;
            this.lblkullanici.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kullanıcı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btntemizle
            // 
            this.btntemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntemizle.ImageIndex = 3;
            this.btntemizle.ImageList = this.ımageList1;
            this.btntemizle.Location = new System.Drawing.Point(135, 422);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(81, 33);
            this.btntemizle.TabIndex = 29;
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
            this.btnsil.Location = new System.Drawing.Point(54, 423);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(81, 32);
            this.btnsil.TabIndex = 28;
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
            this.btnguncelle.Location = new System.Drawing.Point(135, 385);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(81, 32);
            this.btnguncelle.TabIndex = 27;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnekle.ImageIndex = 0;
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(54, 385);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(81, 32);
            this.btnekle.TabIndex = 26;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(473, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Modeller";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(97, 338);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(114, 20);
            this.txtFiyat.TabIndex = 38;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(40, 341);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 39;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 20);
            this.txtID.TabIndex = 40;
            this.txtID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(51, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "ID :";
            this.lblID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Saat:";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(721, 18);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(37, 13);
            this.lblsaat.TabIndex = 65;
            this.lblsaat.Text = "lblsaat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnresimkapat);
            this.Controls.Add(this.btnresimekle);
            this.Controls.Add(this.lblurunkod);
            this.Controls.Add(this.txturunkod);
            this.Controls.Add(this.txturunsayisi);
            this.Controls.Add(this.cmbasorti);
            this.Controls.Add(this.lblurunsayisi);
            this.Controls.Add(this.lblasorti);
            this.Controls.Add(this.lblfotograf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modeller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modeller_FormClosing);
            this.Load += new System.EventHandler(this.Model_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblfotograf;
        private System.Windows.Forms.Label lblasorti;
        private System.Windows.Forms.Label lblurunsayisi;
        private System.Windows.Forms.ComboBox cmbasorti;
        private System.Windows.Forms.TextBox txturunsayisi;
        private System.Windows.Forms.TextBox txturunkod;
        private System.Windows.Forms.Label lblurunkod;
        protected internal System.Windows.Forms.Button btnresimkapat;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer timer1;
    }
}