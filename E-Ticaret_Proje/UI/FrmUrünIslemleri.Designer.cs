namespace E_Ticaret_Proje
{
    partial class FrmUrünIslemleri
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
            this.btnUrünSil = new System.Windows.Forms.Button();
            this.btnUrünGüncelle = new System.Windows.Forms.Button();
            this.btnUrünEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskUrünTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtUrünIsim = new System.Windows.Forms.TextBox();
            this.txtUrünKodu = new System.Windows.Forms.TextBox();
            this.txtUrünID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrünFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrünSil
            // 
            this.btnUrünSil.Location = new System.Drawing.Point(147, 328);
            this.btnUrünSil.Name = "btnUrünSil";
            this.btnUrünSil.Size = new System.Drawing.Size(118, 38);
            this.btnUrünSil.TabIndex = 35;
            this.btnUrünSil.Text = "Sil";
            this.btnUrünSil.UseVisualStyleBackColor = true;
            this.btnUrünSil.Click += new System.EventHandler(this.btnUrünSil_Click);
            // 
            // btnUrünGüncelle
            // 
            this.btnUrünGüncelle.Location = new System.Drawing.Point(210, 284);
            this.btnUrünGüncelle.Name = "btnUrünGüncelle";
            this.btnUrünGüncelle.Size = new System.Drawing.Size(118, 38);
            this.btnUrünGüncelle.TabIndex = 34;
            this.btnUrünGüncelle.Text = "Güncelle";
            this.btnUrünGüncelle.UseVisualStyleBackColor = true;
            this.btnUrünGüncelle.Click += new System.EventHandler(this.btnUrünGüncelle_Click);
            // 
            // btnUrünEkle
            // 
            this.btnUrünEkle.Location = new System.Drawing.Point(86, 284);
            this.btnUrünEkle.Name = "btnUrünEkle";
            this.btnUrünEkle.Size = new System.Drawing.Size(118, 38);
            this.btnUrünEkle.TabIndex = 33;
            this.btnUrünEkle.Text = "Ekle";
            this.btnUrünEkle.UseVisualStyleBackColor = true;
            this.btnUrünEkle.Click += new System.EventHandler(this.btnUrünEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 393);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mskUrünTarih
            // 
            this.mskUrünTarih.Location = new System.Drawing.Point(155, 180);
            this.mskUrünTarih.Mask = "0000/00/00";
            this.mskUrünTarih.Name = "mskUrünTarih";
            this.mskUrünTarih.Size = new System.Drawing.Size(268, 32);
            this.mskUrünTarih.TabIndex = 28;
            this.mskUrünTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtUrünIsim
            // 
            this.txtUrünIsim.Location = new System.Drawing.Point(155, 135);
            this.txtUrünIsim.Name = "txtUrünIsim";
            this.txtUrünIsim.Size = new System.Drawing.Size(268, 32);
            this.txtUrünIsim.TabIndex = 27;
            // 
            // txtUrünKodu
            // 
            this.txtUrünKodu.Location = new System.Drawing.Point(155, 92);
            this.txtUrünKodu.Name = "txtUrünKodu";
            this.txtUrünKodu.Size = new System.Drawing.Size(268, 32);
            this.txtUrünKodu.TabIndex = 26;
            // 
            // txtUrünID
            // 
            this.txtUrünID.Location = new System.Drawing.Point(155, 49);
            this.txtUrünID.Name = "txtUrünID";
            this.txtUrünID.Size = new System.Drawing.Size(268, 32);
            this.txtUrünID.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ürün Fiyat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ürün Tarih : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ürün İsim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ürün Kodu : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün ID :";
            // 
            // txtUrünFiyat
            // 
            this.txtUrünFiyat.Location = new System.Drawing.Point(155, 229);
            this.txtUrünFiyat.Name = "txtUrünFiyat";
            this.txtUrünFiyat.Size = new System.Drawing.Size(268, 32);
            this.txtUrünFiyat.TabIndex = 36;
            // 
            // FrmUrünIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1085, 411);
            this.Controls.Add(this.txtUrünFiyat);
            this.Controls.Add(this.btnUrünSil);
            this.Controls.Add(this.btnUrünGüncelle);
            this.Controls.Add(this.btnUrünEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskUrünTarih);
            this.Controls.Add(this.txtUrünIsim);
            this.Controls.Add(this.txtUrünKodu);
            this.Controls.Add(this.txtUrünID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmUrünIslemleri";
            this.Text = "ISO ÜRÜN İŞLEM PANELİ";
            this.Load += new System.EventHandler(this.FrmUrünIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUrünSil;
        private System.Windows.Forms.Button btnUrünGüncelle;
        private System.Windows.Forms.Button btnUrünEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskUrünTarih;
        private System.Windows.Forms.TextBox txtUrünIsim;
        private System.Windows.Forms.TextBox txtUrünKodu;
        private System.Windows.Forms.TextBox txtUrünID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrünFiyat;
    }
}