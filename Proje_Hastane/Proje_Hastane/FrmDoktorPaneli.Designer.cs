﻿namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label11 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ad:";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(135, 97);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(130, 31);
            this.CmbBrans.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Branş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(135, 22);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(130, 31);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(135, 60);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(130, 31);
            this.TxtSoyad.TabIndex = 2;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(135, 134);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(130, 31);
            this.MskTC.TabIndex = 4;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(135, 173);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(130, 31);
            this.TxtSifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 285);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(135, 220);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(61, 37);
            this.BtnEkle.TabIndex = 26;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(204, 220);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(61, 37);
            this.BtnSil.TabIndex = 27;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(135, 263);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(130, 37);
            this.BtnGuncelle.TabIndex = 28;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1104, 324);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}