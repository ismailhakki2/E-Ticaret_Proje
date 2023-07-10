namespace E_Ticaret_Proje
{
    partial class FrmTemsilciIslemleri
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTemsilciID = new System.Windows.Forms.TextBox();
            this.txtTemsilciIsim = new System.Windows.Forms.TextBox();
            this.txtTemsilciSoyisim = new System.Windows.Forms.TextBox();
            this.mskTemsilciTCNO = new System.Windows.Forms.MaskedTextBox();
            this.mskTemsilciTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTemsilciAdres = new System.Windows.Forms.TextBox();
            this.txtTemsilciSifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTemsilciEkle = new System.Windows.Forms.Button();
            this.btnTemsilciGüncelle = new System.Windows.Forms.Button();
            this.btnTemsilciSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temsilci ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyisim : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tc Kimlik No : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şifre : ";
            // 
            // txtTemsilciID
            // 
            this.txtTemsilciID.Location = new System.Drawing.Point(147, 35);
            this.txtTemsilciID.Name = "txtTemsilciID";
            this.txtTemsilciID.Size = new System.Drawing.Size(256, 32);
            this.txtTemsilciID.TabIndex = 7;
            // 
            // txtTemsilciIsim
            // 
            this.txtTemsilciIsim.Location = new System.Drawing.Point(147, 78);
            this.txtTemsilciIsim.Name = "txtTemsilciIsim";
            this.txtTemsilciIsim.Size = new System.Drawing.Size(256, 32);
            this.txtTemsilciIsim.TabIndex = 8;
            // 
            // txtTemsilciSoyisim
            // 
            this.txtTemsilciSoyisim.Location = new System.Drawing.Point(147, 121);
            this.txtTemsilciSoyisim.Name = "txtTemsilciSoyisim";
            this.txtTemsilciSoyisim.Size = new System.Drawing.Size(256, 32);
            this.txtTemsilciSoyisim.TabIndex = 9;
            // 
            // mskTemsilciTCNO
            // 
            this.mskTemsilciTCNO.Location = new System.Drawing.Point(147, 166);
            this.mskTemsilciTCNO.Mask = "00000000000";
            this.mskTemsilciTCNO.Name = "mskTemsilciTCNO";
            this.mskTemsilciTCNO.Size = new System.Drawing.Size(256, 32);
            this.mskTemsilciTCNO.TabIndex = 10;
            // 
            // mskTemsilciTelNo
            // 
            this.mskTemsilciTelNo.Location = new System.Drawing.Point(147, 212);
            this.mskTemsilciTelNo.Mask = "(999) 000-0000";
            this.mskTemsilciTelNo.Name = "mskTemsilciTelNo";
            this.mskTemsilciTelNo.Size = new System.Drawing.Size(256, 32);
            this.mskTemsilciTelNo.TabIndex = 11;
            // 
            // txtTemsilciAdres
            // 
            this.txtTemsilciAdres.Location = new System.Drawing.Point(147, 252);
            this.txtTemsilciAdres.Name = "txtTemsilciAdres";
            this.txtTemsilciAdres.Size = new System.Drawing.Size(256, 32);
            this.txtTemsilciAdres.TabIndex = 12;
            // 
            // txtTemsilciSifre
            // 
            this.txtTemsilciSifre.Location = new System.Drawing.Point(147, 291);
            this.txtTemsilciSifre.Name = "txtTemsilciSifre";
            this.txtTemsilciSifre.Size = new System.Drawing.Size(256, 32);
            this.txtTemsilciSifre.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(409, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(723, 393);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnTemsilciEkle
            // 
            this.btnTemsilciEkle.Location = new System.Drawing.Point(80, 341);
            this.btnTemsilciEkle.Name = "btnTemsilciEkle";
            this.btnTemsilciEkle.Size = new System.Drawing.Size(118, 38);
            this.btnTemsilciEkle.TabIndex = 15;
            this.btnTemsilciEkle.Text = "Ekle";
            this.btnTemsilciEkle.UseVisualStyleBackColor = true;
            this.btnTemsilciEkle.Click += new System.EventHandler(this.btnTemsilciEkle_Click);
            // 
            // btnTemsilciGüncelle
            // 
            this.btnTemsilciGüncelle.Location = new System.Drawing.Point(204, 341);
            this.btnTemsilciGüncelle.Name = "btnTemsilciGüncelle";
            this.btnTemsilciGüncelle.Size = new System.Drawing.Size(118, 38);
            this.btnTemsilciGüncelle.TabIndex = 16;
            this.btnTemsilciGüncelle.Text = "Güncelle";
            this.btnTemsilciGüncelle.UseVisualStyleBackColor = true;
            this.btnTemsilciGüncelle.Click += new System.EventHandler(this.btnTemsilciGüncelle_Click);
            // 
            // btnTemsilciSil
            // 
            this.btnTemsilciSil.Location = new System.Drawing.Point(141, 385);
            this.btnTemsilciSil.Name = "btnTemsilciSil";
            this.btnTemsilciSil.Size = new System.Drawing.Size(118, 38);
            this.btnTemsilciSil.TabIndex = 17;
            this.btnTemsilciSil.Text = "Sil";
            this.btnTemsilciSil.UseVisualStyleBackColor = true;
            this.btnTemsilciSil.Click += new System.EventHandler(this.btnTemsilciSil_Click);
            // 
            // FrmTemsilciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1144, 440);
            this.Controls.Add(this.btnTemsilciSil);
            this.Controls.Add(this.btnTemsilciGüncelle);
            this.Controls.Add(this.btnTemsilciEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTemsilciSifre);
            this.Controls.Add(this.txtTemsilciAdres);
            this.Controls.Add(this.mskTemsilciTelNo);
            this.Controls.Add(this.mskTemsilciTCNO);
            this.Controls.Add(this.txtTemsilciSoyisim);
            this.Controls.Add(this.txtTemsilciIsim);
            this.Controls.Add(this.txtTemsilciID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTemsilciIslemleri";
            this.Text = "ISO TEMSİLCİ İŞLEM PANELİ";
            this.Load += new System.EventHandler(this.FrmTemsilciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTemsilciID;
        private System.Windows.Forms.TextBox txtTemsilciIsim;
        private System.Windows.Forms.TextBox txtTemsilciSoyisim;
        private System.Windows.Forms.MaskedTextBox mskTemsilciTCNO;
        private System.Windows.Forms.MaskedTextBox mskTemsilciTelNo;
        private System.Windows.Forms.TextBox txtTemsilciAdres;
        private System.Windows.Forms.TextBox txtTemsilciSifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTemsilciEkle;
        private System.Windows.Forms.Button btnTemsilciGüncelle;
        private System.Windows.Forms.Button btnTemsilciSil;
    }
}