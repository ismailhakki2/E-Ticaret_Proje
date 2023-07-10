namespace E_Ticaret_Proje
{
    partial class FrmMüsteriPaneli
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
            this.txtUrünFiyat = new System.Windows.Forms.TextBox();
            this.mskUrünTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtUrünIsim = new System.Windows.Forms.TextBox();
            this.txtUrünKodu = new System.Windows.Forms.TextBox();
            this.txtUrünID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatınAl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSatilanUrünler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürünlerimiz ";
            // 
            // txtUrünFiyat
            // 
            this.txtUrünFiyat.Location = new System.Drawing.Point(150, 200);
            this.txtUrünFiyat.Name = "txtUrünFiyat";
            this.txtUrünFiyat.Size = new System.Drawing.Size(193, 32);
            this.txtUrünFiyat.TabIndex = 46;
            // 
            // mskUrünTarih
            // 
            this.mskUrünTarih.Location = new System.Drawing.Point(150, 151);
            this.mskUrünTarih.Mask = "0000/00/00";
            this.mskUrünTarih.Name = "mskUrünTarih";
            this.mskUrünTarih.Size = new System.Drawing.Size(193, 32);
            this.mskUrünTarih.TabIndex = 45;
            this.mskUrünTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtUrünIsim
            // 
            this.txtUrünIsim.Location = new System.Drawing.Point(150, 106);
            this.txtUrünIsim.Name = "txtUrünIsim";
            this.txtUrünIsim.Size = new System.Drawing.Size(193, 32);
            this.txtUrünIsim.TabIndex = 44;
            // 
            // txtUrünKodu
            // 
            this.txtUrünKodu.Location = new System.Drawing.Point(150, 63);
            this.txtUrünKodu.Name = "txtUrünKodu";
            this.txtUrünKodu.Size = new System.Drawing.Size(193, 32);
            this.txtUrünKodu.TabIndex = 43;
            // 
            // txtUrünID
            // 
            this.txtUrünID.Location = new System.Drawing.Point(150, 20);
            this.txtUrünID.Name = "txtUrünID";
            this.txtUrünID.Size = new System.Drawing.Size(193, 32);
            this.txtUrünID.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 26);
            this.label5.TabIndex = 41;
            this.label5.Text = "Ürün Fiyat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ürün Tarih : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ürün İsim : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ürün Kodu : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ürün ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(653, 228);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.Location = new System.Drawing.Point(12, 238);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(331, 49);
            this.btnSatınAl.TabIndex = 48;
            this.btnSatınAl.Text = "Satın Al";
            this.btnSatınAl.UseVisualStyleBackColor = true;
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(513, 26);
            this.label7.TabIndex = 49;
            this.label7.Text = "Satın Alınmış Ürünlerimize Buradan Ulaşabilirsin ";
            // 
            // btnSatilanUrünler
            // 
            this.btnSatilanUrünler.Location = new System.Drawing.Point(628, 293);
            this.btnSatilanUrünler.Name = "btnSatilanUrünler";
            this.btnSatilanUrünler.Size = new System.Drawing.Size(331, 49);
            this.btnSatilanUrünler.TabIndex = 50;
            this.btnSatilanUrünler.Text = "Satılan Ürünler";
            this.btnSatilanUrünler.UseVisualStyleBackColor = true;
            this.btnSatilanUrünler.Click += new System.EventHandler(this.btnSatilanUrünler_Click);
            // 
            // FrmMüsteriPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1015, 357);
            this.Controls.Add(this.btnSatilanUrünler);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSatınAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtUrünFiyat);
            this.Controls.Add(this.mskUrünTarih);
            this.Controls.Add(this.txtUrünIsim);
            this.Controls.Add(this.txtUrünKodu);
            this.Controls.Add(this.txtUrünID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMüsteriPaneli";
            this.Text = "ISO MÜŞTERİ PANELİ";
            this.Load += new System.EventHandler(this.FrmMüsteriPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrünFiyat;
        private System.Windows.Forms.MaskedTextBox mskUrünTarih;
        private System.Windows.Forms.TextBox txtUrünIsim;
        private System.Windows.Forms.TextBox txtUrünKodu;
        private System.Windows.Forms.TextBox txtUrünID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatınAl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSatilanUrünler;
    }
}