namespace E_Ticaret_Proje
{
    partial class FrmTemsilciPaneli
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
            this.btnUrünIslemleri = new System.Windows.Forms.Button();
            this.btnTemsilciIslemleri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUyeIslemleri = new System.Windows.Forms.Button();
            this.btnUrunYorumları = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrünIslemleri
            // 
            this.btnUrünIslemleri.Location = new System.Drawing.Point(12, 166);
            this.btnUrünIslemleri.Name = "btnUrünIslemleri";
            this.btnUrünIslemleri.Size = new System.Drawing.Size(152, 61);
            this.btnUrünIslemleri.TabIndex = 1;
            this.btnUrünIslemleri.Text = "Ürün İşlemleri";
            this.btnUrünIslemleri.UseVisualStyleBackColor = true;
            this.btnUrünIslemleri.Click += new System.EventHandler(this.btnUrünIslemleri_Click);
            // 
            // btnTemsilciIslemleri
            // 
            this.btnTemsilciIslemleri.Location = new System.Drawing.Point(12, 99);
            this.btnTemsilciIslemleri.Name = "btnTemsilciIslemleri";
            this.btnTemsilciIslemleri.Size = new System.Drawing.Size(152, 61);
            this.btnTemsilciIslemleri.TabIndex = 1;
            this.btnTemsilciIslemleri.Text = "Temsilci İşlemleri";
            this.btnTemsilciIslemleri.UseVisualStyleBackColor = true;
            this.btnTemsilciIslemleri.Click += new System.EventHandler(this.btnTemsilciIslemleri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 220);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(170, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(790, 220);
            this.dataGridView2.TabIndex = 7;
            // 
            // btnUyeIslemleri
            // 
            this.btnUyeIslemleri.Location = new System.Drawing.Point(12, 233);
            this.btnUyeIslemleri.Name = "btnUyeIslemleri";
            this.btnUyeIslemleri.Size = new System.Drawing.Size(152, 61);
            this.btnUyeIslemleri.TabIndex = 8;
            this.btnUyeIslemleri.Text = "Üye İşlemleri";
            this.btnUyeIslemleri.UseVisualStyleBackColor = true;
            this.btnUyeIslemleri.Click += new System.EventHandler(this.btnUyeIslemleri_Click);
            // 
            // btnUrunYorumları
            // 
            this.btnUrunYorumları.Location = new System.Drawing.Point(12, 300);
            this.btnUrunYorumları.Name = "btnUrunYorumları";
            this.btnUrunYorumları.Size = new System.Drawing.Size(152, 61);
            this.btnUrunYorumları.TabIndex = 9;
            this.btnUrunYorumları.Text = "Ürün Yorumları";
            this.btnUrunYorumları.UseVisualStyleBackColor = true;
            this.btnUrunYorumları.Click += new System.EventHandler(this.btnUrunYorumları_Click);
            // 
            // FrmTemsilciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(972, 470);
            this.Controls.Add(this.btnUrunYorumları);
            this.Controls.Add(this.btnUyeIslemleri);
            this.Controls.Add(this.btnUrünIslemleri);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnTemsilciIslemleri);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTemsilciPaneli";
            this.Text = "ISO TEMSİLCİ PANELİ";
            this.Load += new System.EventHandler(this.FrmTemsilciPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUrünIslemleri;
        private System.Windows.Forms.Button btnTemsilciIslemleri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUyeIslemleri;
        private System.Windows.Forms.Button btnUrunYorumları;
    }
}