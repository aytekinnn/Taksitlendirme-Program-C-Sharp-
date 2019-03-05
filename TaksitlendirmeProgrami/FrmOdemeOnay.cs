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
using System.Net;
using System.Net.Mail;



namespace TaksitlendirmeProgrami
{
    public partial class FrmOdemeOnay : Form
    {
        public FrmOdemeOnay()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");
        OleDbCommand komut = new OleDbCommand();

        FrmSatisBilgileri satisbilgileri = new FrmSatisBilgileri();
        
        private void FrmOdemeOnay_Load(object sender, EventArgs e)
        {

        }

        private void radioOdendi_CheckedChanged(object sender, EventArgs e)
        {
            if(radioOdenmedi.Checked)
            {
                BtnMailGonder.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtTaksitTutari.Text = txtOdenecekTutar.Text;
        }

        private void radioOdenmedi_CheckedChanged(object sender, EventArgs e)
        {
            if(radioOdenmedi.Checked==true)
            {
                BtnMailGonder.Visible = true;
            }
            else
            {
                BtnMailGonder.Visible = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtOdenecekTutar.Text) > Convert.ToInt16(txtKalan.Text) )
                {
                    MessageBox.Show("Kalan Tutar'dan Fazla Değer Girdiniz","",MessageBoxButtons.OKCancel);
                    txtOdenecekTutar.Text = "";
                    txtKalan.Text = lblKalanTutar.Text;
                    txtOdenecekTutar.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                txtOdenecekTutar.Text = "";
                txtOdenecekTutar.Focus();
            }
        }
        double OdenecekTutar=0,kalanTutar=0;
        string durum = "Zamanında";

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSatisBilgileri satis = new FrmSatisBilgileri();
            satis.Show();
            this.Hide();
        }

        private void BtnMailGonder_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesajim = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential("rfai4747@hotmail.com", "mardin47");
                istemci.Port = 587;
                istemci.Host = "smtp.live.com";
                istemci.EnableSsl = true;
                mesajim.To.Add(txtMail.Text);
                mesajim.From = new MailAddress("rfai4747@hotmail.com");
                mesajim.Subject = "Makü Taksit Bilgilendirme";
                mesajim.Body = "Sayın " + txtMusteriAd.Text + " " + txtMusteriSoyad.Text + " " + txtTaksitTutari.Text + " " + lblTaksitTarihi.Text + " TL tutarındaki Taksidiniz Gecikmistir";
                istemci.Send(mesajim);
                MessageBox.Show("Mail Başarılı Bir Şekilde Gönderildi", "Bildirim Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception)
            {

                MessageBox.Show("Mail Gönderilmedi İnternet Bağlantısını Kontrol Ediniz..", "Bildirim Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {





            
            DialogResult result = MessageBox.Show(" Sayın " + txtMusteriAd.Text + " " + txtMusteriSoyad.Text + " " + txtOdenecekTutar.Text + " Tl  Ödemeyi Onaylıyormusunuz?"," Bildirim Penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
            if (result==DialogResult.OK && Convert.ToDouble(txtKalan.Text)>=Convert.ToDouble(txtOdenecekTutar.Text))
            {
                OdenecekTutar = Convert.ToDouble(txtOdenecekTutar.Text);
                kalanTutar = Convert.ToDouble(txtKalan.Text) - OdenecekTutar;
                txtKalan.Text = kalanTutar.ToString();


                string zaman = lblTaksitTarihi.Text;
                string[] dizi = zaman.Split(' ');
                zaman = dizi[0];
                
                int deger = DateTime.Compare( Convert.ToDateTime(zaman.ToString()), Convert.ToDateTime(DateTime.Now.ToShortDateString()));
               
                if(deger==-1)
                {
                    durum = "Gecikmeli";
                }


                lblKalanTutar.Text = txtKalan.Text;


                if (Convert.ToDouble(txtKalan.Text)==0)
                {
                   
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into OdemesiTamamlananMusteriler(MusteriNo,MusteriAdi,MusteriSoyadi,MusteriToplamTutar,MusteriOdemeDurumu,UrunAdi,SonUrunTarihi,Mail) values('" + txtMusteriNo.Text.ToString() + "','" +txtMusteriAd.Text.ToString() + "','" + txtMusteriSoyad.Text.ToString() + "','" + lblToplam.Text.ToString() + "','" + durum.ToString() + "','" +txtUrunAdi.Text.ToString() + "','" + lblSatisTarihi.Text.ToString() + "','"+txtMail.Text.ToString()+"')", baglan);
                    MessageBox.Show("Borcunuz Kalmamıştır Bizi Tercih Ettiğiniz İçin Teşekkür Ederiz","Bildirim Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    komut.ExecuteNonQuery();

                    komut = new OleDbCommand("Delete from Satislar where MusteriNo='" + txtMusteriNo.Text + "'", baglan);
                    komut.ExecuteNonQuery();
                    
                    
                    baglan.Close();
                }
                else
                {
                    DateTime tarih;
                    tarih = DateTime.Parse(lblTaksitTarihi.Text).AddMonths(1);

                  


                    baglan.Open();
                    komut.Connection = baglan;
                    komut.CommandText = "update Satislar set KalanTutar='" + lblKalanTutar.Text.ToString() + "',TaksitTarihi='" + tarih.ToString()+"' where MusteriNo='" + txtMusteriNo.Text + "'";
                    komut.ExecuteNonQuery();
                    baglan.Close();
                }
               
              
            }
        }
    }
}
