namespace TaksitlendirmeProgrami
{
    partial class FrmAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.BtnKasiyerEkle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSatis = new DevExpress.XtraEditors.SimpleButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKasiyerEkle
            // 
            this.BtnKasiyerEkle.Appearance.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.BtnKasiyerEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnKasiyerEkle.Appearance.Options.UseFont = true;
            this.BtnKasiyerEkle.Appearance.Options.UseForeColor = true;
            this.BtnKasiyerEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.BtnKasiyerEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasiyerEkle.ImageOptions.Image")));
            this.BtnKasiyerEkle.Location = new System.Drawing.Point(165, 42);
            this.BtnKasiyerEkle.Name = "BtnKasiyerEkle";
            this.BtnKasiyerEkle.Size = new System.Drawing.Size(221, 50);
            this.BtnKasiyerEkle.TabIndex = 0;
            this.BtnKasiyerEkle.Text = "Kasiyer Ekle";
            this.BtnKasiyerEkle.Click += new System.EventHandler(this.BtnKasiyerEkle_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(165, 108);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(221, 50);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Stoktakiler";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Appearance.Font = new System.Drawing.Font("Sitka Text", 16F, System.Drawing.FontStyle.Bold);
            this.btnSatis.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSatis.Appearance.Options.UseFont = true;
            this.btnSatis.Appearance.Options.UseForeColor = true;
            this.btnSatis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnSatis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatis.ImageOptions.Image")));
            this.btnSatis.Location = new System.Drawing.Point(165, 177);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(221, 50);
            this.btnSatis.TabIndex = 2;
            this.btnSatis.Text = "Satış Görüntüle";
            this.btnSatis.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 56);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(479, 284);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnKasiyerEkle);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa ";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnKasiyerEkle;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnSatis;
        private System.Windows.Forms.Button button2;
    }
}