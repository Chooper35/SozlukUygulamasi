namespace SözlükUygulaması
{
    partial class İstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartÖğrenme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mBtnGeri = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartÖğrenme)).BeginInit();
            this.SuspendLayout();
            // 
            // chartÖğrenme
            // 
            chartArea1.Name = "ChartArea1";
            this.chartÖğrenme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartÖğrenme.Legends.Add(legend1);
            this.chartÖğrenme.Location = new System.Drawing.Point(23, 63);
            this.chartÖğrenme.Name = "chartÖğrenme";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ÖğrenmeDurumu";
            this.chartÖğrenme.Series.Add(series1);
            this.chartÖğrenme.Size = new System.Drawing.Size(1119, 440);
            this.chartÖğrenme.TabIndex = 0;
            this.chartÖğrenme.Text = "chart1";
            // 
            // mBtnGeri
            // 
            this.mBtnGeri.Location = new System.Drawing.Point(897, 543);
            this.mBtnGeri.Name = "mBtnGeri";
            this.mBtnGeri.Size = new System.Drawing.Size(111, 23);
            this.mBtnGeri.TabIndex = 1;
            this.mBtnGeri.Text = "Ana Menü";
            this.mBtnGeri.Click += new System.EventHandler(this.mBtnGeri_Click);
            // 
            // İstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 601);
            this.Controls.Add(this.mBtnGeri);
            this.Controls.Add(this.chartÖğrenme);
            this.Name = "İstatistik";
            this.Text = "İstatistik";
            this.Load += new System.EventHandler(this.İstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartÖğrenme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartÖğrenme;
        private MetroFramework.Controls.MetroButton mBtnGeri;
    }
}