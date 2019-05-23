using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace SözlükUygulaması
{
    public partial class İstatistik : MetroFramework.Forms.MetroForm
    {
        public İstatistik()
        {
            InitializeComponent();
        }

        private void İstatistik_Load(object sender, EventArgs e)
        {
            //Grafik Fonksiyonunu Çağırıyoruz
            Grafik();
        }

        private void mBtnGeri_Click(object sender, EventArgs e)
        {
            //Ana Menüye Dönüş Formu
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }
        public void Grafik()
        {
            //Database context nesnesini oluşturuyoruz.
            var _context = new WordsDatabaseContext();
            this.chartÖğrenme.Titles.Add("KELİMENİN GİRİLDİĞİ TARİHE GÖRE ÖĞRENİM DURUMU");
            Series series1 = new Series();
            series1.Name = "2019";
            //Kelimenin girildiği tarihe göre öğrenme durumunu sıralıyoruz.
            var durum = _context.Words.Where(s => s.ÖgrenmeDurumu == 1).ToList<Word>();
            foreach (var word in durum)
            {
                chartÖğrenme.Series["ÖğrenmeDurumu"].Points.AddXY(word.GirilenTarih, word.ÖgrenmeDurumu);
                break;
            }
            var durum1 = _context.Words.Where(s => s.ÖgrenmeDurumu == 2).ToList<Word>();
            {
                foreach (var word in durum1)
                {
                    chartÖğrenme.Series["ÖğrenmeDurumu"].Points.AddXY(word.GirilenTarih, word.ÖgrenmeDurumu);
                    break;
                }
            }
            var durum2 = _context.Words.Where(s => s.ÖgrenmeDurumu == 3).ToList<Word>();
            {
                foreach (var word in durum2)
                {
                    chartÖğrenme.Series["ÖğrenmeDurumu"].Points.AddXY(word.GirilenTarih, word.ÖgrenmeDurumu);
                    break;
                }
            }
            var durum3 = _context.Words.Where(s => s.ÖgrenmeDurumu == 4).ToList<Word>();
            {
                foreach (var word in durum3)
                {
                    chartÖğrenme.Series["ÖğrenmeDurumu"].Points.AddXY(word.GirilenTarih, word.ÖgrenmeDurumu);
                    break;
                }
            }
            var durum4 = _context.Words.Where(s => s.ÖgrenmeDurumu == 5).ToList<Word>();
            {
                foreach (var word in durum4)
                {
                    chartÖğrenme.Series["ÖğrenmeDurumu"].Points.AddXY(word.GirilenTarih, word.ÖgrenmeDurumu);
                    break;
                }
            }
            _context.SaveChanges();
            
            }
        }
    }

