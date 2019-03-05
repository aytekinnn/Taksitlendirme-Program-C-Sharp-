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
    public partial class FrmSatisBilgileri : Form
    {
        public FrmSatisBilgileri()
        {
            InitializeComponent();
        }
        public void renklendir ()
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].ForeColor = Color.White;
                sayac++;
                if (sayac % 2 != 0)
                {
                    listView1.Items[i].BackColor = Color.SeaGreen;
                }
                else
                    listView1.Items[i].BackColor = Color.LightCoral;

            }
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");
        OleDbCommand komut = new OleDbCommand();
        double toplamGunlukCiro = 0, ToplamCiro = 0;
        int sayac = 0;
        private void FrmSatisBilgileri_Load(object sender, EventArgs e)
        {
            numericKasaNo.ResetText();
            toplamGunlukCiro = 0;
            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select *from Satislar", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
               

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriNo"].ToString();
                ekle.SubItems.Add(oku["MusteriAdi"].ToString());
                ekle.SubItems.Add(oku["MusteriSoyadi"].ToString());
                ekle.SubItems.Add(oku["MusteriTelefon"].ToString());
                ekle.SubItems.Add(oku["MusteriMail"].ToString());
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                ekle.SubItems.Add(oku["TaksitTutari"].ToString());
                ekle.SubItems.Add(oku["SatisTarihi"].ToString());
                ekle.SubItems.Add(oku["KacTaksit"].ToString());
                ekle.SubItems.Add(oku["TaksitTarihi"].ToString());
                ekle.SubItems.Add(oku["KasaNo"].ToString());
                ekle.SubItems.Add(oku["KalanTutar"].ToString());

            


                listView1.Items.Add(ekle);
            }
            baglan.Close();





            for (int i = 0; i < listView1.Items.Count; i++)
            {
                toplamGunlukCiro += Convert.ToDouble(listView1.Items[i].SubItems[7].Text.ToString());

            }
            lblToplamCiro.Text = toplamGunlukCiro.ToString();


            renklendir();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Timerdate.Text = DateTime.Now.ToLongDateString();
            TimerSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblGizliTarih_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnasayfa anasayfa = new FrmAnasayfa();
            this.Hide();
            anasayfa.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericKasaNo_ValueChanged(object sender, EventArgs e)
        {
            
            
            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select *from Satislar where KasaNo='"+Convert.ToInt16(numericKasaNo.Value)+"'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriNo"].ToString();
                ekle.SubItems.Add(oku["MusteriAdi"].ToString());
                ekle.SubItems.Add(oku["MusteriSoyadi"].ToString());
                ekle.SubItems.Add(oku["MusteriTelefon"].ToString());
                ekle.SubItems.Add(oku["MusteriMail"].ToString());
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                ekle.SubItems.Add(oku["TaksitTutari"].ToString());
                ekle.SubItems.Add(oku["SatisTarihi"].ToString());
                ekle.SubItems.Add(oku["KacTaksit"].ToString());
                ekle.SubItems.Add(oku["TaksitTarihi"].ToString());
                ekle.SubItems.Add(oku["KasaNo"].ToString());



                listView1.Items.Add(ekle);
            }
            baglan.Close();
            lblGizliTarih.Text = DateTime.Now.ToShortDateString();
            

            
           
            if(numericKasaNo.Value==0)
            {
                toplamGunlukCiro = 0;
                ToplamCiro = 0;
                numericKasaNo.ResetText();

                listView1.Items.Clear();
                baglan.Open();
                OleDbCommand komut2 = new OleDbCommand("Select *from Satislar whrere KasaNo='"+Convert.ToInt16(numericKasaNo.Value)+"'", baglan);
                OleDbDataReader oku2 = komut2.ExecuteReader();
                while (oku2.Read())
                {

                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku2["MusteriNo"].ToString();
                    ekle.SubItems.Add(oku2["MusteriAdi"].ToString());
                    ekle.SubItems.Add(oku2["MusteriSoyadi"].ToString());
                    ekle.SubItems.Add(oku2["MusteriTelefon"].ToString());
                    ekle.SubItems.Add(oku2["MusteriMail"].ToString());
                    ekle.SubItems.Add(oku2["UrunAdi"].ToString());
                    ekle.SubItems.Add(oku2["UrunAdedi"].ToString());
                    ekle.SubItems.Add(oku2["ToplamTutar"].ToString());
                    ekle.SubItems.Add(oku2["TaksitTutari"].ToString());
                    ekle.SubItems.Add(oku2["SatisTarihi"].ToString());
                    ekle.SubItems.Add(oku2["KacTaksit"].ToString());
                    ekle.SubItems.Add(oku2["TaksitTarihi"].ToString());
                    ekle.SubItems.Add(oku2["KasaNo"].ToString());
                    ekle.SubItems.Add(oku2["KalanTutar"].ToString());




                    listView1.Items.Add(ekle);
                }
                baglan.Close();


              
               

            }


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].ForeColor = Color.White;
                sayac++;
                if (sayac % 2 != 0)
                {
                    listView1.Items[i].BackColor = Color.SeaGreen;
                }
                else
                    listView1.Items[i].BackColor = Color.LightCoral;

            }
            renklendir();
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            double bekleneTutar = 0;
           
            OleDbCommand komut = new OleDbCommand("Select *From Satislar ",baglan);
           
           OleDbDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriNo"].ToString();
                ekle.SubItems.Add(oku["MusteriAdi"].ToString());
                ekle.SubItems.Add(oku["MusteriSoyadi"].ToString());
                ekle.SubItems.Add(oku["MusteriTelefon"].ToString());
                ekle.SubItems.Add(oku["MusteriMail"].ToString());
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                ekle.SubItems.Add(oku["TaksitTutari"].ToString());
                ekle.SubItems.Add(oku["SatisTarihi"].ToString());
                ekle.SubItems.Add(oku["KacTaksit"].ToString());
                ekle.SubItems.Add(oku["TaksitTarihi"].ToString());
                ekle.SubItems.Add(oku["KasaNo"].ToString());
                ekle.SubItems.Add(oku["KalanTutar"].ToString());
                string zaman1 = dateTimePicker1.Value.ToString();
                string[] a2 = zaman1.Split();
                string zaman2 = oku["TaksitTarihi"].ToString();
                string[] a3 = zaman2.Split();
                if (a2[0].ToString()==a3[0].ToString() && numericKasaNo.Value.ToString()==oku["KasaNo"].ToString())
                {

                    listView1.Items.Add(ekle);
                }
            }
            baglan.Close();
            
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bekleneTutar+=Convert.ToDouble(listView1.Items[i].SubItems[8].Text.ToString());
               
            }
            Lblgunlukciro.Text = bekleneTutar.ToString();
            renklendir();
           

    
        }
        int id = 0;

        private void checkTaksitVakti_CheckedChanged(object sender, EventArgs e)
        {
            double taksitGecen=0;
            if(checkTaksitVakti.Checked==true)
            {
                
                numericKasaNo.ResetText();

                listView1.Items.Clear();
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("Select *from Satislar where TaksitTarihi < NOW()", baglan);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {

                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["MusteriNo"].ToString();
                    ekle.SubItems.Add(oku["MusteriAdi"].ToString());
                    ekle.SubItems.Add(oku["MusteriSoyadi"].ToString());
                    ekle.SubItems.Add(oku["MusteriTelefon"].ToString());
                    ekle.SubItems.Add(oku["MusteriMail"].ToString());
                    ekle.SubItems.Add(oku["UrunAdi"].ToString());
                    ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                    ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                    ekle.SubItems.Add(oku["TaksitTutari"].ToString());
                    ekle.SubItems.Add(oku["SatisTarihi"].ToString());
                    ekle.SubItems.Add(oku["KacTaksit"].ToString());
                    ekle.SubItems.Add(oku["TaksitTarihi"].ToString());
                    ekle.SubItems.Add(oku["KasaNo"].ToString());
                    ekle.SubItems.Add(oku["KalanTutar"].ToString());



                    listView1.Items.Add(ekle);
                }
                baglan.Close();

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                   taksitGecen+= Convert.ToDouble(listView1.Items[i].SubItems[8].Text.ToString());

                }
                label9.Text = "Taksit Tutar:";
                Lblgunlukciro.Text = taksitGecen.ToString();
                
                renklendir();
            }
            if (checkTaksitVakti.Checked == false)
            {
                label9.Text = "Günlük Ciro :";
                Lblgunlukciro.Text = "-";
                numericKasaNo.ResetText();

                listView1.Items.Clear();
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("Select *from Satislar ", baglan);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {

                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["MusteriNo"].ToString();
                    ekle.SubItems.Add(oku["MusteriAdi"].ToString());
                    ekle.SubItems.Add(oku["MusteriSoyadi"].ToString());
                    ekle.SubItems.Add(oku["MusteriTelefon"].ToString());
                    ekle.SubItems.Add(oku["MusteriMail"].ToString());
                    ekle.SubItems.Add(oku["UrunAdi"].ToString());
                    ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                    ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                    ekle.SubItems.Add(oku["TaksitTutari"].ToString());
                    ekle.SubItems.Add(oku["SatisTarihi"].ToString());
                    ekle.SubItems.Add(oku["KacTaksit"].ToString());
                    ekle.SubItems.Add(oku["TaksitTarihi"].ToString());
                    ekle.SubItems.Add(oku["KasaNo"].ToString());
                    ekle.SubItems.Add(oku["KalanTutar"].ToString());



                    listView1.Items.Add(ekle);
                }
                baglan.Close();


                lblGizliTarih.Text = DateTime.Now.ToShortDateString();


              
                renklendir();
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmOdemeOnay onay = new FrmOdemeOnay();
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            onay.txtMusteriNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            onay.txtMusteriAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            onay.txtMusteriSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;

            onay.txtUrunAdi.Text = listView1.SelectedItems[0].SubItems[5].Text;
            onay.lblTaksitTarihi.Text = listView1.SelectedItems[0].SubItems[11].Text;
            onay.lblSatisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            onay.txtMusteriAdet.Text = listView1.SelectedItems[0].SubItems[6].Text;
            onay.lblToplam.Text= listView1.SelectedItems[0].SubItems[7].Text;
            onay.txtTaksitTutari.Text = listView1.SelectedItems[0].SubItems[8].Text;
            onay.txtOdenecekTutar.Text = listView1.SelectedItems[0].SubItems[8].Text;
            onay.txtMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            onay.txtKalan.Text = listView1.SelectedItems[0].SubItems[13].Text;
            onay.lblKalanTutar.Text = listView1.SelectedItems[0].SubItems[13].Text;

            onay.radioOdendi.Checked = false;
            onay.radioOdenmedi.Checked = false;
            onay.Show();
            this.Hide();
        }
    }
}
