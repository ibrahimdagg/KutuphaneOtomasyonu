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
    public partial class AdminDüzenle : Form
    {
        public AdminDüzenle()
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
            dataGridView1.Columns[4].HeaderText = "Telefon";
            dataGridView1.Columns[5].HeaderText = "Mail";
            dataGridView1.Columns[6].HeaderText = "Username";
        }

        private void AdminDüzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void OkuyucuDüzenlebtn_Click_1(object sender, EventArgs e)
        {
            int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var admin = db.Kullanıcılar.Where(x => x.Id == SeçilenId).FirstOrDefault();

            admin.Ad = EkleAdtxt.Text;
            admin.Soyad = EkleSoyadtxt.Text;
            admin.TC = EkleTCtxt.Text;
            admin.Telefon = EkleTelefontxt.Text;
            admin.Email = EkleMailtxt.Text;
            admin.AdminAd = EkleUsernametxt.Text;
            admin.Şifre = EkleSifretxt.Text;
            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EkleAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EkleSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EkleTCtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EkleTelefontxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EkleMailtxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            EkleSifretxt.Text = "";
            EkleUsernametxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
