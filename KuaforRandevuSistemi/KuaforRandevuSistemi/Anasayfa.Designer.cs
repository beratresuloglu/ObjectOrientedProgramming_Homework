namespace KuaforRandevuSistemi
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.lbl_hizmetlerimiz = new System.Windows.Forms.Label();
            this.btn_randevuSistemi = new System.Windows.Forms.Button();
            this.btn_musteriKayit = new System.Windows.Forms.Button();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.listView_hizmetler = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hizmetlerimiz
            // 
            this.lbl_hizmetlerimiz.AutoSize = true;
            this.lbl_hizmetlerimiz.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_hizmetlerimiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.03478F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hizmetlerimiz.ForeColor = System.Drawing.Color.White;
            this.lbl_hizmetlerimiz.Location = new System.Drawing.Point(75, 130);
            this.lbl_hizmetlerimiz.Name = "lbl_hizmetlerimiz";
            this.lbl_hizmetlerimiz.Size = new System.Drawing.Size(231, 37);
            this.lbl_hizmetlerimiz.TabIndex = 31;
            this.lbl_hizmetlerimiz.Text = "Hizmetlerimiz:";
            // 
            // btn_randevuSistemi
            // 
            this.btn_randevuSistemi.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_randevuSistemi.ForeColor = System.Drawing.Color.White;
            this.btn_randevuSistemi.Location = new System.Drawing.Point(478, 170);
            this.btn_randevuSistemi.Name = "btn_randevuSistemi";
            this.btn_randevuSistemi.Size = new System.Drawing.Size(360, 118);
            this.btn_randevuSistemi.TabIndex = 32;
            this.btn_randevuSistemi.Text = "Randevu Sistemi";
            this.btn_randevuSistemi.UseVisualStyleBackColor = false;
            this.btn_randevuSistemi.Click += new System.EventHandler(this.btn_randevuSistemi_Click);
            // 
            // btn_musteriKayit
            // 
            this.btn_musteriKayit.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_musteriKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_musteriKayit.Location = new System.Drawing.Point(478, 294);
            this.btn_musteriKayit.Name = "btn_musteriKayit";
            this.btn_musteriKayit.Size = new System.Drawing.Size(360, 118);
            this.btn_musteriKayit.TabIndex = 33;
            this.btn_musteriKayit.Text = "Müşteri Kayıt";
            this.btn_musteriKayit.UseVisualStyleBackColor = false;
            this.btn_musteriKayit.Click += new System.EventHandler(this.btn_musteriKayit_Click);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_baslik.Font = new System.Drawing.Font("Modern No. 20", 26.29565F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_baslik.Location = new System.Drawing.Point(213, 64);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(452, 44);
            this.lbl_baslik.TabIndex = 36;
            this.lbl_baslik.Text = "Çotanak Erkek Kuaförü";
            // 
            // listView_hizmetler
            // 
            this.listView_hizmetler.BackColor = System.Drawing.Color.SeaGreen;
            this.listView_hizmetler.ForeColor = System.Drawing.Color.White;
            this.listView_hizmetler.GridLines = true;
            this.listView_hizmetler.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_hizmetler.HideSelection = false;
            this.listView_hizmetler.Location = new System.Drawing.Point(82, 170);
            this.listView_hizmetler.Name = "listView_hizmetler";
            this.listView_hizmetler.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView_hizmetler.Scrollable = false;
            this.listView_hizmetler.Size = new System.Drawing.Size(360, 365);
            this.listView_hizmetler.TabIndex = 37;
            this.listView_hizmetler.UseCompatibleStateImageBehavior = false;
            this.listView_hizmetler.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(478, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 118);
            this.button1.TabIndex = 38;
            this.button1.Text = "Elemanlar Sayfası";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(660, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.765218F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(97, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(921, 605);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_hizmetler);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.btn_musteriKayit);
            this.Controls.Add(this.btn_randevuSistemi);
            this.Controls.Add(this.lbl_hizmetlerimiz);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_hizmetlerimiz;
        private System.Windows.Forms.Button btn_randevuSistemi;
        private System.Windows.Forms.Button btn_musteriKayit;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.ListView listView_hizmetler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

