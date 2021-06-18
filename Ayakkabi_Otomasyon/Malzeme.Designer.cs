namespace Ayakkabi_Otomasyon
{
    partial class Malzeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Malzeme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblfotograf = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbcilt = new System.Windows.Forms.ComboBox();
            this.lblcilt = new System.Windows.Forms.Label();
            this.txttaban = new System.Windows.Forms.TextBox();
            this.lbltaban = new System.Windows.Forms.Label();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.lblrenk = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtara = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnresimkapat = new System.Windows.Forms.Button();
            this.btnresimekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lblfotograf
            // 
            this.lblfotograf.AutoSize = true;
            this.lblfotograf.Location = new System.Drawing.Point(43, 166);
            this.lblfotograf.Name = "lblfotograf";
            this.lblfotograf.Size = new System.Drawing.Size(49, 13);
            this.lblfotograf.TabIndex = 1;
            this.lblfotograf.Text = "Fotoğraf:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbcilt
            // 
            this.cmbcilt.FormattingEnabled = true;
            this.cmbcilt.Location = new System.Drawing.Point(104, 266);
            this.cmbcilt.Name = "cmbcilt";
            this.cmbcilt.Size = new System.Drawing.Size(114, 21);
            this.cmbcilt.TabIndex = 8;
            this.cmbcilt.DropDown += new System.EventHandler(this.cmbcilt_DropDown);
            // 
            // lblcilt
            // 
            this.lblcilt.AutoSize = true;
            this.lblcilt.Location = new System.Drawing.Point(37, 269);
            this.lblcilt.Name = "lblcilt";
            this.lblcilt.Size = new System.Drawing.Size(55, 13);
            this.lblcilt.TabIndex = 9;
            this.lblcilt.Text = "Cilt Çeşidi:";
            // 
            // txttaban
            // 
            this.txttaban.Location = new System.Drawing.Point(104, 305);
            this.txttaban.Name = "txttaban";
            this.txttaban.Size = new System.Drawing.Size(114, 20);
            this.txttaban.TabIndex = 10;
            // 
            // lbltaban
            // 
            this.lbltaban.AutoSize = true;
            this.lbltaban.Location = new System.Drawing.Point(51, 308);
            this.lbltaban.Name = "lbltaban";
            this.lbltaban.Size = new System.Drawing.Size(41, 13);
            this.lbltaban.TabIndex = 11;
            this.lbltaban.Text = "Taban:";
            // 
            // txtrenk
            // 
            this.txtrenk.Location = new System.Drawing.Point(104, 343);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(114, 20);
            this.txtrenk.TabIndex = 12;
            // 
            // lblrenk
            // 
            this.lblrenk.AutoSize = true;
            this.lblrenk.Location = new System.Drawing.Point(56, 346);
            this.lblrenk.Name = "lblrenk";
            this.lblrenk.Size = new System.Drawing.Size(36, 13);
            this.lblrenk.TabIndex = 13;
            this.lblrenk.Text = "Renk:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(104, 108);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(114, 20);
            this.txtid.TabIndex = 15;
            this.txtid.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(71, 111);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(21, 13);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "ID:";
            this.lblid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtara);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 52);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama: ";
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(59, 19);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(100, 20);
            this.txtara.TabIndex = 0;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kullanıcı:";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(733, 486);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(35, 13);
            this.lblkullanici.TabIndex = 34;
            this.lblkullanici.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(458, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 36;
            this.label3.Text = "Malzemeler";
            // 
            // btntemizle
            // 
            this.btntemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntemizle.ImageIndex = 3;
            this.btntemizle.ImageList = this.ımageList1;
            this.btntemizle.Location = new System.Drawing.Point(143, 426);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(81, 33);
            this.btntemizle.TabIndex = 33;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsil
            // 
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsil.ImageIndex = 2;
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(62, 427);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(81, 32);
            this.btnsil.TabIndex = 32;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Ayakkabi_Otomasyon.Properties.Resources.back;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(12, 469);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(30, 30);
            this.btngeri.TabIndex = 17;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguncelle.ImageIndex = 1;
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(143, 389);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(81, 32);
            this.btnguncelle.TabIndex = 31;
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
            this.btnekle.Location = new System.Drawing.Point(62, 389);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(81, 32);
            this.btnekle.TabIndex = 30;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnresimkapat
            // 
            this.btnresimkapat.BackgroundImage = global::Ayakkabi_Otomasyon.Properties.Resources.cancel;
            this.btnresimkapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresimkapat.Location = new System.Drawing.Point(193, 225);
            this.btnresimkapat.Name = "btnresimkapat";
            this.btnresimkapat.Size = new System.Drawing.Size(25, 23);
            this.btnresimkapat.TabIndex = 7;
            this.btnresimkapat.UseVisualStyleBackColor = true;
            this.btnresimkapat.Click += new System.EventHandler(this.btnresimkapat_Click);
            // 
            // btnresimekle
            // 
            this.btnresimekle.Image = global::Ayakkabi_Otomasyon.Properties.Resources.iconfinder_image_add_36117;
            this.btnresimekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnresimekle.Location = new System.Drawing.Point(104, 225);
            this.btnresimekle.Name = "btnresimekle";
            this.btnresimekle.Size = new System.Drawing.Size(83, 23);
            this.btnresimekle.TabIndex = 6;
            this.btnresimekle.Text = "resim ekle";
            this.btnresimekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnresimekle.UseVisualStyleBackColor = true;
            this.btnresimekle.Click += new System.EventHandler(this.btnresimekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Malzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblrenk);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.lbltaban);
            this.Controls.Add(this.txttaban);
            this.Controls.Add(this.lblcilt);
            this.Controls.Add(this.cmbcilt);
            this.Controls.Add(this.btnresimkapat);
            this.Controls.Add(this.btnresimekle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfotograf);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Malzeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Malzemeleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stok_FormClosing);
            this.Load += new System.EventHandler(this.Malzeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblfotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnresimekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected internal System.Windows.Forms.Button btnresimkapat;
        private System.Windows.Forms.ComboBox cmbcilt;
        private System.Windows.Forms.Label lblcilt;
        private System.Windows.Forms.TextBox txttaban;
        private System.Windows.Forms.Label lbltaban;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.Label lblrenk;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.Label label3;
    }
}