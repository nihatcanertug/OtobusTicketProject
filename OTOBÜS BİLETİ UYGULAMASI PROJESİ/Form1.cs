using OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOBÜS_BİLETİ_UYGULAMASI_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        AppMember appMember = new AppMember();

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobus.Text)
            {
                case "Metro":
                    KoltukDoldur(6);
                    break;
                case "Nilüfer":
                    KoltukDoldur(7);
                    break;
                case "Pamukkale":
                    KoltukDoldur(8);
                    break;
                
                default:
                    break;
            }
        }
        void KoltukDoldur(int sira)
        {
            yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;
                    if (btn.Text == "Add")
                    {
                        continue;
                    }else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }

            }



            int koltukNo = 1;
            for (int satir = 0; satir < sira; satir++)
            {
                for (int sütun = 0; sütun < 4; sütun++)
                {
                    if (satir==3&&sütun>1)
                    {
                        continue;
                    }
                    if (sütun == 1) continue;
                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width=40;
                    koltuk.Top = 30 + (satir * 45);
                    koltuk.Left = 100 + (sütun * 45);
                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += koltuk_mouseDown;
                    this.Controls.Add(koltuk);

                }

            }
        }
        Button tiklanan;

        private void koltuk_mouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
         
        }

        /*  private void koltuk_Click(object sender, EventArgs e)  
         *  button eventi olusturduk tıkladıgında hangi button a tıkladıgını anlamasını sagladık.
          {
              Button btn = sender as Button;
              MessageBox.Show(btn.Text);
          }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rezervasyonYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.SelectedIndex==-1||cmbNerden.SelectedIndex==-1||cmbNereye.SelectedIndex==-1)
            {
                MessageBox.Show("Lüften Gerekli alanları doldurun");
                return;

            }
            KayitFormu kf = new KayitFormu();
            DialogResult sonuc=kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}", kf.txtFirstname.Text, kf.txtLastname.Text);
                lvi.SubItems.Add(kf.mskPhoneNumber.Text);
                if (kf.rdeMan.Checked)
                {
                    tiklanan.BackColor = Color.Blue;
                    lvi.SubItems.Add("MAN");
                }
                if (kf.rdWomen.Checked)
                {
                    lvi.SubItems.Add("WOMEN");
                    tiklanan.BackColor = Color.Pink; 
                }
                lvi.SubItems.Add(cmbNerden.Text);
                lvi.SubItems.Add(cmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                lvi.SubItems.Add(comboBox3.Text);
                lvi.SubItems.Add(numUpFiyat.Value.ToString());
                listView1.Items.Add(lvi);
                        

            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
