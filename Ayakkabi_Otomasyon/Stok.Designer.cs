
namespace Ayakkabi_Otomasyon
{
    partial class Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtDesi = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblDesi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // btntemizle
            // 
            this.btntemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntemizle.ImageIndex = 3;
            this.btntemizle.ImageList = this.ımageList1;
            this.btntemizle.Location = new System.Drawing.Point(143, 426);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(81, 33);
            this.btntemizle.TabIndex = 37;
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
            this.btnsil.TabIndex = 36;
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
            this.btnguncelle.Location = new System.Drawing.Point(143, 389);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(81, 32);
            this.btnguncelle.TabIndex = 35;
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
            this.btnekle.TabIndex = 34;
            this.btnekle.Text = "Ekle";
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackgroundImage = global::Ayakkabi_Otomasyon.Properties.Resources.back;
            this.btngeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngeri.Location = new System.Drawing.Point(12, 469);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(30, 30);
            this.btngeri.TabIndex = 38;
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(263, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 426);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 222);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 40;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(108, 267);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 40;
            // 
            // txtDesi
            // 
            this.txtDesi.Location = new System.Drawing.Point(108, 312);
            this.txtDesi.Name = "txtDesi";
            this.txtDesi.Size = new System.Drawing.Size(100, 20);
            this.txtDesi.TabIndex = 40;
            this.txtDesi.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Enabled = false;
            this.lblID.Location = new System.Drawing.Point(67, 135);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 41;
            this.lblID.Text = "ID :";
            this.lblID.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(108, 132);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 40;
            this.txtID.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(16, 180);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(75, 13);
            this.lblTip.TabIndex = 42;
            this.lblTip.Text = "Malzeme Tipi :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 225);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(71, 13);
            this.lblAd.TabIndex = 42;
            this.lblAd.Text = "Malzeme Ad :";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(56, 270);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(35, 13);
            this.lblAdet.TabIndex = 42;
            this.lblAdet.Text = "Adet :";
            // 
            // lblDesi
            // 
            this.lblDesi.AutoSize = true;
            this.lblDesi.Location = new System.Drawing.Point(56, 315);
            this.lblDesi.Name = "lblDesi";
            this.lblDesi.Size = new System.Drawing.Size(34, 13);
            this.lblDesi.TabIndex = 42;
            this.lblDesi.Text = "Desi :";
            this.lblDesi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kullanıcı:";
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.Location = new System.Drawing.Point(733, 486);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(35, 13);
            this.lblkullanici.TabIndex = 43;
            this.lblkullanici.Text = "label1";
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(108, 177);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(100, 21);
            this.cmbTip.TabIndex = 45;
            this.cmbTip.DropDown += new System.EventHandler(this.cmbTip_DropDown);
            this.cmbTip.SelectedIndexChanged += new System.EventHandler(this.cmbTip_SelectedIndexChanged);
            this.cmbTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTip_KeyPress);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.lblDesi);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtDesi);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Stokları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stok_FormClosing);
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtDesi;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblDesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.ComboBox cmbTip;
    }
}