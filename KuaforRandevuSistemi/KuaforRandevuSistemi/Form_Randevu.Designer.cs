namespace KuaforRandevuSistemi
{
    partial class Form_Randevu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Randevu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_randevuOlustur = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_hizmetler = new System.Windows.Forms.ComboBox();
            this.button_tamam = new System.Windows.Forms.Button();
            this.label_eleman = new System.Windows.Forms.Label();
            this.label_musteri = new System.Windows.Forms.Label();
            this.label_saat = new System.Windows.Forms.Label();
            this.label_tarih = new System.Windows.Forms.Label();
            this.comboBox_eleman = new System.Windows.Forms.ComboBox();
            this.comboBox_musteri = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_saat = new System.Windows.Forms.MaskedTextBox();
            this.checkedListBox_bekleyenRandevular = new System.Windows.Forms.CheckedListBox();
            this.listBox_gecmisRandevular = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox_randevuOlustur.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // groupBox_randevuOlustur
            // 
            this.groupBox_randevuOlustur.Controls.Add(this.dateTimePicker1);
            this.groupBox_randevuOlustur.Controls.Add(this.label3);
            this.groupBox_randevuOlustur.Controls.Add(this.comboBox_hizmetler);
            this.groupBox_randevuOlustur.Controls.Add(this.button_tamam);
            this.groupBox_randevuOlustur.Controls.Add(this.label_eleman);
            this.groupBox_randevuOlustur.Controls.Add(this.label_musteri);
            this.groupBox_randevuOlustur.Controls.Add(this.label_saat);
            this.groupBox_randevuOlustur.Controls.Add(this.label_tarih);
            this.groupBox_randevuOlustur.Controls.Add(this.comboBox_eleman);
            this.groupBox_randevuOlustur.Controls.Add(this.comboBox_musteri);
            this.groupBox_randevuOlustur.Controls.Add(this.maskedTextBox_saat);
            this.groupBox_randevuOlustur.ForeColor = System.Drawing.Color.White;
            this.groupBox_randevuOlustur.Location = new System.Drawing.Point(278, 394);
            this.groupBox_randevuOlustur.Name = "groupBox_randevuOlustur";
            this.groupBox_randevuOlustur.Size = new System.Drawing.Size(395, 289);
            this.groupBox_randevuOlustur.TabIndex = 2;
            this.groupBox_randevuOlustur.TabStop = false;
            this.groupBox_randevuOlustur.Text = "Randevu Oluştur";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hizmet.:";
            // 
            // comboBox_hizmetler
            // 
            this.comboBox_hizmetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_hizmetler.ForeColor = System.Drawing.Color.Black;
            this.comboBox_hizmetler.FormattingEnabled = true;
            this.comboBox_hizmetler.Location = new System.Drawing.Point(134, 197);
            this.comboBox_hizmetler.Name = "comboBox_hizmetler";
            this.comboBox_hizmetler.Size = new System.Drawing.Size(211, 28);
            this.comboBox_hizmetler.TabIndex = 11;
            // 
            // button_tamam
            // 
            this.button_tamam.ForeColor = System.Drawing.Color.Black;
            this.button_tamam.Location = new System.Drawing.Point(134, 234);
            this.button_tamam.Name = "button_tamam";
            this.button_tamam.Size = new System.Drawing.Size(121, 32);
            this.button_tamam.TabIndex = 8;
            this.button_tamam.Text = "Tamam";
            this.button_tamam.UseVisualStyleBackColor = true;
            this.button_tamam.Click += new System.EventHandler(this.button_tamam_Click_1);
            // 
            // label_eleman
            // 
            this.label_eleman.AutoSize = true;
            this.label_eleman.Location = new System.Drawing.Point(41, 161);
            this.label_eleman.Name = "label_eleman";
            this.label_eleman.Size = new System.Drawing.Size(87, 24);
            this.label_eleman.TabIndex = 7;
            this.label_eleman.Text = "Eleman:";
            // 
            // label_musteri
            // 
            this.label_musteri.AutoSize = true;
            this.label_musteri.Location = new System.Drawing.Point(41, 123);
            this.label_musteri.Name = "label_musteri";
            this.label_musteri.Size = new System.Drawing.Size(84, 24);
            this.label_musteri.TabIndex = 6;
            this.label_musteri.Text = "Müşteri:";
            // 
            // label_saat
            // 
            this.label_saat.AutoSize = true;
            this.label_saat.Location = new System.Drawing.Point(41, 85);
            this.label_saat.Name = "label_saat";
            this.label_saat.Size = new System.Drawing.Size(80, 24);
            this.label_saat.TabIndex = 5;
            this.label_saat.Text = "Saat....:";
            // 
            // label_tarih
            // 
            this.label_tarih.AutoSize = true;
            this.label_tarih.Location = new System.Drawing.Point(41, 50);
            this.label_tarih.Name = "label_tarih";
            this.label_tarih.Size = new System.Drawing.Size(82, 24);
            this.label_tarih.TabIndex = 4;
            this.label_tarih.Text = "Tarih...:";
            // 
            // comboBox_eleman
            // 
            this.comboBox_eleman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_eleman.ForeColor = System.Drawing.Color.Black;
            this.comboBox_eleman.FormattingEnabled = true;
            this.comboBox_eleman.Location = new System.Drawing.Point(134, 159);
            this.comboBox_eleman.Name = "comboBox_eleman";
            this.comboBox_eleman.Size = new System.Drawing.Size(211, 28);
            this.comboBox_eleman.TabIndex = 3;
            // 
            // comboBox_musteri
            // 
            this.comboBox_musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_musteri.ForeColor = System.Drawing.Color.Black;
            this.comboBox_musteri.FormattingEnabled = true;
            this.comboBox_musteri.Location = new System.Drawing.Point(134, 121);
            this.comboBox_musteri.Name = "comboBox_musteri";
            this.comboBox_musteri.Size = new System.Drawing.Size(211, 28);
            this.comboBox_musteri.TabIndex = 2;
            // 
            // maskedTextBox_saat
            // 
            this.maskedTextBox_saat.ForeColor = System.Drawing.Color.Black;
            this.maskedTextBox_saat.Location = new System.Drawing.Point(134, 80);
            this.maskedTextBox_saat.Mask = "00:00";
            this.maskedTextBox_saat.Name = "maskedTextBox_saat";
            this.maskedTextBox_saat.Size = new System.Drawing.Size(59, 29);
            this.maskedTextBox_saat.TabIndex = 1;
            // 
            // checkedListBox_bekleyenRandevular
            // 
            this.checkedListBox_bekleyenRandevular.BackColor = System.Drawing.Color.SeaGreen;
            this.checkedListBox_bekleyenRandevular.CheckOnClick = true;
            this.checkedListBox_bekleyenRandevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox_bekleyenRandevular.ForeColor = System.Drawing.SystemColors.Window;
            this.checkedListBox_bekleyenRandevular.FormattingEnabled = true;
            this.checkedListBox_bekleyenRandevular.Location = new System.Drawing.Point(76, 236);
            this.checkedListBox_bekleyenRandevular.Name = "checkedListBox_bekleyenRandevular";
            this.checkedListBox_bekleyenRandevular.Size = new System.Drawing.Size(825, 140);
            this.checkedListBox_bekleyenRandevular.TabIndex = 10;
            this.checkedListBox_bekleyenRandevular.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_bekleyenRandevular_SelectedIndexChanged);
            // 
            // listBox_gecmisRandevular
            // 
            this.listBox_gecmisRandevular.BackColor = System.Drawing.Color.SeaGreen;
            this.listBox_gecmisRandevular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_gecmisRandevular.ForeColor = System.Drawing.Color.White;
            this.listBox_gecmisRandevular.FormattingEnabled = true;
            this.listBox_gecmisRandevular.ItemHeight = 16;
            this.listBox_gecmisRandevular.Location = new System.Drawing.Point(76, 63);
            this.listBox_gecmisRandevular.Name = "listBox_gecmisRandevular";
            this.listBox_gecmisRandevular.Size = new System.Drawing.Size(824, 148);
            this.listBox_gecmisRandevular.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Geçmiş Randevular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(73, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bekleyen Randevular:";
            // 
            // Form_Randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(985, 695);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_gecmisRandevular);
            this.Controls.Add(this.checkedListBox_bekleyenRandevular);
            this.Controls.Add(this.groupBox_randevuOlustur);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Sistemi";
            this.Load += new System.EventHandler(this.Form_Randevu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_randevuOlustur.ResumeLayout(false);
            this.groupBox_randevuOlustur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox_randevuOlustur;
        private System.Windows.Forms.ComboBox comboBox_eleman;
        private System.Windows.Forms.ComboBox comboBox_musteri;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_saat;
        private System.Windows.Forms.Label label_eleman;
        private System.Windows.Forms.Label label_musteri;
        private System.Windows.Forms.Label label_saat;
        private System.Windows.Forms.Label label_tarih;
        private System.Windows.Forms.Button button_tamam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_hizmetler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBox_gecmisRandevular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckedListBox checkedListBox_bekleyenRandevular;
    }
}