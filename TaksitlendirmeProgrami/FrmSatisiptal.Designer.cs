namespace TaksitlendirmeProgrami
{
    partial class FrmSatisiptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatisiptal));
            this.btnSatisSil = new DevExpress.XtraEditors.SimpleButton();
            this.button2 = new System.Windows.Forms.Button();
            this.Timerdate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblTutar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SatisKasaNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblKasaNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAdet = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblUrunNO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnSatisSil.Appearance.Options.UseFont = true;
            this.btnSatisSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisSil.ImageOptions.Image")));
            this.btnSatisSil.Location = new System.Drawing.Point(481, 104);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(191, 57);
            this.btnSatisSil.TabIndex = 82;
            this.btnSatisSil.Text = "Satış İade";
            this.btnSatisSil.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 56);
            this.button2.TabIndex = 74;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Timerdate
            // 
            this.Timerdate.AutoSize = true;
            this.Timerdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerdate.ForeColor = System.Drawing.Color.Black;
            this.Timerdate.Location = new System.Drawing.Point(682, -25);
            this.Timerdate.Name = "Timerdate";
            this.Timerdate.Size = new System.Drawing.Size(90, 23);
            this.Timerdate.TabIndex = 78;
            this.Timerdate.Text = "Ürün Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(677, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 32);
            this.label13.TabIndex = 77;
            this.label13.Text = "TL";
            // 
            // LblTutar
            // 
            this.LblTutar.AutoSize = true;
            this.LblTutar.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTutar.Location = new System.Drawing.Point(604, 43);
            this.LblTutar.Name = "LblTutar";
            this.LblTutar.Size = new System.Drawing.Size(24, 32);
            this.LblTutar.TabIndex = 76;
            this.LblTutar.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(398, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 32);
            this.label9.TabIndex = 75;
            this.label9.Text = "Toplam Tutar:";
            // 
            // SatisKasaNo
            // 
            this.SatisKasaNo.AutoSize = true;
            this.SatisKasaNo.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatisKasaNo.Location = new System.Drawing.Point(354, -25);
            this.SatisKasaNo.Name = "SatisKasaNo";
            this.SatisKasaNo.Size = new System.Drawing.Size(30, 32);
            this.SatisKasaNo.TabIndex = 70;
            this.SatisKasaNo.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 69;
            this.label1.Text = "Kasa No:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkCyan;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Adı,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 314);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 219);
            this.listView1.TabIndex = 83;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 38;
            // 
            // Adı
            // 
            this.Adı.Text = "Adı";
            this.Adı.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adet";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tutar";
            this.columnHeader8.Width = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(205, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 86;
            this.label4.Text = "Kasa No :";
            // 
            // lblKasaNo
            // 
            this.lblKasaNo.AutoSize = true;
            this.lblKasaNo.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaNo.Location = new System.Drawing.Point(362, 11);
            this.lblKasaNo.Name = "lblKasaNo";
            this.lblKasaNo.Size = new System.Drawing.Size(0, 32);
            this.lblKasaNo.TabIndex = 87;
            this.lblKasaNo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 88;
            this.label2.Text = "Müşteri Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 89;
            this.label3.Text = "Müşteri Ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 90;
            this.label5.Text = "Müşteri Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 91;
            this.label6.Text = "Adet";
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.BackColor = System.Drawing.Color.LightGray;
            this.txtMusteriNo.Enabled = false;
            this.txtMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(197, 74);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(187, 26);
            this.txtMusteriNo.TabIndex = 92;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.BackColor = System.Drawing.Color.LightGray;
            this.txtMusteriAd.Enabled = false;
            this.txtMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAd.Location = new System.Drawing.Point(197, 127);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(187, 26);
            this.txtMusteriAd.TabIndex = 93;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.BackColor = System.Drawing.Color.LightGray;
            this.txtMusteriSoyad.Enabled = false;
            this.txtMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriSoyad.Location = new System.Drawing.Point(197, 179);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(187, 26);
            this.txtMusteriSoyad.TabIndex = 94;
            // 
            // txtMusteriAdet
            // 
            this.txtMusteriAdet.BackColor = System.Drawing.Color.LightGray;
            this.txtMusteriAdet.Enabled = false;
            this.txtMusteriAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriAdet.Location = new System.Drawing.Point(197, 267);
            this.txtMusteriAdet.Name = "txtMusteriAdet";
            this.txtMusteriAdet.Size = new System.Drawing.Size(187, 26);
            this.txtMusteriAdet.TabIndex = 95;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.BackColor = System.Drawing.Color.LightGray;
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(197, 226);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(187, 26);
            this.txtUrunAdi.TabIndex = 97;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Himalaya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 96;
            this.label7.Text = "Ürün Adı";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(598, 201);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(38, 13);
            this.lblAdet.TabIndex = 98;
            this.lblAdet.Text = "lbladet";
            this.lblAdet.Visible = false;
            // 
            // lblUrunNO
            // 
            this.lblUrunNO.AutoSize = true;
            this.lblUrunNO.Location = new System.Drawing.Point(598, 239);
            this.lblUrunNO.Name = "lblUrunNO";
            this.lblUrunNO.Size = new System.Drawing.Size(38, 13);
            this.lblUrunNO.TabIndex = 99;
            this.lblUrunNO.Text = "lbladet";
            this.lblUrunNO.Visible = false;
            // 
            // FrmSatisiptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 545);
            this.Controls.Add(this.lblUrunNO);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMusteriAdet);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKasaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSatisSil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Timerdate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LblTutar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SatisKasaNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatisiptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatisiptal";
            this.Load += new System.EventHandler(this.FrmSatisiptal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSatisSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Timerdate;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label LblTutar;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label SatisKasaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblKasaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAdet;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUrunNO;
        public System.Windows.Forms.ListView listView1;
    }
}