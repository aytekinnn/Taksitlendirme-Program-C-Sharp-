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
    public partial class FrmSatisiptal : Form
    {
        public FrmSatisiptal()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");
        OleDbCommand komut2 = new OleDbCommand();
        int sayac = 0;
        public  void temizle ()
        {
            txtMusteriAd.Text = "";
            txtMusteriAdet.Text = "";
            txtMusteriNo.Text = "";
            txtUrunAdi.Text="";
            txtMusteriSoyad.Text = "";
            LblTutar.Text = "-";
        }
            public  void listRenklendir()
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
        private void FrmSatisiptal_Load(object sender, EventArgs e)
        {
            baglan.Open();

            OleDbCommand komut2 = new OleDbCommand("Select *from giris where id='" +Convert.ToInt16(0).ToString()+ "'", baglan);
            OleDbDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
               
                lblKasaNo.Text = dr["giris"].ToString();
            }
            baglan.Close();


            
            temizle();


            
            
                
            listView1.Items.Clear();
            baglan.Open();
           
            OleDbCommand komut = new OleDbCommand("Select *from Satislar where KasaNo='"+lblKasaNo.Text+"'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriNo"].ToString();
                ekle.SubItems.Add(oku["MusteriAdi"].ToString());
                ekle.SubItems.Add(oku["MusteriSoyadi"].ToString());
                
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());


               

                listView1.Items.Add(ekle);
            }
            
            listRenklendir();
            baglan.Close();
            
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatisMenu satis = new SatisMenu();
            satis.Show();
            this.Hide();
             
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtMusteriNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtMusteriAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtMusteriSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtUrunAdi.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMusteriAdet.Text = listView1.SelectedItems[0].SubItems[4].Text;
            LblTutar.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sayın "+txtMusteriAd.Text+" "+txtMusteriSoyad.Text+" Ürününüz iade edilmesini Onaylıyormusunuz", "Bildirim Penceresi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                baglan.Open();
                komut2.Connection = baglan;
                komut2.CommandText = "Delete from Satislar where MusteriNo='" + Convert.ToInt16(txtMusteriNo.Text.ToString()) + "'";
                komut2.ExecuteNonQuery();
                komut2.Dispose();
                baglan.Close();

                baglan.Open();
                OleDbCommand komut3 = new OleDbCommand("Select *from Stok where UrunAdi='" + txtUrunAdi.Text + "'", baglan);
                OleDbDataReader dr = komut3.ExecuteReader();
                if (dr.Read())
                {

                    lblAdet.Text = dr["UrunAdedi"].ToString();
                    lblUrunNO.Text = dr["StokNo"].ToString();

                }
                baglan.Close();
                baglan.Open();
                int adet = Convert.ToInt16(lblAdet.Text);
                int kalan = adet + Convert.ToInt16(txtMusteriAdet.Text);
                lblAdet.Text = kalan.ToString();
                komut3.CommandText = "update Stok set UrunAdedi='" + kalan.ToString() + "'where StokNo='" + lblUrunNO.Text + "'";
                komut3.ExecuteNonQuery();

                baglan.Close();
                listView1.Items.Clear();
                
                listRenklendir();
                temizle();

                
            }
        }
    }
}
