﻿
namespace KutuphaneOtomasyonu.Kitap_İşlem
{
    partial class Takip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OkuyucuBulbtn = new System.Windows.Forms.Button();
            this.KitapAratxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(623, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // OkuyucuBulbtn
            // 
            this.OkuyucuBulbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(64)))), ((int)(((byte)(90)))));
            this.OkuyucuBulbtn.Location = new System.Drawing.Point(159, 354);
            this.OkuyucuBulbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OkuyucuBulbtn.Name = "OkuyucuBulbtn";
            this.OkuyucuBulbtn.Size = new System.Drawing.Size(224, 37);
            this.OkuyucuBulbtn.TabIndex = 1;
            this.OkuyucuBulbtn.Text = "Okuyucuyu Bul";
            this.OkuyucuBulbtn.UseVisualStyleBackColor = false;
            this.OkuyucuBulbtn.Click += new System.EventHandler(this.OkuyucuBulbtn_Click);
            // 
            // KitapAratxt
            // 
            this.KitapAratxt.Location = new System.Drawing.Point(16, 15);
            this.KitapAratxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.KitapAratxt.Name = "KitapAratxt";
            this.KitapAratxt.Size = new System.Drawing.Size(523, 22);
            this.KitapAratxt.TabIndex = 2;
            this.KitapAratxt.TextChanged += new System.EventHandler(this.KitapAratxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(644, 68);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(404, 22);
            this.dataGridView2.TabIndex = 4;
            // 
            // Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KitapAratxt);
            this.Controls.Add(this.OkuyucuBulbtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Takip";
            this.Text = "Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Takip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button OkuyucuBulbtn;
        private System.Windows.Forms.TextBox KitapAratxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}