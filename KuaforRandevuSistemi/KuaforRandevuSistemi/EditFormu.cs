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
    public partial class EditFormu : Form
    {
        Form_Randevu randevuSayfasi = new Form_Randevu();

        public EditFormu()
        {
            InitializeComponent();
            string path = "D:\\Elemanlar.txt";
            try
            {
                
                using (StreamReader sr = new StreamReader(path))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        comboBox_eleman.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }

            string path1 = "D:\\Musteriler.txt";
            try
            {
                using (StreamReader sr = new StreamReader(path1))
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        comboBox_musteri.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }

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


            for (int i = 0; i < islemler.Length; i++)
            {
                string[] row = islemler[i]; 
                string item = row[0] + " - " + row[1]; 
                comboBox_hizmetler.Items.Add(item); 
            }

            button_tamam.DialogResult = DialogResult.OK;
            button_iptal.DialogResult = DialogResult.Cancel;
        }


        public void button_tamam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox_saat.Text))
            {
                MessageBox.Show("Lütfen saat seçin");
            }
            else if (string.IsNullOrEmpty(comboBox_hizmetler.Text))
            {
                MessageBox.Show("Lütfen hizmet seç");
            }
            else if (string.IsNullOrEmpty(comboBox_musteri.Text))
            {
                MessageBox.Show("Lütfen müşteri seç");
            }

            else if (string.IsNullOrEmpty(comboBox_eleman.Text))
            {
                MessageBox.Show("Lütfen eleman seç");
            }
            else
            {
                if (randevuSayfasi.checkedListBox_bekleyenRandevular.SelectedIndex != -1)
                {
                    DateTime DateTimePickerValue = dateTimePicker1.Value;
                    string MaskedTextBoxValue = maskedTextBox_saat.Text;
                    string ComboBoxValue1 = comboBox_hizmetler.Text;
                    string ComboBoxValue2 = comboBox_musteri.Text;
                    string ComboBoxValue3 = comboBox_eleman.Text;
                    string yeniRandevu = DateTimePickerValue.ToString() + " | " + MaskedTextBoxValue + " | " + ComboBoxValue1 + " | " + ComboBoxValue2 + " | " + ComboBoxValue3;

                    randevuSayfasi.checkedListBox_bekleyenRandevular.Items.RemoveAt(randevuSayfasi.checkedListBox_bekleyenRandevular.SelectedIndex);

                    randevuSayfasi.checkedListBox_bekleyenRandevular.Items.Add(yeniRandevu);

                    randevuSayfasi.checkedListBox_bekleyenRandevular.Refresh();

                    this.Close();
                }

            }
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFormu_Load(object sender, EventArgs e)
        {

        }
    }
}

