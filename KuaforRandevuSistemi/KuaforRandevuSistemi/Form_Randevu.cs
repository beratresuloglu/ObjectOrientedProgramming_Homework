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
    public partial class Form_Randevu : Form
    {

        public Form_Randevu()
        {
            InitializeComponent();
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
                // Dosyayı aç
                using (StreamReader sr = new StreamReader(path1))
                {
                    string satir;
                    // Dosyanın sonuna kadar satır satır oku
                    while ((satir = sr.ReadLine()) != null)
                    {
                        // Okunan satırı işle (örneğin, ekrana yazdır)
                        comboBox_musteri.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }


            string path2 = "D:\\Randevular.txt";
            try
            {
                // Dosyayı aç
                using (StreamReader sr = new StreamReader(path2))
                {
                    string satir;
                    // Dosyanın sonuna kadar satır satır oku
                    while ((satir = sr.ReadLine()) != null)
                    {
                        // Okunan satırı işle (örneğin, ekrana yazdır)
                        checkedListBox_bekleyenRandevular.Items.Add(satir);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message);
            }

            string path3 = "D:\\Geçmiş randevular.txt";
            try
            {
                // Dosyayı aç
                using (StreamReader sr = new StreamReader(path3))
                {
                    string satir;
                    // Dosyanın sonuna kadar satır satır oku
                    while ((satir = sr.ReadLine()) != null)
                    {
                        // Okunan satırı işle (örneğin, ekrana yazdır)
                        listBox_gecmisRandevular.Items.Add(satir);
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
                string[] row = islemler[i]; // Diziyi al
                string item = row[0] + " - " + row[1]; // Dizi içindeki değerleri birleştir
                comboBox_hizmetler.Items.Add(item); // ComboBox'a ekleyin
            }


        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }


        public DateTime DateTimePickerValue { get; set; }
        public string MaskedTextBoxValue { get; set; }
        public string ComboBoxValue1 { get; set; }
        public string ComboBoxValue2 { get; set; }
        public string ComboBoxValue3 { get; set; }



        public void checkedListBox_bekleyenRandevular_SelectedIndexChanged(object sender, EventArgs e)
        {


            // Sadece bir öğe seçildiğinde devam et
            if (checkedListBox_bekleyenRandevular.SelectedItems.Count == 1)
            {
                ozelMessageBox messageBox = new ozelMessageBox("Randevuya ne yapmak istiyorsunuz ?");
                DialogResult result = messageBox.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    EditFormu editFormu = new EditFormu();
                    editFormu.Show();
                }

                if (result == DialogResult.No)
                {
                    if (checkedListBox_bekleyenRandevular.CheckedItems.Count > 0)
                    {
                        checkedListBox_bekleyenRandevular.Items.Remove(checkedListBox_bekleyenRandevular.SelectedItem);
                    }
                }

                if (result == DialogResult.OK)
                {
                    string selectedValue = checkedListBox_bekleyenRandevular.SelectedItem.ToString();

                    // checkedListBox_gecmisRandevular'a ekle
                    listBox_gecmisRandevular.Items.Add(selectedValue);

                    try
                    {
                        string path3 = "D:\\Geçmiş Randevular.txt";
                        // Dosyayı 'Append' modunda aç
                        StreamWriter dosya = new StreamWriter(path3, true);
                        dosya.WriteLine(selectedValue);
                        dosya.Close();
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Randevu Taşınamadı" + hata, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }

                    // checkedListBox_bekleyenRandevular'dan kaldır
                    checkedListBox_bekleyenRandevular.Items.Remove(selectedValue);

                    string dosyaYolu = "D:\\Randevular.txt";
                    string satirSilinecek = selectedValue;

                    // Dosyadan satırları oku ve silinecek satırı hariç tut
                    List<string> satirlar = File.ReadAllLines(dosyaYolu).Where(line => line != satirSilinecek).ToList();

                    // Dosyayı temizle
                    File.WriteAllText(dosyaYolu, string.Empty);

                    // Bellekteki satırları dosyaya yaz
                    foreach (string satir in satirlar)
                    {
                        File.AppendAllText(dosyaYolu, satir + Environment.NewLine);
                    }

                }



                if (result == DialogResult.Cancel)
                {
                    // Kullanıcı "İptal" düğmesine bastıysa seçimi temizle
                    checkedListBox_bekleyenRandevular.ClearSelected();

                }

            }
        }

        private bool IsValidTime(string value)
        {
            try
            {
                // Saat formatı doğru olup olmadığını kontrol etmek için bir zaman nesnesi oluştur
                DateTime.ParseExact(value, "HH:mm", null);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void button_tamam_Click_1(object sender, EventArgs e)
        {
            string saat = maskedTextBox_saat.Text;

            // Eğer değer boşsa veya uygun saat formatında değilse hata mesajı göster
            if (string.IsNullOrWhiteSpace(saat) || !IsValidTime(saat))
            {
                MessageBox.Show("Geçersiz saat formatı! Lütfen saat dilimine uygun bir saat giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Media.SystemSounds.Beep.Play();
            }
            else
            {
                if (string.IsNullOrEmpty(comboBox_eleman.Text))
                {
                    MessageBox.Show("Lütfen eleman girişi yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Media.SystemSounds.Beep.Play();
                }
                else
                {
                    if (string.IsNullOrEmpty(comboBox_musteri.Text))
                    {
                        MessageBox.Show("Lütfen müşteri girişi yapın.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        System.Media.SystemSounds.Beep.Play();
                    }

                    else
                    {
                        if (string.IsNullOrEmpty(comboBox_hizmetler.Text))
                        {
                            MessageBox.Show("Lütfen hizmet seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            System.Media.SystemSounds.Beep.Play();
                        }
                        else
                        {
                            string randevu = dateTimePicker1.Text + " | " + maskedTextBox_saat.Text + " | " + comboBox_hizmetler.SelectedItem.ToString() + " | " + comboBox_musteri.SelectedItem.ToString() + " | " + comboBox_eleman.SelectedItem.ToString();
                            checkedListBox_bekleyenRandevular.Items.Add(randevu);
                            try
                            {
                                string path2 = "D:\\Randevular.txt";
                                // Dosyayı 'Append' modunda aç
                                StreamWriter dosya = new StreamWriter(path2, true);
                                dosya.WriteLine(randevu);
                                dosya.Close();
                                MessageBox.Show("Yeni randevu kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception hata)
                            {
                                MessageBox.Show("Yeni randevu kaydedilemedi" + hata, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                throw;
                            }

                        }
                    }
                }

            }
        }

        private void Form_Randevu_Load(object sender, EventArgs e)
        {

        }
    }
}
