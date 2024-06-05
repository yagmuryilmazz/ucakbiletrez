using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletRezerUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHava.Text)
            {
                case "Yağmur Hava Yolları": KoltukDoldur(8, false);
                    break;
                case "RainExpress Hava Yolları": KoltukDoldur(12, true);
                    break;
                case "Norveç Hava Yolları": KoltukDoldur(10, false);
                    break;

            }
            void KoltukDoldur(int sira, bool arkaBesliMİ)
            {
            yavaslat:
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }
                    }
                }
                int koltukNo = 1;
                for (int i = 0; i < sira; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 2)
                            continue;
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        koltuk.Click += Koltuk_Click;
                        this.Controls.Add(koltuk);


                    }
                }
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show(clickedButton.Text + " numaralı koltuk seçildi.");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbHava.SelectedIndex==-1 || cmbNereden.SelectedIndex==-1 || cmbNereye.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz");
                return;
            }
            KayıtFormu kf = new KayıtFormu();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = string.Format("{0} {1}", kf.txtİsim.Text, kf.txtSoyisim.Text);
                lvi.SubItems.Add(kf.mskdTelefon.Text);
                if(kf.rdbErkek.Checked)
                {
                    lvi.SubItems.Add("ERKEK");
                    tiklanan.BackColor = Color.Red;
                }
                if (kf.rdbKadın.Checked)
                {
                    lvi.SubItems.Add("KADIN");
                    tiklanan.BackColor = Color.Green;
                }
                lvi.SubItems.Add(cmbNereden.Text);
                lvi.SubItems.Add(cmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(dtpTarih.Text);
                lvi.SubItems.Add(nudFiyat.Value.ToString());
                listView1.Items.Add(lvi);


            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
