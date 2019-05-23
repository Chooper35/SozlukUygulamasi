namespace SözlükUygulaması
{
    partial class KelimeEkranı
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
            this.components = new System.ComponentModel.Container();
            this.mlblİngilizceKelime = new MetroFramework.Controls.MetroLabel();
            this.mlblTürkceKelime = new MetroFramework.Controls.MetroLabel();
            this.mlblTür = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mBtnEkle = new MetroFramework.Controls.MetroButton();
            this.mtbxTür = new MetroFramework.Controls.MetroTextBox();
            this.mtbxTürkce = new MetroFramework.Controls.MetroTextBox();
            this.mtbxİngilizce = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mBtnGüncelle = new MetroFramework.Controls.MetroButton();
            this.mtbxTürGünc = new MetroFramework.Controls.MetroTextBox();
            this.mtbxTürkceGünc = new MetroFramework.Controls.MetroTextBox();
            this.mtbxİngilizceGünc = new MetroFramework.Controls.MetroTextBox();
            this.mlblİngilizceGünc = new MetroFramework.Controls.MetroLabel();
            this.mlblTürkceGünc = new MetroFramework.Controls.MetroLabel();
            this.mlblTürGünc = new MetroFramework.Controls.MetroLabel();
            this.dgWKelimeler = new System.Windows.Forms.DataGridView();
            this.mBtnSil = new MetroFramework.Controls.MetroButton();
            this.mBtnAnaEkran = new MetroFramework.Controls.MetroButton();
            this.mBtnTestEkranıK = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mlblGüncelTarih = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWKelimeler)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblİngilizceKelime
            // 
            this.mlblİngilizceKelime.AutoSize = true;
            this.mlblİngilizceKelime.Location = new System.Drawing.Point(12, 27);
            this.mlblİngilizceKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblİngilizceKelime.Name = "mlblİngilizceKelime";
            this.mlblİngilizceKelime.Size = new System.Drawing.Size(101, 19);
            this.mlblİngilizceKelime.TabIndex = 4;
            this.mlblİngilizceKelime.Text = "İngilizce Kelime:";
            // 
            // mlblTürkceKelime
            // 
            this.mlblTürkceKelime.AutoSize = true;
            this.mlblTürkceKelime.Location = new System.Drawing.Point(12, 58);
            this.mlblTürkceKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblTürkceKelime.Name = "mlblTürkceKelime";
            this.mlblTürkceKelime.Size = new System.Drawing.Size(91, 19);
            this.mlblTürkceKelime.TabIndex = 5;
            this.mlblTürkceKelime.Text = "Türkçe Kelime:";
            // 
            // mlblTür
            // 
            this.mlblTür.AutoSize = true;
            this.mlblTür.Location = new System.Drawing.Point(12, 92);
            this.mlblTür.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblTür.Name = "mlblTür";
            this.mlblTür.Size = new System.Drawing.Size(96, 19);
            this.mlblTür.TabIndex = 6;
            this.mlblTür.Text = "Kelimenin Türü:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mBtnEkle);
            this.groupBox1.Controls.Add(this.mtbxTür);
            this.groupBox1.Controls.Add(this.mtbxTürkce);
            this.groupBox1.Controls.Add(this.mtbxİngilizce);
            this.groupBox1.Controls.Add(this.mlblİngilizceKelime);
            this.groupBox1.Controls.Add(this.mlblTürkceKelime);
            this.groupBox1.Controls.Add(this.mlblTür);
            this.groupBox1.Location = new System.Drawing.Point(32, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(209, 149);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // mBtnEkle
            // 
            this.mBtnEkle.Location = new System.Drawing.Point(51, 124);
            this.mBtnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnEkle.Name = "mBtnEkle";
            this.mBtnEkle.Size = new System.Drawing.Size(91, 19);
            this.mBtnEkle.TabIndex = 12;
            this.mBtnEkle.Text = "Ekle";
            this.mBtnEkle.Click += new System.EventHandler(this.mBtnEkle_Click);
            // 
            // mtbxTür
            // 
            this.mtbxTür.Location = new System.Drawing.Point(114, 89);
            this.mtbxTür.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxTür.Name = "mtbxTür";
            this.mtbxTür.Size = new System.Drawing.Size(86, 19);
            this.mtbxTür.TabIndex = 9;
            // 
            // mtbxTürkce
            // 
            this.mtbxTürkce.Location = new System.Drawing.Point(114, 56);
            this.mtbxTürkce.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxTürkce.Name = "mtbxTürkce";
            this.mtbxTürkce.Size = new System.Drawing.Size(86, 19);
            this.mtbxTürkce.TabIndex = 8;
            // 
            // mtbxİngilizce
            // 
            this.mtbxİngilizce.Location = new System.Drawing.Point(114, 24);
            this.mtbxİngilizce.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxİngilizce.Name = "mtbxİngilizce";
            this.mtbxİngilizce.Size = new System.Drawing.Size(86, 19);
            this.mtbxİngilizce.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.mBtnGüncelle);
            this.groupBox2.Controls.Add(this.mtbxTürGünc);
            this.groupBox2.Controls.Add(this.mtbxTürkceGünc);
            this.groupBox2.Controls.Add(this.mtbxİngilizceGünc);
            this.groupBox2.Controls.Add(this.mlblİngilizceGünc);
            this.groupBox2.Controls.Add(this.mlblTürkceGünc);
            this.groupBox2.Controls.Add(this.mlblTürGünc);
            this.groupBox2.Location = new System.Drawing.Point(332, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(209, 149);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // mBtnGüncelle
            // 
            this.mBtnGüncelle.Location = new System.Drawing.Point(62, 124);
            this.mBtnGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnGüncelle.Name = "mBtnGüncelle";
            this.mBtnGüncelle.Size = new System.Drawing.Size(91, 19);
            this.mBtnGüncelle.TabIndex = 13;
            this.mBtnGüncelle.Text = "Güncelle";
            this.mBtnGüncelle.Click += new System.EventHandler(this.mBtnGüncelle_Click);
            // 
            // mtbxTürGünc
            // 
            this.mtbxTürGünc.Location = new System.Drawing.Point(114, 89);
            this.mtbxTürGünc.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxTürGünc.Name = "mtbxTürGünc";
            this.mtbxTürGünc.Size = new System.Drawing.Size(86, 19);
            this.mtbxTürGünc.TabIndex = 9;
            // 
            // mtbxTürkceGünc
            // 
            this.mtbxTürkceGünc.Location = new System.Drawing.Point(114, 56);
            this.mtbxTürkceGünc.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxTürkceGünc.Name = "mtbxTürkceGünc";
            this.mtbxTürkceGünc.Size = new System.Drawing.Size(86, 19);
            this.mtbxTürkceGünc.TabIndex = 8;
            // 
            // mtbxİngilizceGünc
            // 
            this.mtbxİngilizceGünc.Location = new System.Drawing.Point(114, 24);
            this.mtbxİngilizceGünc.Margin = new System.Windows.Forms.Padding(2);
            this.mtbxİngilizceGünc.Name = "mtbxİngilizceGünc";
            this.mtbxİngilizceGünc.Size = new System.Drawing.Size(86, 19);
            this.mtbxİngilizceGünc.TabIndex = 7;
            // 
            // mlblİngilizceGünc
            // 
            this.mlblİngilizceGünc.AutoSize = true;
            this.mlblİngilizceGünc.Location = new System.Drawing.Point(12, 27);
            this.mlblİngilizceGünc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblİngilizceGünc.Name = "mlblİngilizceGünc";
            this.mlblİngilizceGünc.Size = new System.Drawing.Size(101, 19);
            this.mlblİngilizceGünc.TabIndex = 4;
            this.mlblİngilizceGünc.Text = "İngilizce Kelime:";
            // 
            // mlblTürkceGünc
            // 
            this.mlblTürkceGünc.AutoSize = true;
            this.mlblTürkceGünc.Location = new System.Drawing.Point(12, 58);
            this.mlblTürkceGünc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblTürkceGünc.Name = "mlblTürkceGünc";
            this.mlblTürkceGünc.Size = new System.Drawing.Size(91, 19);
            this.mlblTürkceGünc.TabIndex = 5;
            this.mlblTürkceGünc.Text = "Türkçe Kelime:";
            // 
            // mlblTürGünc
            // 
            this.mlblTürGünc.AutoSize = true;
            this.mlblTürGünc.Location = new System.Drawing.Point(12, 92);
            this.mlblTürGünc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblTürGünc.Name = "mlblTürGünc";
            this.mlblTürGünc.Size = new System.Drawing.Size(96, 19);
            this.mlblTürGünc.TabIndex = 6;
            this.mlblTürGünc.Text = "Kelimenin Türü:";
            // 
            // dgWKelimeler
            // 
            this.dgWKelimeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgWKelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWKelimeler.Location = new System.Drawing.Point(29, 62);
            this.dgWKelimeler.Margin = new System.Windows.Forms.Padding(2);
            this.dgWKelimeler.Name = "dgWKelimeler";
            this.dgWKelimeler.RowTemplate.Height = 24;
            this.dgWKelimeler.Size = new System.Drawing.Size(512, 141);
            this.dgWKelimeler.TabIndex = 11;
            this.dgWKelimeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgWKelimeler_CellClick);
            // 
            // mBtnSil
            // 
            this.mBtnSil.Location = new System.Drawing.Point(246, 334);
            this.mBtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnSil.Name = "mBtnSil";
            this.mBtnSil.Size = new System.Drawing.Size(82, 19);
            this.mBtnSil.TabIndex = 13;
            this.mBtnSil.Text = "Sil";
            this.mBtnSil.Click += new System.EventHandler(this.mBtnSil_Click);
            // 
            // mBtnAnaEkran
            // 
            this.mBtnAnaEkran.Location = new System.Drawing.Point(32, 358);
            this.mBtnAnaEkran.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnAnaEkran.Name = "mBtnAnaEkran";
            this.mBtnAnaEkran.Size = new System.Drawing.Size(91, 19);
            this.mBtnAnaEkran.TabIndex = 13;
            this.mBtnAnaEkran.Text = "Ana Menü";
            this.mBtnAnaEkran.Click += new System.EventHandler(this.mBtnAnaEkran_Click);
            // 
            // mBtnTestEkranıK
            // 
            this.mBtnTestEkranıK.Location = new System.Drawing.Point(450, 358);
            this.mBtnTestEkranıK.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnTestEkranıK.Name = "mBtnTestEkranıK";
            this.mBtnTestEkranıK.Size = new System.Drawing.Size(91, 19);
            this.mBtnTestEkranıK.TabIndex = 14;
            this.mBtnTestEkranıK.Text = "Test Ekranı";
            this.mBtnTestEkranıK.Click += new System.EventHandler(this.mBtnTestEkranıK_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mlblGüncelTarih
            // 
            this.mlblGüncelTarih.AutoSize = true;
            this.mlblGüncelTarih.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblGüncelTarih.Location = new System.Drawing.Point(229, 31);
            this.mlblGüncelTarih.Name = "mlblGüncelTarih";
            this.mlblGüncelTarih.Size = new System.Drawing.Size(0, 0);
            this.mlblGüncelTarih.TabIndex = 15;
            // 
            // KelimeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 385);
            this.Controls.Add(this.mlblGüncelTarih);
            this.Controls.Add(this.mBtnTestEkranıK);
            this.Controls.Add(this.mBtnAnaEkran);
            this.Controls.Add(this.mBtnSil);
            this.Controls.Add(this.dgWKelimeler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KelimeFormu";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "KelimeFormu";
            this.Load += new System.EventHandler(this.KelimeFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgWKelimeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblİngilizceKelime;
        private MetroFramework.Controls.MetroLabel mlblTürkceKelime;
        private MetroFramework.Controls.MetroLabel mlblTür;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox mtbxİngilizce;
        private MetroFramework.Controls.MetroTextBox mtbxTür;
        private MetroFramework.Controls.MetroTextBox mtbxTürkce;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox mtbxTürGünc;
        private MetroFramework.Controls.MetroTextBox mtbxTürkceGünc;
        private MetroFramework.Controls.MetroTextBox mtbxİngilizceGünc;
        private MetroFramework.Controls.MetroLabel mlblİngilizceGünc;
        private MetroFramework.Controls.MetroLabel mlblTürkceGünc;
        private MetroFramework.Controls.MetroLabel mlblTürGünc;
        private System.Windows.Forms.DataGridView dgWKelimeler;
        private MetroFramework.Controls.MetroButton mBtnEkle;
        private MetroFramework.Controls.MetroButton mBtnGüncelle;
        private MetroFramework.Controls.MetroButton mBtnSil;
        private MetroFramework.Controls.MetroButton mBtnAnaEkran;
        private MetroFramework.Controls.MetroButton mBtnTestEkranıK;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel mlblGüncelTarih;
    }
}