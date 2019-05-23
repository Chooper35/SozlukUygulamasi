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
    public partial class Test : MetroFramework.Forms.MetroForm
    {
        public Test()
        {
            InitializeComponent();
        }
        int puan = 0;
        WordsDatabaseContext wdb = new WordsDatabaseContext();
        WordDal wordDal = new WordDal();
        private void Test_Load(object sender, EventArgs e)
        {           
            RandomSoruGetirme();
        }
        int ögrenmDurumdeger;
        private void mBtnAnaMenüT_Click(object sender, EventArgs e)
        {
            Form1 ffrm = new Form1();
            ffrm.Show();
            this.Hide();
        }
        public void RandomSoruGetirme()
        {
            
            var random = wdb.Words.OrderBy(x => Guid.NewGuid()).FirstOrDefault();           
            DateTime güncelTarih = DateTime.Now;
            DateTime girilenTarih = random.GirilenTarih;
            mlblGüncelTarih.Text = güncelTarih.ToString();
            mlblOgrenme.Text = random.ÖgrenmeDurumu.ToString();
            ögrenmDurumdeger = Convert.ToInt32(mlblOgrenme.Text);
            TimeSpan tarihSonuc = güncelTarih - girilenTarih;
            int days = tarihSonuc.Days;
            if (ögrenmDurumdeger==1 && days>1)
            {
                mlblSoru.Text = random.İngilizceKelime;
                mlblGizli.Text = random.TürkceKelime;
                mlblTarih.Text = random.GirilenTarih.ToString();
            }
            else if(ögrenmDurumdeger==2 && days>7)
            {
                mlblSoru.Text = random.İngilizceKelime;
                mlblGizli.Text = random.TürkceKelime;
                mlblTarih.Text = random.GirilenTarih.ToString();
            }
            else if(ögrenmDurumdeger==3 && days>30)
            {
                mlblSoru.Text = random.İngilizceKelime;
                mlblGizli.Text = random.TürkceKelime;
                mlblTarih.Text = random.GirilenTarih.ToString();
            }
            else
            {
                mlblSoru.Text = " ";
                mlblGizli.Text = " ";
                mlblTarih.Text = " ";
            }
            
            //foreach (var word in wordDal.GetByState(7))
            //{
            //    mlblSoru.Text = word.İngilizceKelime;
            //}
        }

        private void mBtnDigerSoru_Click(object sender, EventArgs e)
        {
            RandomSoruGetirme();
        }

        private void mBtnKontrol_Click(object sender, EventArgs e)
        {
            WordsDatabaseContext wdb1 = new WordsDatabaseContext();
            if (mtbxCevap.Text == mlblGizli.Text) 
            {
                string kelime = mlblSoru.Text;
                var guncellenicekKelime = wdb.Words.Where(w => w.İngilizceKelime==kelime).FirstOrDefault();
               
                guncellenicekKelime.ÖgrenmeDurumu += 1;
                wdb.SaveChanges();
                puan += 10;
            }
            mlblPuan.Text = "Puan:"+puan.ToString();
            RandomSoruGetirme();
        }
   
        
    }
}
