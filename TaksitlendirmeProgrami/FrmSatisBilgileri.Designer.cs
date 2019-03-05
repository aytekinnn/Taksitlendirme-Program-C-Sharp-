namespace TaksitlendirmeProgrami
{
    partial class FrmSatisBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatisBilgileri));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.Lblgunlukciro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TimerSaat = new System.Windows.Forms.Label();
            this.Timerdate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGizliTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamCiro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericKasaNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGizliKasaNo = new System.Windows.Forms.Label();
            this.checkTaksitVakti = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericKasaNo)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkCyan;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Adı,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader2,
            this.columnHeader13});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.Red;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(-2, 159);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1222, 372);
            this.listView1.TabIndex = 0;
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
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mail";
            this.columnHeader5.Width = 172;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ürün Adı";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adet";
            this.columnHeader7.Width = 53;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tutar";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "İlkTaksitTutar";
            this.columnHeader9.Width = 131;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Satış Tarihi";
            this.columnHeader10.Width = 48;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Taksit";
            this.columnHeader11.Width = 0;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "TaksitTarih";
            this.columnHeader12.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "K.No";
            this.columnHeader2.Width = 14;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "KalanTutar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(443, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 32);
            this.label13.TabIndex = 63;
            this.label13.Text = "TL";
            // 
            // Lblgunlukciro
            // 
            this.Lblgunlukciro.AutoSize = true;
            this.Lblgunlukciro.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblgunlukciro.Location = new System.Drawing.Point(317, 18);
            this.Lblgunlukciro.Name = "Lblgunlukciro";
            this.Lblgunlukciro.Size = new System.Drawing.Size(24, 32);
            this.Lblgunlukciro.TabIndex = 62;
            this.Lblgunlukciro.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(111, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 32);
            this.label9.TabIndex = 61;
            this.label9.Text = "Günlük Ciro:";
            // 
            // TimerSaat
            // 
            this.TimerSaat.AutoSize = true;
            this.TimerSaat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerSaat.ForeColor = System.Drawing.Color.Black;
            this.TimerSaat.Location = new System.Drawing.Point(1003, 47);
            this.TimerSaat.Name = "TimerSaat";
            this.TimerSaat.Size = new System.Drawing.Size(90, 23);
            this.TimerSaat.TabIndex = 65;
            this.TimerSaat.Text = "Ürün Adı:";
            // 
            // Timerdate
            // 
            this.Timerdate.AutoSize = true;
            this.Timerdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timerdate.ForeColor = System.Drawing.Color.Black;
            this.Timerdate.Location = new System.Drawing.Point(939, 9);
            this.Timerdate.Name = "Timerdate";
            this.Timerdate.Size = new System.Drawing.Size(90, 23);
            this.Timerdate.TabIndex = 64;
            this.Timerdate.Text = "Ürün Adı:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGizliTarih
            // 
            this.lblGizliTarih.AutoSize = true;
            this.lblGizliTarih.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGizliTarih.ForeColor = System.Drawing.Color.Black;
            this.lblGizliTarih.Location = new System.Drawing.Point(976, 122);
            this.lblGizliTarih.Name = "lblGizliTarih";
            this.lblGizliTarih.Size = new System.Drawing.Size(90, 23);
            this.lblGizliTarih.TabIndex = 66;
            this.lblGizliTarih.Text = "Ürün Adı:";
            this.lblGizliTarih.Visible = false;
            this.lblGizliTarih.Click += new System.EventHandler(this.lblGizliTarih_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(443, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 32);
            this.label1.TabIndex = 69;
            this.label1.Text = "TL";
            // 
            // lblToplamCiro
            // 
            this.lblToplamCiro.AutoSize = true;
            this.lblToplamCiro.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCiro.Location = new System.Drawing.Point(317, 78);
            this.lblToplamCiro.Name = "lblToplamCiro";
            this.lblToplamCiro.Size = new System.Drawing.Size(24, 32);
            this.lblToplamCiro.TabIndex = 68;
            this.lblToplamCiro.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 67;
            this.label3.Text = "Toplam Satış:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(696, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 30);
            this.dateTimePicker1.TabIndex = 70;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(517, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 71;
            this.label2.Text = "Tarih Seçin:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(12, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 56);
            this.button2.TabIndex = 72;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericKasaNo
            // 
            this.numericKasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericKasaNo.Location = new System.Drawing.Point(696, 78);
            this.numericKasaNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKasaNo.Name = "numericKasaNo";
            this.numericKasaNo.Size = new System.Drawing.Size(140, 30);
            this.numericKasaNo.TabIndex = 73;
            this.numericKasaNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericKasaNo.ValueChanged += new System.EventHandler(this.numericKasaNo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(517, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 74;
            this.label4.Text = "Kasa No:";
            // 
            // lblGizliKasaNo
            // 
            this.lblGizliKasaNo.AutoSize = true;
            this.lblGizliKasaNo.Location = new System.Drawing.Point(649, 140);
            this.lblGizliKasaNo.Name = "lblGizliKasaNo";
            this.lblGizliKasaNo.Size = new System.Drawing.Size(35, 13);
            this.lblGizliKasaNo.TabIndex = 75;
            this.lblGizliKasaNo.Text = "label5";
            this.lblGizliKasaNo.Visible = false;
            // 
            // checkTaksitVakti
            // 
            this.checkTaksitVakti.AutoSize = true;
            this.checkTaksitVakti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTaksitVakti.ForeColor = System.Drawing.Color.Red;
            this.checkTaksitVakti.Location = new System.Drawing.Point(306, 124);
            this.checkTaksitVakti.Name = "checkTaksitVakti";
            this.checkTaksitVakti.Size = new System.Drawing.Size(293, 29);
            this.checkTaksitVakti.TabIndex = 76;
            this.checkTaksitVakti.Text = "Taksiti Geçenleri Görüntüle";
            this.checkTaksitVakti.UseVisualStyleBackColor = true;
            this.checkTaksitVakti.CheckedChanged += new System.EventHandler(this.checkTaksitVakti_CheckedChanged);
            // 
            // FrmSatisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 534);
            this.Controls.Add(this.checkTaksitVakti);
            this.Controls.Add(this.lblGizliKasaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericKasaNo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplamCiro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGizliTarih);
            this.Controls.Add(this.TimerSaat);
            this.Controls.Add(this.Timerdate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Lblgunlukciro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSatisBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Bilgileri";
            this.Load += new System.EventHandler(this.FrmSatisBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericKasaNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label Lblgunlukciro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TimerSaat;
        private System.Windows.Forms.Label Timerdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGizliTarih;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblToplamCiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NumericUpDown numericKasaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGizliKasaNo;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox checkTaksitVakti;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}