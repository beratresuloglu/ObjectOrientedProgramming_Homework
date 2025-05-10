/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: Berat Resuloğlu    
**				ÖĞRENCİ NUMARASI.......: b231210050
**              DERSİN ALINDIĞI GRUP...: A Grubu (Cemil Öz)
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KuaforRandevuSistemi
{
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView_hizmetler.Columns.Add("İŞLEM", 200);
            listView_hizmetler.Columns.Add("ÜCRET", 160);
            string[] row1 = { "Saç", "120" };
            string[] row2 = { "Sakal", "90" };
            string[] row13 = { "Saç-Sakal", "200" };
            string[] row3 = { "Saç-Yıkama", "150" };
            string[] row4 = { "Çocuk", "60" };
            string[] row5 = { "Damat", "500" };
            string[] row6 = { "Asker", "100" };
            string[] row7 = { "Sakal-Bıyık Boyama", "100" };
            string[] row8 = { "Saç Boyama", "300" };
            string[] row9 = { "Ağda", "50" };
            string[] row10 = { "Maske", "50" };
            string[] row11 = { "Perma", "600" };
            string[] row12 = { "Cilt Bakım ", "400" };

            string[][] islemler = { row1, row2, row13, row3, row4, row5, row6, row7, row8, row9, row10, row11, row12 };

            for (int i = 0; i < 12; i++)
            {
                ListViewItem kayit = new ListViewItem(islemler[i]);
                listView_hizmetler.Items.Add(kayit);
            }



        }

        private void btn_musteriKayit_Click(object sender, EventArgs e)
        {
            Form_musteri musteriKayitSayfasi = new Form_musteri();
            musteriKayitSayfasi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Elemanlar elemanSayfasi = new Form_Elemanlar();
            elemanSayfasi.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama 2024 yılında, Berat Resuloğlu tarafından geliştirilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_randevuSistemi_Click(object sender, EventArgs e)
        {
            Form_Randevu randevuSayfasi = new Form_Randevu();
            randevuSayfasi.Show();
            this.Hide();
        }


    }
}
