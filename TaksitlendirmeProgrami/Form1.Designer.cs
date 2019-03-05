namespace TaksitlendirmeProgrami
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblGvnlk = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKontrol = new System.Windows.Forms.TextBox();
            this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.lblKontrol = new System.Windows.Forms.Label();
            this.lblAkanYazi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(71, 71);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(117, 22);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = " Kullanıcı Adı:";
            this.lblKullaniciAdi.Click += new System.EventHandler(this.lblKullaniciAdi_Click);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.ForeColor = System.Drawing.Color.Black;
            this.lblParola.Location = new System.Drawing.Point(71, 121);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(67, 22);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola :";
            this.lblParola.Click += new System.EventHandler(this.lblParola_Click);
            // 
            // lblGvnlk
            // 
            this.lblGvnlk.AutoSize = true;
            this.lblGvnlk.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGvnlk.ForeColor = System.Drawing.Color.Black;
            this.lblGvnlk.Location = new System.Drawing.Point(71, 238);
            this.lblGvnlk.Name = "lblGvnlk";
            this.lblGvnlk.Size = new System.Drawing.Size(131, 22);
            this.lblGvnlk.TabIndex = 2;
            this.lblGvnlk.Text = "Güvenlik Kodu:";
            this.lblGvnlk.Click += new System.EventHandler(this.lblGvnlk_Click);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(221, 71);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(165, 27);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(221, 119);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(165, 27);
            this.txtParola.TabIndex = 4;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // txtKontrol
            // 
            this.txtKontrol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKontrol.Location = new System.Drawing.Point(218, 236);
            this.txtKontrol.Name = "txtKontrol";
            this.txtKontrol.Size = new System.Drawing.Size(165, 27);
            this.txtKontrol.TabIndex = 5;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.BtnGiris.Appearance.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BtnGiris.Appearance.Options.UseFont = true;
            this.BtnGiris.Appearance.Options.UseForeColor = true;
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiris.ImageOptions.Image")));
            this.BtnGiris.Location = new System.Drawing.Point(221, 288);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(126, 40);
            this.BtnGiris.TabIndex = 6;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // lblKontrol
            // 
            this.lblKontrol.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblKontrol.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKontrol.Location = new System.Drawing.Point(215, 166);
            this.lblKontrol.Name = "lblKontrol";
            this.lblKontrol.Size = new System.Drawing.Size(168, 58);
            this.lblKontrol.TabIndex = 7;
            this.lblKontrol.Text = "label2";
            this.lblKontrol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAkanYazi
            // 
            this.lblAkanYazi.AutoSize = true;
            this.lblAkanYazi.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAkanYazi.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblAkanYazi.Location = new System.Drawing.Point(154, 26);
            this.lblAkanYazi.Name = "lblAkanYazi";
            this.lblAkanYazi.Size = new System.Drawing.Size(369, 33);
            this.lblAkanYazi.TabIndex = 8;
            this.lblAkanYazi.Text = " Makü Taksitlendirme Programı ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 56);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAdmin
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(564, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAkanYazi);
            this.Controls.Add(this.lblKontrol);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtKontrol);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblGvnlk);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müdür Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblGvnlk;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKontrol;
        private DevExpress.XtraEditors.SimpleButton BtnGiris;
        private System.Windows.Forms.Label lblKontrol;
        private System.Windows.Forms.Label lblAkanYazi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

