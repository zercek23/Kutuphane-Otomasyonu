﻿namespace Veritabanı_Proje
{
    partial class UyeEkle
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
            this.sifreText = new System.Windows.Forms.TextBox();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ilceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cinsiyetComboBox = new System.Windows.Forms.ComboBox();
            this.ilComboBox = new System.Windows.Forms.ComboBox();
            this.adresText = new System.Windows.Forms.TextBox();
            this.epostaText = new System.Windows.Forms.TextBox();
            this.telefonText = new System.Windows.Forms.TextBox();
            this.adSoyadText = new System.Windows.Forms.TextBox();
            this.tcText = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.okulAdicomboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(184, 90);
            this.sifreText.Margin = new System.Windows.Forms.Padding(4);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(132, 22);
            this.sifreText.TabIndex = 95;
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.Location = new System.Drawing.Point(184, 61);
            this.kullaniciAdiText.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(132, 22);
            this.kullaniciAdiText.TabIndex = 94;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Şifre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 61);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 92;
            this.label13.Text = "Kullanıcı Adı";
            // 
            // ilceComboBox
            // 
            this.ilceComboBox.FormattingEnabled = true;
            this.ilceComboBox.Location = new System.Drawing.Point(184, 233);
            this.ilceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ilceComboBox.Name = "ilceComboBox";
            this.ilceComboBox.Size = new System.Drawing.Size(133, 24);
            this.ilceComboBox.TabIndex = 91;
            this.ilceComboBox.SelectedIndexChanged += new System.EventHandler(this.ilceComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 90;
            this.label3.Text = "İlçe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(30, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 89;
            this.label12.Text = "Üye Ekle";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 176);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(182, 358);
            this.cinsiyetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(133, 24);
            this.cinsiyetComboBox.TabIndex = 87;
            this.cinsiyetComboBox.Text = "Erkek";
            // 
            // ilComboBox
            // 
            this.ilComboBox.FormattingEnabled = true;
            this.ilComboBox.Location = new System.Drawing.Point(184, 204);
            this.ilComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ilComboBox.Name = "ilComboBox";
            this.ilComboBox.Size = new System.Drawing.Size(133, 24);
            this.ilComboBox.TabIndex = 86;
            this.ilComboBox.SelectedIndexChanged += new System.EventHandler(this.ilComboBox_SelectedIndexChanged);
            // 
            // adresText
            // 
            this.adresText.Location = new System.Drawing.Point(182, 388);
            this.adresText.Margin = new System.Windows.Forms.Padding(4);
            this.adresText.Multiline = true;
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(220, 82);
            this.adresText.TabIndex = 85;
            // 
            // epostaText
            // 
            this.epostaText.Location = new System.Drawing.Point(182, 327);
            this.epostaText.Margin = new System.Windows.Forms.Padding(4);
            this.epostaText.Name = "epostaText";
            this.epostaText.Size = new System.Drawing.Size(132, 22);
            this.epostaText.TabIndex = 84;
            // 
            // telefonText
            // 
            this.telefonText.Location = new System.Drawing.Point(182, 298);
            this.telefonText.Margin = new System.Windows.Forms.Padding(4);
            this.telefonText.Name = "telefonText";
            this.telefonText.Size = new System.Drawing.Size(132, 22);
            this.telefonText.TabIndex = 83;
            // 
            // adSoyadText
            // 
            this.adSoyadText.Location = new System.Drawing.Point(184, 147);
            this.adSoyadText.Margin = new System.Windows.Forms.Padding(4);
            this.adSoyadText.Name = "adSoyadText";
            this.adSoyadText.Size = new System.Drawing.Size(132, 22);
            this.adSoyadText.TabIndex = 82;
            // 
            // tcText
            // 
            this.tcText.Location = new System.Drawing.Point(184, 118);
            this.tcText.Margin = new System.Windows.Forms.Padding(4);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(132, 22);
            this.tcText.TabIndex = 81;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "1274298004_Floppy-64.png";
            this.btnKaydet.Location = new System.Drawing.Point(182, 501);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 24);
            this.btnKaydet.TabIndex = 80;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 395);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 79;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 366);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 78;
            this.label9.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "E Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "İl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Adı Soyadı ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tc Kimlik ";
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "1274298505_cancel.png";
            this.btnCikis.Location = new System.Drawing.Point(326, 501);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 24);
            this.btnCikis.TabIndex = 71;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // okulAdicomboBox
            // 
            this.okulAdicomboBox.FormattingEnabled = true;
            this.okulAdicomboBox.Location = new System.Drawing.Point(182, 264);
            this.okulAdicomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.okulAdicomboBox.Name = "okulAdicomboBox";
            this.okulAdicomboBox.Size = new System.Drawing.Size(133, 24);
            this.okulAdicomboBox.TabIndex = 97;
            this.okulAdicomboBox.SelectedIndexChanged += new System.EventHandler(this.okulAdicomboBox_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 267);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 96;
            this.label11.Text = "Okul";
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(464, 545);
            this.Controls.Add(this.okulAdicomboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciAdiText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ilceComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cinsiyetComboBox);
            this.Controls.Add(this.ilComboBox);
            this.Controls.Add(this.adresText);
            this.Controls.Add(this.epostaText);
            this.Controls.Add(this.telefonText);
            this.Controls.Add(this.adSoyadText);
            this.Controls.Add(this.tcText);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Name = "UyeEkle";
            this.Text = "Üye Ekle";
            this.Load += new System.EventHandler(this.UyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifreText;
        public System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox ilceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cinsiyetComboBox;
        public System.Windows.Forms.ComboBox ilComboBox;
        private System.Windows.Forms.TextBox adresText;
        private System.Windows.Forms.TextBox epostaText;
        private System.Windows.Forms.TextBox telefonText;
        private System.Windows.Forms.TextBox adSoyadText;
        public System.Windows.Forms.TextBox tcText;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.ComboBox okulAdicomboBox;
        private System.Windows.Forms.Label label11;
    }
}