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
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KuaforRandevuSistemi
{
    public partial class Form_Elemanlar : Form
    {

        public Form_Elemanlar()
        {
            InitializeComponent();
        }

        private void Form_Elemanlar_Load(object sender, EventArgs e)
        {

            string path = "D:\\Elemanlar.txt";
            try
            {
                // Dosyayı aç
                using (StreamReader sr = new StreamReader(path))
                {
                    string satir;
                    // Dosyanın sonuna kadar satır satır oku
                    while ((satir = sr.ReadLine()) != null)
                    {
                        // Okunan satırı işle (örneğin, ekrana yazdır)
                        checkedListBox1.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }




        }

        private void button_tamam_Click(object sender, EventArgs e)
        {
            Eleman eleman = new Eleman();
            eleman.ElemanNo = checkedListBox1.Items.Count + 1;
            eleman.Ad = textBox_adi.Text.ToUpper();
            eleman.Soyad = textBox_soyadi.Text.ToUpper();
            eleman.Tel = maskedTextBox_telNo.Text;


            checkedListBox1.Items.Add(eleman.ElemanNo + ") " + eleman.Ad + " " + eleman.Soyad + " --- " + eleman.Tel);
            try
            {
                string path = "D:\\Elemanlar.txt";
                // Dosyayı 'Append' modunda aç
                StreamWriter dosya = new StreamWriter(path, true);
                dosya.WriteLine(eleman.ElemanNo.ToString() + ") " + eleman.Ad + " " + eleman.Soyad + " --- " + eleman.Tel);
                dosya.Close();
                MessageBox.Show("Yeni eleman kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Yeni eleman kaydedilemedi" + hata, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }


        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            button_sil.Visible = true;
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            label1.Visible = false;
            button_sil.Visible = false;
        }
    }
}
