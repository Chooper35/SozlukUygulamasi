using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SözlükUygulaması
{
    public partial class KelimeEkranı : MetroFramework.Forms.MetroForm
    {
        public KelimeEkranı()
        {
            InitializeComponent();
        }
        WordDal _wordDal = new WordDal();
        private void mBtnAnaEkran_Click(object sender, EventArgs e)
        {
            //Ana Menüye Dönüş Kodları
            Form1 nform1 = new Form1();
            nform1.Show();
            this.Hide();
        }

        private void mBtnTestEkranıK_Click(object sender, EventArgs e)
        {
            //Test Ekranına geçiş
            Test ftest2 = new Test();
            ftest2.Show();
            this.Hide();

        }

        private void KelimeFormu_Load(object sender, EventArgs e)
        {
            //Güncel saat ve tarihi alması için timeri enabled duruma getiriyoruz.
            timer1.Enabled = true;
            LoadWords();
        }

        private void mBtnEkle_Click(object sender, EventArgs e)
        {
            //Database işlemleri sınıfından yeni kelime sınıfı  oluşturuyoruz
            _wordDal.Add(new Word
            {
                İngilizceKelime = mtbxİngilizce.Text,
                TürkceKelime = mtbxTürkce.Text,
                KelimeTürü = mtbxTür.Text,
                GirilenTarih = DateTime.Now,
                ÖgrenmeDurumu = 1,

            });
            LoadWords();
            MessageBox.Show("Kelime Eklendi");
        }
        //Kelimeleri datagridviewde güncelleyen fonksiyon
        public void LoadWords()
        {
            dgWKelimeler.DataSource = _wordDal.GetAll();
        }

        private void mBtnGüncelle_Click(object sender, EventArgs e)
        {
            _wordDal.Update(new Word
            {
                Id = Convert.ToInt32(dgWKelimeler.CurrentRow.Cells[0].Value),
                İngilizceKelime = mtbxİngilizceGünc.Text,
                TürkceKelime = mtbxTürkceGünc.Text,
                KelimeTürü = mtbxTürGünc.Text,
                GirilenTarih = DateTime.Now,
                ÖgrenmeDurumu=1,

            });

            LoadWords();
            MessageBox.Show("Kelime Güncellendi");
        }
        private void dgWKelimeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtbxİngilizceGünc.Text = dgWKelimeler.CurrentRow.Cells[1].Value.ToString();
            mtbxTürkceGünc.Text = dgWKelimeler.CurrentRow.Cells[2].Value.ToString();
            mtbxTürGünc.Text = dgWKelimeler.CurrentRow.Cells[3].Value.ToString();
        }

        private void mBtnSil_Click(object sender, EventArgs e)
        {
            _wordDal.Delete(new Word
            {
                Id = Convert.ToInt32(dgWKelimeler.CurrentRow.Cells[0].Value)
            });
            LoadWords();
            MessageBox.Show("Kelime Silindi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            mlblGüncelTarih.Text = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month + "." + DateTime.Now.Year + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(); ;
        }
    }
}

