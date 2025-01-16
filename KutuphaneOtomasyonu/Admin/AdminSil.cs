using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Admin
{
    public partial class AdminSil : Form
    {
        public AdminSil()
        {
            InitializeComponent();
        }
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
        public void Listele()
        {
            var Admin = db.Kullanıcılar.ToList();
            dataGridView1.DataSource = Admin.ToList();

            // istenmeyen kolonları gizledim
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            // Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Kod";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Telefon";
            dataGridView1.Columns[6].HeaderText = "Username";
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult SilinsinMi = MessageBox.Show("Okuyucu Silinecek, Onaylıyor musun?", "Okuyucu Sil", MessageBoxButtons.YesNo);

            if (SilinsinMi == DialogResult.Yes)
            {
                int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var admin = db.Kullanıcılar.Where(x => x.Id == SeçilenId).FirstOrDefault();
                db.Kullanıcılar.Remove(admin);
                db.SaveChanges();
                Listele();
                MessageBox.Show("OKUYUCU SİLİNDİ");
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }
        }

        private void AdminSil_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
