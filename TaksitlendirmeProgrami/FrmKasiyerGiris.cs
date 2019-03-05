using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TaksitlendirmeProgrami
{
    public partial class FrmKasiyerGiris : Form
    {
        public FrmKasiyerGiris()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");

        Random rastgele = new Random();
        int GirisHakki = 3;

        private void yenile()
        {
            string[] dizi = { "q", "w", "e", "r", "t", "y", "u", "ı", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "i", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "#", "%" };
            string karakter1 = dizi[rastgele.Next(0, dizi.Length)];
            string karakter2 = dizi[rastgele.Next(0, dizi.Length)];
            string karakter3 = dizi[rastgele.Next(0, dizi.Length)];
            string karakter4 = dizi[rastgele.Next(0, dizi.Length)];
            string karakter5 = dizi[rastgele.Next(0, dizi.Length)];
            string kod = karakter1 + karakter2 + karakter3 + karakter4 + karakter5;
            lblKontrol.Text = kod.ToString();
        }
        private void FrmKasiyerGiris_Load(object sender, EventArgs e)
        {
            yenile();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSecenek secenek = new FrmSecenek();
            this.Hide();
            secenek.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtKasano.Focus();
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
        }

        private void lblParola_Click(object sender, EventArgs e)
        {
            txtParola.Focus();
        }

        private void lblGvnlk_Click(object sender, EventArgs e)
        {
            txtKontrol.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAkanYazi.Text = lblAkanYazi.Text.Substring(1) + lblAkanYazi.Text.Substring(0, 1);
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            

            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select *from KasiyerBilgileri where KasaNo='" + txtKasano.Text + "'and KasiyerAdi='" + txtKullaniciAdi.Text + "'and KasiyerSifre='" + txtParola.Text + "'", baglan);
            OleDbDataReader dr = komut.ExecuteReader();


            if (dr.Read() && txtKontrol.Text == lblKontrol.Text)
            {

                SatisMenu satis = new SatisMenu();
                this.Hide();
                satis.Show();
                satis.SatisKasaNo.Text = txtKasano.Text;
               
                
            }

            else
            {
                GirisHakki--;
                yenile();
                MessageBox.Show("               Bilgilerde Hata Var Tekrar Deneyiniz!!!!       \n\n\n                         Kalan Hakkınız   :  " + GirisHakki.ToString() + "", "Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtKasano.Text = "";
                txtKontrol.Text = "";
                txtKullaniciAdi.Text = "";
                txtParola.Text = "";
                if (GirisHakki == 0)
                {
                    MessageBox.Show("Bilgiler Hatalı Olduğu için Uygulama Kapanacak", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

            }


            baglan.Close();
            if(txtKasano.Text!="")
            {
                baglan.Open();
                komut.CommandText = "update giris set giris='" +txtKasano.Text.ToString()+ "'where id='" +Convert.ToInt16(0).ToString() + "'";
                komut.ExecuteNonQuery();
                baglan.Close();

            }
        }
    
        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
