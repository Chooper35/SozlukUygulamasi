namespace SözlükUygulaması
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
            this.mBtnWord = new MetroFramework.Controls.MetroButton();
            this.mBtnStatistics = new MetroFramework.Controls.MetroButton();
            this.mBtnTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mBtnWord
            // 
            this.mBtnWord.Location = new System.Drawing.Point(46, 70);
            this.mBtnWord.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnWord.Name = "mBtnWord";
            this.mBtnWord.Size = new System.Drawing.Size(134, 39);
            this.mBtnWord.TabIndex = 0;
            this.mBtnWord.Text = "KELİME ÖĞREN";
            this.mBtnWord.Click += new System.EventHandler(this.mBtnWord_Click);
            // 
            // mBtnStatistics
            // 
            this.mBtnStatistics.Location = new System.Drawing.Point(46, 143);
            this.mBtnStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnStatistics.Name = "mBtnStatistics";
            this.mBtnStatistics.Size = new System.Drawing.Size(134, 39);
            this.mBtnStatistics.TabIndex = 1;
            this.mBtnStatistics.Text = "İSTATİSTİK";
            this.mBtnStatistics.Click += new System.EventHandler(this.mBtnStatistics_Click);
            // 
            // mBtnTest
            // 
            this.mBtnTest.Location = new System.Drawing.Point(46, 218);
            this.mBtnTest.Margin = new System.Windows.Forms.Padding(2);
            this.mBtnTest.Name = "mBtnTest";
            this.mBtnTest.Size = new System.Drawing.Size(134, 39);
            this.mBtnTest.TabIndex = 2;
            this.mBtnTest.Text = "TEST";
            this.mBtnTest.Click += new System.EventHandler(this.mBtnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 294);
            this.Controls.Add(this.mBtnTest);
            this.Controls.Add(this.mBtnStatistics);
            this.Controls.Add(this.mBtnWord);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnWord;
        private MetroFramework.Controls.MetroButton mBtnStatistics;
        private MetroFramework.Controls.MetroButton mBtnTest;
    }
}

