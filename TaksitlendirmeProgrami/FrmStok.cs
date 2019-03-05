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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\Database\Taksitlendirme.mdb");
        OleDbCommand komut = new OleDbCommand();
       public void temizle()
        {
            txtStokNo.Clear();
            comboBox1.Text = "";
            txtUrunAdedi.Clear();
            txtUrunFiyati.Clear();
            richOzellik.Clear();
            idgetir();
        }
        
public void idgetir()
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            var lastId = new OleDbCommand("SELECT LAST(StokNo) FROM Stok", baglan).ExecuteScalar().ToString();
            int lastid = Convert.ToInt16(lastId.ToString()) + 1;
            txtStokNo.Text = lastid.ToString();
            baglan.Close();

        }
        private void goruntule()

        {
            int sayac = 0;
            listView1.Items.Clear();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select *from Stok", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["StokNo"].ToString();
                ekle.SubItems.Add(oku["UrunAdi"].ToString());
                ekle.SubItems.Add(oku["UrunAdedi"].ToString());
                ekle.SubItems.Add(oku["UrunFiyati"].ToString());
                ekle.SubItems.Add(oku["UrunOzellikleri"].ToString());
                ekle.SubItems.Add(oku["SonGuncellenmeTarihi"].ToString());

               
                listView1.Items.Add(ekle);
            }
           baglan.Close();
            
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timerdate.Text = DateTime.Now.ToLongDateString();
            TimerSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtStokNo_KeyPress(object sender, KeyPressEventArgs e)
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
        
        private void FrmStok_Load(object sender, EventArgs e)
        {
            idgetir();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "SELECT * FROM Stok";
            OleDbDataReader oku;
            oku = komut.ExecuteReader();

            while (oku.Read())
            {
                comboBox1.Items.Add(oku["UrunAdi"]);

            }
            baglan.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtStokNo.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            comboBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUrunAdedi.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUrunFiyati.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            richOzellik.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            goruntule();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtStokNo.Text != "" && comboBox1.Text != "" && txtUrunAdedi.Text != "" && txtUrunFiyati.Text != "" && richOzellik.Text != "")
                {
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into Stok(StokNo,UrunAdi,UrunAdedi,UrunFiyati,UrunOzellikleri,SonGuncellenmeTarihi) values('" + txtStokNo.Text.ToString() + "','" + comboBox1.Text.ToString() + "','" + txtUrunAdedi.Text.ToString() + "','" + txtUrunFiyati.Text.ToString() + "','" + richOzellik.Text.ToString() + "','" + DateTime.Now.ToShortDateString() + "')", baglan);
                    MessageBox.Show("Kayit Basarili bir şekilde eklendi.");
                    komut.ExecuteNonQuery();

                    baglan.Close();

                    temizle();

                }
                else
                {
                    MessageBox.Show("Girdilerde Boş Alan bırakılmamalı","Bildirim Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                baglan.Close();

                MessageBox.Show("Kayit Eklenemedi..");
            }
            goruntule();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            
            try
            {
                baglan.Open();
                komut.Connection = baglan;                                                                                                                                   
                komut.CommandText = "update Stok set UrunAdi='" + comboBox1.Text + "',UrunAdedi='" + txtUrunAdedi.Text + "',UrunFiyati='" + txtUrunFiyati.Text + "',UrunOzellikleri='" + richOzellik.Text + "',SonGuncellenmeTarihi='" + DateTime.Now.ToShortDateString() +  "'where StokNo='" + txtStokNo.Text + "'";
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt BaşarıLı Bir Şekilde Güncellendi");

                baglan.Close();
                goruntule();
                temizle();
            }
            catch (Exception)
            {
                baglan.Close();
                MessageBox.Show("Kayıt Güncellenemedi");
            }
        }
        int id = 0;

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtStokNo.Text = listView1.SelectedItems[0].SubItems[0].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtUrunAdedi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            
            txtUrunFiyati.Text = listView1.SelectedItems[0].SubItems[3].Text;
            richOzellik.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Delete from Stok where StokNo='" + Convert.ToInt16(txtStokNo.Text.ToString()) + "'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            temizle();
            goruntule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           FrmAnasayfa admin = new FrmAnasayfa();
            admin.Show();
            this.Hide();

        }

        private void txtUrunAdedi_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sadece Sayı Giriniz");
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma

            }
        }

        private void txtUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sadece Sayı Giriniz");
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma

            }
        }

        private void txtStokNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

