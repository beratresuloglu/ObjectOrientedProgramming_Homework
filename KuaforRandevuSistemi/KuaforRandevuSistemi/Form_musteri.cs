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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaforRandevuSistemi
{
    public partial class Form_musteri : Form
    {

        public Form_musteri()
        {
            InitializeComponent();
        }

        private void Form_musteri_Load(object sender, EventArgs e)
        {
            string path = "D:\\Musteriler.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
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
            Insan musteri = new Insan();

            musteri.Ad = textBox_adi.Text.ToUpper();
            musteri.Soyad = textBox_soyadi.Text.ToUpper();
            musteri.Tel = maskedTextBox_telNo.Text;

            checkedListBox1.Items.Add(musteri.Ad + " " + musteri.Soyad + " --- " + musteri.Tel);


            try
            {
                string path = "D:\\Musteriler.txt";
                StreamWriter dosya = new StreamWriter(path, true);
                dosya.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Tel);
                dosya.Close();
                MessageBox.Show("Müşteri kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Müşteri kaydedilemedi" + hata, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            textBox_adi.Clear();
            textBox_soyadi.Clear();
            maskedTextBox_telNo.Clear();
            textBox_adi.Focus();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anaSayfa = new Anasayfa();
            anaSayfa.Show();
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
            label2.Visible = false;
            button_sil.Visible = false;
        }
    }
}
