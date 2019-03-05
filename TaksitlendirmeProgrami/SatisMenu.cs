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
    public partial class SatisMenu : Form
    {
        public SatisMenu()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");
        OleDbCommand komut = new OleDbCommand();

        public void  idgetir()
        {
            baglan.Open();
           OleDbCommand komut = new OleDbCommand();
            var lastId = new OleDbCommand("SELECT LAST(MusteriNo) FROM Satislar", baglan).ExecuteScalar().ToString();
            int lastid = Convert.ToInt16(lastId.ToString())+1;
            txtMusteriNo.Text = lastid.ToString();
            baglan.Close();

        }
      
        public void yenile ()
        {
            
            simpleButton1.Enabled = false;
            UrunAdi.Text = "";
            lblFiyat.Text = "-";
            LblTutar.Text = "-";
            NumericAdet.Enabled = false;
            NumericTaksit.Enabled = false;
            lbltaksit.Text = "";
            txtMusteriAdi.Text = "";
            txtMusteriSoyadi.Text = "";
            txtMusteriTelefon.Text = "";
            txtMail.Text = "";
           
            txtMusteriNo.Text = (Convert.ToInt16(txtMusteriNo.Text) + 1).ToString();
        }
        
       
     
        ErrorProvider provider= new ErrorProvider();
        ErrorProvider provider1 = new ErrorProvider();
        ErrorProvider provider2= new ErrorProvider();
        ErrorProvider provider3= new ErrorProvider();
        ErrorProvider provider4= new ErrorProvider();
        ErrorProvider provider5= new ErrorProvider();
        ErrorProvider provider6= new ErrorProvider();
        public void Bosgecilmez ()
        {

            provider1.Clear();
            provider2.Clear();
            provider3.Clear();
            provider5.Clear();
            provider6.Clear();
               
                if (UrunAdi.Text == "" )
                {
                 provider1.SetError(UrunAdi, "Ürün Adı Boş Geçilemez");

                }

                else if (txtMusteriAdi.Text == "")
                {
                    provider3.SetError(txtMusteriAdi, "Müşteri Adı Giriniz !!!");
                }
                else if (txtMusteriSoyadi.Text == "")
                {
                    provider6.SetError(txtMusteriSoyadi, "Müşteri Soyadı Giriniz !!!");
                }
                
                else if (txtMail.Text == "")
                {
                    provider4.SetError(txtMail, "Müşteri Mail Giriniz !!!");
                }
     }
       
        

        public void sat ()
        {
            DateTime dt = DateTime.Now;

            DateTime zaman = dt.AddMonths(1);
          
            baglan.Open();
         
            
            OleDbCommand komut13 = new OleDbCommand("insert into Satislar(KalanTutar,MusteriNo,MusteriAdi,MusteriSoyadi,MusteriTelefon,MusteriMail,UrunAdi,UrunAdedi,ToplamTutar,TaksitTutari,SatisTarihi,KacTaksit,TaksitTarihi,KasaNo) values('"+LblTutar.Text.ToString()+"','" + txtMusteriNo.Text.ToString() + "','" + txtMusteriAdi.Text.ToString() + "','" + txtMusteriSoyadi.Text.ToString() + "','"+txtMusteriTelefon.Text.ToString()+"','" + txtMail.Text.ToString() + "','" + UrunAdi.Text.ToString() + "','" + Convert.ToInt16(NumericAdet.Value) + "','" + LblTutar.Text + "','" + lbltaksit.Text + "','" + DateTime.Now.ToShortDateString() + "','" + Convert.ToInt16(NumericTaksit.Value) + "','" + zaman.ToString("d") + "','"+SatisKasaNo.Text+"')", baglan);
            
            komut13.ExecuteNonQuery();
            
            baglan.Close();
            NumericTaksit.Value = 1;
          
            NumericAdet.Value = 1;

           

            
            
            yenile();
        }
         public int a ;       
        private void SatisMenu_Load(object sender, EventArgs e)
        {
            

           


            simpleButton1.Enabled = false; 
            idgetir();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "SELECT * FROM Stok";
            OleDbDataReader oku;
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                UrunAdi.Items.Add(oku["UrunAdi"]);

            }
            baglan.Close();

        }
         private void timer1_Tick(object sender, EventArgs e)
        {
            Timerdate.Text = DateTime.Now.ToLongDateString();
            TimerSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void UrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            simpleButton1.Enabled = true;
            provider1.Clear();
            NumericAdet.Value = 1;
            NumericTaksit.Value = 1;
            NumericAdet.Enabled = true;
            NumericTaksit.Enabled = true;            
            baglan.Close();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select *from Stok where UrunAdi='" + UrunAdi.Text +"'", baglan);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read() )
            {
                lblFiyat.Text = dr["UrunFiyati"].ToString();
                lbladet.Text = dr["UrunAdedi"].ToString();
                lblStokNo.Text = dr["StokNo"].ToString();             
            }
            baglan.Close();
            try
            {
                if (Convert.ToInt16(lbladet.Text) < 0)
                {
                    MessageBox.Show("Urun Stokta Bulunmamaktadır!!! ", "Bildirim Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UrunAdi.ResetText();
                    yenile();
                   
                }
            }
            catch (Exception)
            {

                int tutar = Convert.ToInt16(NumericAdet.Value) * Convert.ToInt16(lblFiyat.Text);
                LblTutar.Text = tutar.ToString();
                double taksit = Convert.ToDouble(tutar) / Convert.ToDouble(NumericTaksit.Value);
                lbltaksit.Text = taksit.ToString();
            }
            
        }

        private void NumericAdet_ValueChanged(object sender, EventArgs e)
        {
            provider2.Clear();
            NumericAdet.Maximum = Convert.ToInt16(lbladet.Text);

            double tutar = Convert.ToDouble(NumericAdet.Value) * Convert.ToDouble(lblFiyat.Text);
            LblTutar.Text = tutar.ToString();
            double taksit = Convert.ToDouble(tutar) / Convert.ToDouble(NumericTaksit.Value);
            lbltaksit.Text = taksit.ToString();
           
        }

        private void NumericTaksit_ValueChanged(object sender, EventArgs e)
        {
            
            NumericTaksit.Maximum = 12;
           
            int tutar = Convert.ToInt16(NumericAdet.Value) * Convert.ToInt16(lblFiyat.Text);
            LblTutar.Text = tutar.ToString();
            double taksit = Convert.ToDouble(tutar) / Convert.ToDouble(NumericTaksit.Value);
            lbltaksit.Text = taksit.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (UrunAdi.Text==""  || txtMusteriAdi.Text=="" || txtMusteriSoyadi.Text=="" || txtMusteriTelefon.Text=="" || txtMail.Text==""  )
                {
                    MessageBox.Show("Girdilere Tekrar Kontrol Ediniz Satis Yapilamadi", "Uyarı Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             
                  else
                {
                   
                    DialogResult result= MessageBox.Show("Sayın "+txtMusteriAdi.Text+" "+txtMusteriSoyadi.Text+" Almış Olacağınız "+LblTutar.Text+" Tl Değerindeki "+NumericAdet.Value+" adet "+UrunAdi.Text+" Alışverişi Onaylıyormusunuz...","Bildirim Penceresi",MessageBoxButtons.OKCancel,MessageBoxIcon.Question  );

                    if(result==DialogResult.OK)
                    { 
                    
                    int adet = Convert.ToInt16(lbladet.Text);
                    int kalan = adet - Convert.ToInt16(NumericAdet.Value);
                    lbladet.Text = kalan.ToString();
                    baglan.Open();
                    komut.CommandText = "update Stok set UrunAdedi='" + kalan.ToString() + "'where StokNo='" + lblStokNo.Text + "'";
                    komut.ExecuteNonQuery();
                    baglan.Close();
                       
                        sat();
                        
                    }
                    else
                    {

                    }
                }

            }
            catch (Exception)
            {
            }
                   }

        private void UrunAdi_Validated(object sender, EventArgs e)
        {
            if (UrunAdi.Text == "")
            {
                provider1.SetError(UrunAdi, "Ürün Adı Boş Geçilemez");
            }
        }
        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            provider3.Clear();
        }
        private void txtMusteriAdi_Validated(object sender, EventArgs e)
        {
            if (txtMusteriAdi.Text == "")
            {
                provider3.SetError(txtMusteriAdi, "Müşteri Adı Giriniz !!!");
            }
        }
        private void txtMusteriSoyadi_Validating(object sender, CancelEventArgs e)
        {            
            if (txtMusteriSoyadi.Text == "")
            {
                provider6.SetError(txtMusteriSoyadi, "Müşteri Soyadı Giriniz !!!");
            }
        }
       private void txtMail_TextChanged(object sender, EventArgs e)
        {
            provider4.Clear();
        }
        private void txtMusteriSoyadi_TextChanged(object sender, EventArgs e)
        {
            provider6.Clear();
        }
        private void txtMusteriTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            provider5.Clear();
        }
        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            if (txtMail.Text == "")
            {
                provider4.SetError(txtMail, "Müşteri Mail Giriniz !!!");
            }
        }
        private void lblUrunAdi_Click(object sender, EventArgs e)
        {
            UrunAdi.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            NumericAdet.Focus();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            NumericTaksit.Focus();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            txtMusteriAdi.Focus();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            txtMusteriSoyadi.Focus();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            txtMusteriTelefon.Focus();
        }
        private void MusteriMail_Click(object sender, EventArgs e)
        {
            txtMail.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKasiyerGiris giris = new FrmKasiyerGiris();
            giris.Show();
            this.Hide();
        }

        private void txtMusteriNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmSatisiptal iptal = new FrmSatisiptal();
            this.Hide();
            iptal.Show();
          

          
        }
    }
}