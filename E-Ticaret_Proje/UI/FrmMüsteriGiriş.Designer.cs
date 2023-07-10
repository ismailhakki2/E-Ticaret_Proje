namespace E_Ticaret_Proje
{
    partial class FrmMüsteriGiriş
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMüsteriGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "ISO ÜYE GİRİŞ EKRANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(469, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 12;
            // 
            // btnMüsteriGirisYap
            // 
            this.btnMüsteriGirisYap.Location = new System.Drawing.Point(475, 228);
            this.btnMüsteriGirisYap.Name = "btnMüsteriGirisYap";
            this.btnMüsteriGirisYap.Size = new System.Drawing.Size(112, 41);
            this.btnMüsteriGirisYap.TabIndex = 11;
            this.btnMüsteriGirisYap.Text = "Giriş Yap";
            this.btnMüsteriGirisYap.UseVisualStyleBackColor = true;
            this.btnMüsteriGirisYap.Click += new System.EventHandler(this.btnMüsteriGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(362, 190);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(225, 32);
            this.txtSifre.TabIndex = 10;
            this.txtSifre.Text = "gkdsoğ342";
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullanıcıAdi
            // 
            this.txtKullanıcıAdi.Location = new System.Drawing.Point(362, 141);
            this.txtKullanıcıAdi.Name = "txtKullanıcıAdi";
            this.txtKullanıcıAdi.Size = new System.Drawing.Size(225, 32);
            this.txtKullanıcıAdi.TabIndex = 9;
            this.txtKullanıcıAdi.Text = "Tekin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // FrmMüsteriGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(772, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMüsteriGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanıcıAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMüsteriGiriş";
            this.Text = "ISO MÜŞTERİ GİRİŞ PANELi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMüsteriGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanıcıAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}