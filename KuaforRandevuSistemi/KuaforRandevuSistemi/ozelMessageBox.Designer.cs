namespace KuaforRandevuSistemi
{
    partial class ozelMessageBox
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
            this.button_duzenle = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.button_tasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_duzenle
            // 
            this.button_duzenle.Location = new System.Drawing.Point(60, 152);
            this.button_duzenle.Name = "button_duzenle";
            this.button_duzenle.Size = new System.Drawing.Size(82, 40);
            this.button_duzenle.TabIndex = 0;
            this.button_duzenle.Text = "Düzenle";
            this.button_duzenle.UseVisualStyleBackColor = true;
            this.button_duzenle.Click += new System.EventHandler(this.button_duzenle_Click);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_message.ForeColor = System.Drawing.Color.White;
            this.label_message.Location = new System.Drawing.Point(75, 78);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 24);
            this.label_message.TabIndex = 1;
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(148, 152);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(82, 40);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.Location = new System.Drawing.Point(324, 152);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(82, 40);
            this.button_iptal.TabIndex = 3;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = true;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // button_tasi
            // 
            this.button_tasi.Location = new System.Drawing.Point(236, 152);
            this.button_tasi.Name = "button_tasi";
            this.button_tasi.Size = new System.Drawing.Size(82, 40);
            this.button_tasi.TabIndex = 4;
            this.button_tasi.Text = "Taşı";
            this.button_tasi.UseVisualStyleBackColor = true;
            this.button_tasi.Click += new System.EventHandler(this.button_tasi_Click);
            // 
            // ozelMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(480, 246);
            this.Controls.Add(this.button_tasi);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_duzenle);
            this.Name = "ozelMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bildirim";
            this.Load += new System.EventHandler(this.ozelMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_duzenle;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Button button_tasi;
    }
}