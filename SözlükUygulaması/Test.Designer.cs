namespace SözlükUygulaması
{
    partial class Test
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
            this.mlblSoru = new MetroFramework.Controls.MetroLabel();
            this.mBtnAnaMenüT = new MetroFramework.Controls.MetroButton();
            this.mBtnDigerSoru = new MetroFramework.Controls.MetroButton();
            this.mtbxCevap = new MetroFramework.Controls.MetroTextBox();
            this.mlblGizli = new MetroFramework.Controls.MetroLabel();
            this.mlblPuan = new MetroFramework.Controls.MetroLabel();
            this.mBtnKontrol = new MetroFramework.Controls.MetroButton();
            this.mlblTarih = new MetroFramework.Controls.MetroLabel();
            this.mlblGüncelTarih = new MetroFramework.Controls.MetroLabel();
            this.mlblOgrenme = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mlblSoru
            // 
            this.mlblSoru.AutoSize = true;
            this.mlblSoru.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlblSoru.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlblSoru.Location = new System.Drawing.Point(41, 176);
            this.mlblSoru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mlblSoru.Name = "mlblSoru";
            this.mlblSoru.Size = new System.Drawing.Size(0, 0);
            this.mlblSoru.TabIndex = 0;
            this.mlblSoru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mBtnAnaMenüT
            // 
            this.mBtnAnaMenüT.Location = new System.Drawing.Point(17, 325);
            this.mBtnAnaMenüT.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnAnaMenüT.Name = "mBtnAnaMenüT";
            this.mBtnAnaMenüT.Size = new System.Drawing.Size(105, 22);
            this.mBtnAnaMenüT.TabIndex = 1;
            this.mBtnAnaMenüT.Text = "Ana Menü";
            this.mBtnAnaMenüT.Click += new System.EventHandler(this.mBtnAnaMenüT_Click);
            // 
            // mBtnDigerSoru
            // 
            this.mBtnDigerSoru.Location = new System.Drawing.Point(230, 325);
            this.mBtnDigerSoru.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnDigerSoru.Name = "mBtnDigerSoru";
            this.mBtnDigerSoru.Size = new System.Drawing.Size(105, 22);
            this.mBtnDigerSoru.TabIndex = 2;
            this.mBtnDigerSoru.Text = "Sonraki Soru";
            this.mBtnDigerSoru.Click += new System.EventHandler(this.mBtnDigerSoru_Click);
            // 
            // mtbxCevap
            // 
            this.mtbxCevap.Location = new System.Drawing.Point(165, 176);
            this.mtbxCevap.Name = "mtbxCevap";
            this.mtbxCevap.Size = new System.Drawing.Size(110, 23);
            this.mtbxCevap.TabIndex = 3;
            // 
            // mlblGizli
            // 
            this.mlblGizli.AutoSize = true;
            this.mlblGizli.Location = new System.Drawing.Point(165, 109);
            this.mlblGizli.Name = "mlblGizli";
            this.mlblGizli.Size = new System.Drawing.Size(0, 0);
            this.mlblGizli.TabIndex = 4;
            this.mlblGizli.Visible = false;
            // 
            // mlblPuan
            // 
            this.mlblPuan.AutoSize = true;
            this.mlblPuan.Location = new System.Drawing.Point(165, 202);
            this.mlblPuan.Name = "mlblPuan";
            this.mlblPuan.Size = new System.Drawing.Size(45, 19);
            this.mlblPuan.TabIndex = 5;
            this.mlblPuan.Text = "Puan :";
            // 
            // mBtnKontrol
            // 
            this.mBtnKontrol.Location = new System.Drawing.Point(165, 225);
            this.mBtnKontrol.Name = "mBtnKontrol";
            this.mBtnKontrol.Size = new System.Drawing.Size(110, 23);
            this.mBtnKontrol.TabIndex = 6;
            this.mBtnKontrol.Text = "Kontrol Et";
            this.mBtnKontrol.Click += new System.EventHandler(this.mBtnKontrol_Click);
            // 
            // mlblTarih
            // 
            this.mlblTarih.AutoSize = true;
            this.mlblTarih.Location = new System.Drawing.Point(68, 117);
            this.mlblTarih.Name = "mlblTarih";
            this.mlblTarih.Size = new System.Drawing.Size(0, 0);
            this.mlblTarih.TabIndex = 7;
            this.mlblTarih.Visible = false;
            // 
            // mlblGüncelTarih
            // 
            this.mlblGüncelTarih.AutoSize = true;
            this.mlblGüncelTarih.Location = new System.Drawing.Point(133, 259);
            this.mlblGüncelTarih.Name = "mlblGüncelTarih";
            this.mlblGüncelTarih.Size = new System.Drawing.Size(83, 19);
            this.mlblGüncelTarih.TabIndex = 9;
            this.mlblGüncelTarih.Text = "metroLabel2";
            this.mlblGüncelTarih.Visible = false;
            // 
            // mlblOgrenme
            // 
            this.mlblOgrenme.AutoSize = true;
            this.mlblOgrenme.Location = new System.Drawing.Point(179, 297);
            this.mlblOgrenme.Name = "mlblOgrenme";
            this.mlblOgrenme.Size = new System.Drawing.Size(81, 19);
            this.mlblOgrenme.TabIndex = 10;
            this.mlblOgrenme.Text = "metroLabel1";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 366);
            this.Controls.Add(this.mlblOgrenme);
            this.Controls.Add(this.mlblGüncelTarih);
            this.Controls.Add(this.mlblTarih);
            this.Controls.Add(this.mBtnKontrol);
            this.Controls.Add(this.mlblPuan);
            this.Controls.Add(this.mlblGizli);
            this.Controls.Add(this.mtbxCevap);
            this.Controls.Add(this.mBtnDigerSoru);
            this.Controls.Add(this.mBtnAnaMenüT);
            this.Controls.Add(this.mlblSoru);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Test";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlblSoru;
        private MetroFramework.Controls.MetroButton mBtnAnaMenüT;
        private MetroFramework.Controls.MetroButton mBtnDigerSoru;
        private MetroFramework.Controls.MetroTextBox mtbxCevap;
        private MetroFramework.Controls.MetroLabel mlblGizli;
        private MetroFramework.Controls.MetroLabel mlblPuan;
        private MetroFramework.Controls.MetroButton mBtnKontrol;
        private MetroFramework.Controls.MetroLabel mlblTarih;
        private MetroFramework.Controls.MetroLabel mlblGüncelTarih;
        private MetroFramework.Controls.MetroLabel mlblOgrenme;
    }
}