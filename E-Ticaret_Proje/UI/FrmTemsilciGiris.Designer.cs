namespace E_Ticaret_Proje
{
    partial class FrmTemsilciGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemsilciKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtTemsilciSifre = new System.Windows.Forms.TextBox();
            this.btnTemsilciGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre : ";
            // 
            // txtTemsilciKullaniciAdi
            // 
            this.txtTemsilciKullaniciAdi.Location = new System.Drawing.Point(352, 154);
            this.txtTemsilciKullaniciAdi.Name = "txtTemsilciKullaniciAdi";
            this.txtTemsilciKullaniciAdi.Size = new System.Drawing.Size(225, 32);
            this.txtTemsilciKullaniciAdi.TabIndex = 2;
            this.txtTemsilciKullaniciAdi.Text = "Ahmet";
            // 
            // txtTemsilciSifre
            // 
            this.txtTemsilciSifre.Location = new System.Drawing.Point(352, 203);
            this.txtTemsilciSifre.Name = "txtTemsilciSifre";
            this.txtTemsilciSifre.Size = new System.Drawing.Size(225, 32);
            this.txtTemsilciSifre.TabIndex = 3;
            this.txtTemsilciSifre.Text = "11";
            this.txtTemsilciSifre.UseSystemPasswordChar = true;
            // 
            // btnTemsilciGirisYap
            // 
            this.btnTemsilciGirisYap.Location = new System.Drawing.Point(465, 241);
            this.btnTemsilciGirisYap.Name = "btnTemsilciGirisYap";
            this.btnTemsilciGirisYap.Size = new System.Drawing.Size(112, 41);
            this.btnTemsilciGirisYap.TabIndex = 4;
            this.btnTemsilciGirisYap.Text = "Giriş Yap";
            this.btnTemsilciGirisYap.UseVisualStyleBackColor = true;
            this.btnTemsilciGirisYap.Click += new System.EventHandler(this.btnTemsilciGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(519, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesai başlıyor İYİ ÇALIŞMALAR :)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "ISO TEMSİLCİ GİRİŞ EKRANI";
            // 
            // FrmTemsilciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(774, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTemsilciGirisYap);
            this.Controls.Add(this.txtTemsilciSifre);
            this.Controls.Add(this.txtTemsilciKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTemsilciGiris";
            this.Text = "ISO TEMSİLCİ GİRİŞ PANELİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemsilciKullaniciAdi;
        private System.Windows.Forms.TextBox txtTemsilciSifre;
        private System.Windows.Forms.Button btnTemsilciGirisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}