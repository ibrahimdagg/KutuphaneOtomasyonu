﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kitap_İşlem
{
    public partial class Geri_Al : Form
    {
        public Geri_Al()
        {
            InitializeComponent();
        }

        KütüphaneOtomasyonuEntities db = new KütüphaneOtomasyonuEntities();

        private void Geri_Al_Load(object sender, EventArgs e)
        {
            var ÖdünçKitap = db.ÖdünçKitaplar.Where(x => x.GeriVerildiMi == false).ToList();
            dataGridView1.DataSource = ÖdünçKitap.ToList();

            //istenmeyen kolonları gizledim
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            // Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView1.Columns[1].HeaderText = "Alan Okuyucu";
            dataGridView1.Columns[2].HeaderText = "Veren Okuyucu";
            dataGridView1.Columns[3].HeaderText = "Kitap Adı";
            dataGridView1.Columns[4].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Veriş Tarihi";
            dataGridView1.Columns[6].HeaderText = "Geri Verildi Mi?";
        }

        private void İadeEtbtn_Click(object sender, EventArgs e)
        {
            int SeçilenKitapId = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            var Kitap = db.ÖdünçKitaplar.Where(x => x.ÖdünçId == SeçilenKitapId).FirstOrDefault();
            Kitap.GeriVerildiMi = true;
            db.SaveChanges();
            var ÖdünçKitap = db.ÖdünçKitaplar.Where(x => x.GeriVerildiMi == false).ToList();
            dataGridView1.DataSource = ÖdünçKitap.ToList();

           
        }
    }
}
