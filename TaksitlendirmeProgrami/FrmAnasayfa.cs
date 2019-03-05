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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void BtnKasiyerEkle_Click(object sender, EventArgs e)
        {
            FrmKasiyerEkle kasiyerEkle = new FrmKasiyerEkle();
            this.Hide();
            kasiyerEkle.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStok stok = new FrmStok();
            this.Hide();
            stok.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmSatisBilgileri ciro = new FrmSatisBilgileri();
            ciro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Hide();
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
