using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SözlükUygulaması
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void mBtnWord_Click(object sender, EventArgs e)
        {
            KelimeEkranı KelimeForm = new KelimeEkranı();
            KelimeForm.Show();
            this.Hide();
        }

        private void mBtnTest_Click(object sender, EventArgs e)
        {
            Test ftest = new Test();
            ftest.Show();
            Hide();
        }

        private void mBtnStatistics_Click(object sender, EventArgs e)
        {
            İstatistik frm = new İstatistik();
            frm.Show();
            Hide();
        }

    }
}
