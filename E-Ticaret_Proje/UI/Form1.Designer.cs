namespace E_Ticaret_Proje
{
    partial class Form1
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
            this.btnTemsilci = new System.Windows.Forms.Button();
            this.btnMüsteri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTemsilci
            // 
            this.btnTemsilci.Location = new System.Drawing.Point(183, 164);
            this.btnTemsilci.Name = "btnTemsilci";
            this.btnTemsilci.Size = new System.Drawing.Size(211, 64);
            this.btnTemsilci.TabIndex = 0;
            this.btnTemsilci.Text = "TEMSİLCİ GİRİŞİ";
            this.btnTemsilci.UseVisualStyleBackColor = true;
            this.btnTemsilci.Click += new System.EventHandler(this.btnTemsilci_Click);
            // 
            // btnMüsteri
            // 
            this.btnMüsteri.Location = new System.Drawing.Point(439, 164);
            this.btnMüsteri.Name = "btnMüsteri";
            this.btnMüsteri.Size = new System.Drawing.Size(211, 64);
            this.btnMüsteri.TabIndex = 1;
            this.btnMüsteri.Text = "MÜŞTERİ GİRİŞİ";
            this.btnMüsteri.UseVisualStyleBackColor = true;
            this.btnMüsteri.Click += new System.EventHandler(this.btnMüsteri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISO UYGULAMAMIZA HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Girişler için butonları kullanınız!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(850, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMüsteri);
            this.Controls.Add(this.btnTemsilci);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "ISO GİRİŞ PANELİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemsilci;
        private System.Windows.Forms.Button btnMüsteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

