namespace KuaforRandevuSistemi
{
    partial class Form_Elemanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Elemanlar));
            this.button_tamam = new System.Windows.Forms.Button();
            this.label_telNo = new System.Windows.Forms.Label();
            this.label_soyadi = new System.Windows.Forms.Label();
            this.label_adi = new System.Windows.Forms.Label();
            this.textBox_soyadi = new System.Windows.Forms.TextBox();
            this.textBox_adi = new System.Windows.Forms.TextBox();
            this.maskedTextBox_telNo = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_elemanKayıt = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox_elemanKayıt.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_tamam
            // 
            this.button_tamam.BackColor = System.Drawing.Color.White;
            this.button_tamam.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_tamam.Location = new System.Drawing.Point(41, 192);
            this.button_tamam.Name = "button_tamam";
            this.button_tamam.Size = new System.Drawing.Size(259, 32);
            this.button_tamam.TabIndex = 10;
            this.button_tamam.Text = "Tamam";
            this.button_tamam.UseVisualStyleBackColor = false;
            this.button_tamam.Click += new System.EventHandler(this.button_tamam_Click);
            // 
            // label_telNo
            // 
            this.label_telNo.AutoSize = true;
            this.label_telNo.Location = new System.Drawing.Point(37, 143);
            this.label_telNo.Name = "label_telNo";
            this.label_telNo.Size = new System.Drawing.Size(112, 24);
            this.label_telNo.TabIndex = 13;
            this.label_telNo.Text = "TELEFON:";
            // 
            // label_soyadi
            // 
            this.label_soyadi.AutoSize = true;
            this.label_soyadi.Location = new System.Drawing.Point(37, 86);
            this.label_soyadi.Name = "label_soyadi";
            this.label_soyadi.Size = new System.Drawing.Size(110, 24);
            this.label_soyadi.TabIndex = 12;
            this.label_soyadi.Text = "SOYAD....:";
            // 
            // label_adi
            // 
            this.label_adi.AutoSize = true;
            this.label_adi.Location = new System.Drawing.Point(37, 35);
            this.label_adi.Name = "label_adi";
            this.label_adi.Size = new System.Drawing.Size(116, 24);
            this.label_adi.TabIndex = 11;
            this.label_adi.Text = "AD............:";
            // 
            // textBox_soyadi
            // 
            this.textBox_soyadi.BackColor = System.Drawing.Color.White;
            this.textBox_soyadi.Location = new System.Drawing.Point(157, 83);
            this.textBox_soyadi.Name = "textBox_soyadi";
            this.textBox_soyadi.Size = new System.Drawing.Size(143, 29);
            this.textBox_soyadi.TabIndex = 8;
            // 
            // textBox_adi
            // 
            this.textBox_adi.BackColor = System.Drawing.Color.White;
            this.textBox_adi.Location = new System.Drawing.Point(157, 32);
            this.textBox_adi.Name = "textBox_adi";
            this.textBox_adi.Size = new System.Drawing.Size(143, 29);
            this.textBox_adi.TabIndex = 7;
            // 
            // maskedTextBox_telNo
            // 
            this.maskedTextBox_telNo.BackColor = System.Drawing.Color.White;
            this.maskedTextBox_telNo.Location = new System.Drawing.Point(157, 140);
            this.maskedTextBox_telNo.Mask = "(999) 000-0000";
            this.maskedTextBox_telNo.Name = "maskedTextBox_telNo";
            this.maskedTextBox_telNo.Size = new System.Drawing.Size(143, 29);
            this.maskedTextBox_telNo.TabIndex = 9;
            // 
            // groupBox_elemanKayıt
            // 
            this.groupBox_elemanKayıt.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox_elemanKayıt.Controls.Add(this.textBox_soyadi);
            this.groupBox_elemanKayıt.Controls.Add(this.button_tamam);
            this.groupBox_elemanKayıt.Controls.Add(this.maskedTextBox_telNo);
            this.groupBox_elemanKayıt.Controls.Add(this.label_telNo);
            this.groupBox_elemanKayıt.Controls.Add(this.textBox_adi);
            this.groupBox_elemanKayıt.Controls.Add(this.label_soyadi);
            this.groupBox_elemanKayıt.Controls.Add(this.label_adi);
            this.groupBox_elemanKayıt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_elemanKayıt.Location = new System.Drawing.Point(39, 311);
            this.groupBox_elemanKayıt.Name = "groupBox_elemanKayıt";
            this.groupBox_elemanKayıt.Size = new System.Drawing.Size(334, 247);
            this.groupBox_elemanKayıt.TabIndex = 14;
            this.groupBox_elemanKayıt.TabStop = false;
            this.groupBox_elemanKayıt.Text = "Yeni Eleman Kayıt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 16;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Elemanlarımız:";
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.White;
            this.button_sil.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_sil.Location = new System.Drawing.Point(500, 391);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(144, 32);
            this.button_sil.TabIndex = 14;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Visible = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(548, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sil ?";
            this.label1.Visible = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(39, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(724, 196);
            this.checkedListBox1.TabIndex = 22;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form_Elemanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(798, 583);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_elemanKayıt);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Elemanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Sistemi";
            this.Load += new System.EventHandler(this.Form_Elemanlar_Load);
            this.groupBox_elemanKayıt.ResumeLayout(false);
            this.groupBox_elemanKayıt.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_tamam;
        private System.Windows.Forms.Label label_telNo;
        private System.Windows.Forms.Label label_soyadi;
        private System.Windows.Forms.Label label_adi;
        private System.Windows.Forms.TextBox textBox_soyadi;
        private System.Windows.Forms.TextBox textBox_adi;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telNo;
        private System.Windows.Forms.GroupBox groupBox_elemanKayıt;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}