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
    public partial class FrmKasiyerEkle : Form
    {
        public FrmKasiyerEkle()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");
        OleDbCommand komut = new OleDbCommand();
        public void idgetir()
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            var lastId = new OleDbCommand("SELECT LAST(KasaNo) FROM KasiyerBilgileri", baglan).ExecuteScalar().ToString();
            int lastid = Convert.ToInt16(lastId.ToString()) + 1;
            txtKasaNo.Text = lastid.ToString();
            baglan.Close();

        }

        public void temizle ()
        {

            txtKasiyerAdi.Clear();
            txtKasiyerSifre.Clear();
            txtKasiyerSoyad.Clear();
            txtMaskedTel.Clear();
            richTextBox1.Clear();
            comboMemleket.Text = "";
            ComboOgrenim.Text = "";
            txtKasaNo.Text = "";
            idgetir();
        }

        private void goruntule()
            
        {
            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select *from KasiyerBilgileri", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["KasaNo"].ToString();
                ekle.SubItems.Add(oku["KasiyerAdi"].ToString());
                ekle.SubItems.Add(oku["KasiyerSoyadi"].ToString());
                ekle.SubItems.Add(oku["KasiyerTelefon"].ToString());
                ekle.SubItems.Add(oku["KasiyerAdres"].ToString());
                ekle.SubItems.Add(oku["KasiyerOgrenim"].ToString());
                ekle.SubItems.Add(oku["KasiyerMemleket"].ToString());

                listView1.Items.Add(ekle);
            }


            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
                }

        private void FrmKasiyerEkle_Load(object sender, EventArgs e)
        {
            idgetir();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAnasayfa admin = new FrmAnasayfa();
            this.Hide();
            admin.Show();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into KasiyerBilgileri(KasaNo,KasiyerAdi,KasiyerSoyadi,KasiyerSifre,KasiyerTelefon,KasiyerAdres,KasiyerMemleket,KasiyerOgrenim) values('" + txtKasaNo.Text.ToString() + "','" + txtKasiyerAdi.Text.ToString() + "','" + txtKasiyerSoyad.Text.ToString() + "','" + txtKasiyerSifre.Text.ToString() + "','" + txtMaskedTel.Text.ToString() + "','" + richTextBox1.Text.ToString() + "','" + comboMemleket.Text.ToString() + "','" + ComboOgrenim.Text.ToString() + "')", baglan);
                MessageBox.Show("Kayit Basarili bir şekilde eklendi.");
                komut.ExecuteNonQuery();

                baglan.Close();

                temizle();


            }
            catch (Exception)
            {

                MessageBox.Show("Kayit Eklenemedi..");
            }
            goruntule();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            goruntule();
        }
        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtKasaNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtKasiyerAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtKasiyerSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            //txtKasiyerSifre.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMaskedTel.Text = listView1.SelectedItems[0].SubItems[3].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            ComboOgrenim.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboMemleket.Text = listView1.SelectedItems[0].SubItems[6].Text;
           

        
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                komut.Connection = baglan;                                                                                                                                     //KasaNo,KasiyerAdi,KasiyerSoyadi,KasiyerSifre,KasiyerTelefon,                                                                             KasiyerAdres,KasiyerMemleket,KasiyerOgrenim
                komut.CommandText = "update KasiyerBilgileri set KasiyerAdi='" + txtKasiyerAdi.Text + "',KasiyerSoyadi='" + txtKasiyerSoyad.Text + "',KasiyerSifre='" + txtKasiyerSifre.Text + "',KasiyerTelefon='" + txtMaskedTel.Text + "',KasiyerAdres='" + richTextBox1.Text + "',KasiyerMemleket='" + comboMemleket.Text + "',KasiyerOgrenim='" + ComboOgrenim.Text + "'where KasaNo='" + txtKasaNo.Text + "'";
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt BaşarıLı Bir Şekilde Güncellendi");

                baglan.Close();
                goruntule();
                temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt Güncellenemedi");
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }

            else
            {
                MessageBox.Show("Sadece rakam Giriniz");
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma

            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sadece Sayı Giriniz.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Delete from KasiyerBilgileri where KasaNo='" + Convert.ToInt16(txtKasaNo.Text.ToString()) + "'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            goruntule();

            temizle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
