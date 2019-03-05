using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaksitlendirmeProgrami
{
    public partial class FrmSecenek : Form
    {
        public FrmSecenek()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAkanYazi.Text = lblAkanYazi.Text.Substring(1) + lblAkanYazi.Text.Substring(0, 1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            this.Hide();
            admin.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmKasiyerGiris kasiyer = new FrmKasiyerGiris();
            kasiyer.Show();
            this.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         var result=   MessageBox.Show("Çıkış Yapmak İstediğinizden Emin misiniz ??", "Mesaj Uyarısı", MessageBoxButtons.YesNo);
            if (result== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Makü Taksit Programı: 24.11.2017\nKodlayan: Rifai KUÇİ\n Sürüm :1.0.1", "Hakkımızda",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmSecenek_Load(object sender, EventArgs e)
        {

        }
    }
}
