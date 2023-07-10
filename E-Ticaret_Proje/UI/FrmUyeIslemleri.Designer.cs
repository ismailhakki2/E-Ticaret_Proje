namespace E_Ticaret_Proje
{
    partial class FrmUyeIslemleri
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
            this.btnUyeSıl = new System.Windows.Forms.Button();
            this.btnUyeGuncelle = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mskUyeTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtUyeSoyisim = new System.Windows.Forms.TextBox();
            this.txtUyeIsim = new System.Windows.Forms.TextBox();
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUyeAdres = new System.Windows.Forms.TextBox();
            this.txtUyeSıfre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUyeSıl
            // 
            this.btnUyeSıl.Location = new System.Drawing.Point(158, 338);
            this.btnUyeSıl.Name = "btnUyeSıl";
            this.btnUyeSıl.Size = new System.Drawing.Size(118, 38);
            this.btnUyeSıl.TabIndex = 35;
            this.btnUyeSıl.Text = "Sil";
            this.btnUyeSıl.UseVisualStyleBackColor = true;
            this.btnUyeSıl.Click += new System.EventHandler(this.btnUyeSıl_Click);
            // 
            // btnUyeGuncelle
            // 
            this.btnUyeGuncelle.Location = new System.Drawing.Point(221, 294);
            this.btnUyeGuncelle.Name = "btnUyeGuncelle";
            this.btnUyeGuncelle.Size = new System.Drawing.Size(118, 38);
            this.btnUyeGuncelle.TabIndex = 34;
            this.btnUyeGuncelle.Text = "Güncelle";
            this.btnUyeGuncelle.UseVisualStyleBackColor = true;
            this.btnUyeGuncelle.Click += new System.EventHandler(this.btnUyeGuncelle_Click);
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(97, 294);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(118, 38);
            this.btnUyeEkle.TabIndex = 33;
            this.btnUyeEkle.Text = "Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(426, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 393);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mskUyeTelNo
            // 
            this.mskUyeTelNo.Location = new System.Drawing.Point(156, 144);
            this.mskUyeTelNo.Mask = "(999) 000-0000";
            this.mskUyeTelNo.Name = "mskUyeTelNo";
            this.mskUyeTelNo.Size = new System.Drawing.Size(264, 32);
            this.mskUyeTelNo.TabIndex = 29;
            // 
            // txtUyeSoyisim
            // 
            this.txtUyeSoyisim.Location = new System.Drawing.Point(156, 99);
            this.txtUyeSoyisim.Name = "txtUyeSoyisim";
            this.txtUyeSoyisim.Size = new System.Drawing.Size(264, 32);
            this.txtUyeSoyisim.TabIndex = 27;
            // 
            // txtUyeIsim
            // 
            this.txtUyeIsim.Location = new System.Drawing.Point(156, 56);
            this.txtUyeIsim.Name = "txtUyeIsim";
            this.txtUyeIsim.Size = new System.Drawing.Size(264, 32);
            this.txtUyeIsim.TabIndex = 26;
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(156, 13);
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(264, 32);
            this.txtUyeID.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 24;
            this.label7.Text = "Şifre : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adres : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tel No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Soyisim : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "İsim : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Uye ID : ";
            // 
            // txtUyeAdres
            // 
            this.txtUyeAdres.Location = new System.Drawing.Point(156, 190);
            this.txtUyeAdres.Name = "txtUyeAdres";
            this.txtUyeAdres.Size = new System.Drawing.Size(264, 32);
            this.txtUyeAdres.TabIndex = 36;
            // 
            // txtUyeSıfre
            // 
            this.txtUyeSıfre.Location = new System.Drawing.Point(156, 230);
            this.txtUyeSıfre.Name = "txtUyeSıfre";
            this.txtUyeSıfre.Size = new System.Drawing.Size(264, 32);
            this.txtUyeSıfre.TabIndex = 37;
            // 
            // FrmUyeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1136, 418);
            this.Controls.Add(this.txtUyeSıfre);
            this.Controls.Add(this.txtUyeAdres);
            this.Controls.Add(this.btnUyeSıl);
            this.Controls.Add(this.btnUyeGuncelle);
            this.Controls.Add(this.btnUyeEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskUyeTelNo);
            this.Controls.Add(this.txtUyeSoyisim);
            this.Controls.Add(this.txtUyeIsim);
            this.Controls.Add(this.txtUyeID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmUyeIslemleri";
            this.Text = "ISO ÜYE İŞLEMLER PANELİ";
            this.Load += new System.EventHandler(this.FrmUyeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyeSıl;
        private System.Windows.Forms.Button btnUyeGuncelle;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskUyeTelNo;
        private System.Windows.Forms.TextBox txtUyeSoyisim;
        private System.Windows.Forms.TextBox txtUyeIsim;
        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUyeAdres;
        private System.Windows.Forms.TextBox txtUyeSıfre;
    }
}