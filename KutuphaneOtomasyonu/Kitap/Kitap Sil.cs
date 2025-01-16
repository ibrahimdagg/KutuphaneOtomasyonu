using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kitap
{
    public partial class Kitap_Sil : Form
    {
        public Kitap_Sil()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        private void Kitap_Sil_Load(object sender, EventArgs e)
        {
            try
            {
                var Kitaplar = db.Kaynaklar.ToList();
                dataGridView1.DataSource = Kitaplar.ToList();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void Listele()
        {
            try
            {
                var Kitaplar = db.Kaynaklar.ToList();
                dataGridView1.DataSource = Kitaplar.ToList();

                // istenmeyen kolonları gizledim
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;

                // Veritabanından gelen kolon isimlerini değiştirdim
                dataGridView1.Columns[1].HeaderText = "Kitap Adı";
                dataGridView1.Columns[2].HeaderText = "Yazarı";
                dataGridView1.Columns[3].HeaderText = "Türü";
                dataGridView1.Columns[4].HeaderText = "Yayınevi";
                dataGridView1.Columns[5].HeaderText = "Sayfa Sayısı";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void KitapSilbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult SilinsinMi = MessageBox.Show("Kitap Silinecek, Onaylıyor musun?", "Kitap Sil", MessageBoxButtons.YesNo);
                if (SilinsinMi == DialogResult.Yes)
                {
                    int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    var kitap = db.Kaynaklar.Where(x => x.KitapId == SeçilenId).FirstOrDefault();
                    if (kitap != null)
                    {
                        db.Kaynaklar.Remove(kitap);
                        db.SaveChanges();
                        Listele();
                        MessageBox.Show("KİTAP SİLİNDİ");
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kitap bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}