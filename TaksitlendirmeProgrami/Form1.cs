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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            yenile();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtKontrol.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E90FF");
            txtKullaniciAdi.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E90FF");
            txtParola.BackColor = System.Drawing.ColorTranslator.FromHtml("#1E90FF");
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            

            if (txtKullaniciAdi.Text != "rfai47" || txtParola.Text != "mardin47" || txtParola.Text==lblGvnlk.Text)
            {
                GirisHakki--;
                if (GirisHakki == 0)
                {
                    MessageBox.Show("Kullanıcı Adı Ve Parola Hatalı girildiğinden Dolayı Uygulama Kapanacaktır","Uyarı Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Exit();
                }

                MessageBox.Show("Kullanıcı Adı Veya Parolayı Yanlis Girdiniz Tekrar Deneyiniz!!!!  " + GirisHakki.ToString() + " Hakkınız Kaldı","Uyarı Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yenile();
                txtKontrol.Clear();
                txtKullaniciAdi.Clear();
                txtParola.Clear();      
           }

            
            if (txtKullaniciAdi.Text == "rfai47" && txtParola.Text == "mardin47" && txtKontrol.Text != lblKontrol.Text)
               {
                   MessageBox.Show("Guvenlik Anahtarini Yanlis Girdiniz!!!!");
                   yenile();
                   txtKontrol.Clear();
               }
            if (txtKullaniciAdi.Text == "rfai47" && txtParola.Text == "mardin47" && txtKontrol.Text== lblKontrol.Text)
            {
                   FrmAnasayfa anasayfa = new FrmAnasayfa();
                   this.Hide();
                   anasayfa.Show();
               }

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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSecenek secenek = new FrmSecenek();
            this.Hide();
            secenek.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            this.Hide();
            anasayfa.Show();
        }
    }
    }

