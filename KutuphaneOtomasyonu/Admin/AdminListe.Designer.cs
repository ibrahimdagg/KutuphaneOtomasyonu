
namespace KutuphaneOtomasyonu.Admin
{
    partial class AdminListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kullanıcılarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphane_OtomasyonuDataSet = new KutuphaneOtomasyonu.Kütüphane_OtomasyonuDataSet();
            this.kullanıcılarTableAdapter = new KutuphaneOtomasyonu.Kütüphane_OtomasyonuDataSetTableAdapters.KullanıcılarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphane_OtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanıcılarBindingSource
            // 
            this.kullanıcılarBindingSource.DataMember = "Kullanıcılar";
            this.kullanıcılarBindingSource.DataSource = this.kütüphane_OtomasyonuDataSet;
            // 
            // kütüphane_OtomasyonuDataSet
            // 
            this.kütüphane_OtomasyonuDataSet.DataSetName = "Kütüphane_OtomasyonuDataSet";
            this.kütüphane_OtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanıcılarTableAdapter
            // 
            this.kullanıcılarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminListe";
            this.Text = "AdminListe";
            this.Load += new System.EventHandler(this.AdminListe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphane_OtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Kütüphane_OtomasyonuDataSet kütüphane_OtomasyonuDataSet;
        private System.Windows.Forms.BindingSource kullanıcılarBindingSource;
        private Kütüphane_OtomasyonuDataSetTableAdapters.KullanıcılarTableAdapter kullanıcılarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}