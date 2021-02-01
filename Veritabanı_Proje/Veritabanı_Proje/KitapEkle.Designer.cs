namespace Veritabanı_Proje
{
    partial class KitapEkle
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
            this.kitapTurucomboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stokSayisitextBox = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ciltNotextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.kitapAdiTextBox = new System.Windows.Forms.TextBox();
            this.yayinEviAditextBox = new System.Windows.Forms.TextBox();
            this.yazarAdiSoyaditextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kitapTurucomboBox
            // 
            this.kitapTurucomboBox.FormattingEnabled = true;
            this.kitapTurucomboBox.Location = new System.Drawing.Point(147, 197);
            this.kitapTurucomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.kitapTurucomboBox.Name = "kitapTurucomboBox";
            this.kitapTurucomboBox.Size = new System.Drawing.Size(132, 24);
            this.kitapTurucomboBox.TabIndex = 45;
            this.kitapTurucomboBox.SelectedIndexChanged += new System.EventHandler(this.kitapTurucomboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 231);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Stok Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Basım Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Kitap Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Yayın Evi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Yazar Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Kitap Adı ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "ISBN";
            // 
            // stokSayisitextBox
            // 
            this.stokSayisitextBox.Location = new System.Drawing.Point(147, 261);
            this.stokSayisitextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stokSayisitextBox.Name = "stokSayisitextBox";
            this.stokSayisitextBox.Size = new System.Drawing.Size(132, 22);
            this.stokSayisitextBox.TabIndex = 33;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "1274298004_Floppy-64.png";
            this.btnKaydet.Location = new System.Drawing.Point(55, 348);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 26);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "1274298505_cancel.png";
            this.btnCikis.Location = new System.Drawing.Point(202, 348);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 26);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Cilt No";
            // 
            // ciltNotextBox
            // 
            this.ciltNotextBox.Location = new System.Drawing.Point(147, 294);
            this.ciltNotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ciltNotextBox.Name = "ciltNotextBox";
            this.ciltNotextBox.Size = new System.Drawing.Size(132, 22);
            this.ciltNotextBox.TabIndex = 48;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(145, 71);
            this.ISBNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(132, 22);
            this.ISBNTextBox.TabIndex = 31;
            // 
            // kitapAdiTextBox
            // 
            this.kitapAdiTextBox.Location = new System.Drawing.Point(145, 101);
            this.kitapAdiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kitapAdiTextBox.Name = "kitapAdiTextBox";
            this.kitapAdiTextBox.Size = new System.Drawing.Size(132, 22);
            this.kitapAdiTextBox.TabIndex = 32;
            // 
            // yayinEviAditextBox
            // 
            this.yayinEviAditextBox.Location = new System.Drawing.Point(147, 164);
            this.yayinEviAditextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yayinEviAditextBox.Name = "yayinEviAditextBox";
            this.yayinEviAditextBox.Size = new System.Drawing.Size(132, 22);
            this.yayinEviAditextBox.TabIndex = 51;
            // 
            // yazarAdiSoyaditextBox
            // 
            this.yazarAdiSoyaditextBox.Location = new System.Drawing.Point(147, 134);
            this.yazarAdiSoyaditextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yazarAdiSoyaditextBox.Name = "yazarAdiSoyaditextBox";
            this.yazarAdiSoyaditextBox.Size = new System.Drawing.Size(132, 22);
            this.yazarAdiSoyaditextBox.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 65;
            this.label12.Text = "Kitap Ekle";
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(343, 406);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.yayinEviAditextBox);
            this.Controls.Add(this.yazarAdiSoyaditextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ciltNotextBox);
            this.Controls.Add(this.kitapTurucomboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stokSayisitextBox);
            this.Controls.Add(this.kitapAdiTextBox);
            this.Controls.Add(this.ISBNTextBox);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnCikis);
            this.Name = "KitapEkle";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox kitapTurucomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stokSayisitextBox;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ciltNotextBox;
        public System.Windows.Forms.TextBox ISBNTextBox;
        private System.Windows.Forms.TextBox kitapAdiTextBox;
        private System.Windows.Forms.TextBox yayinEviAditextBox;
        public System.Windows.Forms.TextBox yazarAdiSoyaditextBox;
        private System.Windows.Forms.Label label12;
    }
}