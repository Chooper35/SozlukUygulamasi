namespace SözlükProjesi
{
    partial class MainMenu1
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
            this.mBtnTest = new MetroFramework.Controls.MetroButton();
            this.mBtnStatistics = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mBtnWord
            // 
            this.mBtnWord.Location = new System.Drawing.Point(65, 63);
            this.mBtnWord.Name = "mBtnWord";
            this.mBtnWord.Size = new System.Drawing.Size(133, 32);
            this.mBtnWord.TabIndex = 0;
            this.mBtnWord.Text = "KELİME ÖĞREN";
            // 
            // mBtnTest
            // 
            this.mBtnTest.Location = new System.Drawing.Point(65, 124);
            this.mBtnTest.Name = "mBtnTest";
            this.mBtnTest.Size = new System.Drawing.Size(133, 33);
            this.mBtnTest.TabIndex = 1;
            this.mBtnTest.Text = "TEST";
            // 
            // mBtnStatistics
            // 
            this.mBtnStatistics.Location = new System.Drawing.Point(65, 186);
            this.mBtnStatistics.Name = "mBtnStatistics";
            this.mBtnStatistics.Size = new System.Drawing.Size(133, 33);
            this.mBtnStatistics.TabIndex = 3;
            this.mBtnStatistics.Text = "İSTATİSTİK";
            // 
            // MainMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 276);
            this.Controls.Add(this.mBtnStatistics);
            this.Controls.Add(this.mBtnTest);
            this.Controls.Add(this.mBtnWord);
            this.Name = "MainMenu1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnWord;
        private MetroFramework.Controls.MetroButton mBtnTest;
        private MetroFramework.Controls.MetroButton mBtnStatistics;
    }
}

