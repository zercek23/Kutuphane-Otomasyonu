namespace Veritabanı_Proje
{
    partial class PersonelEkle
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
            this.label12 = new System.Windows.Forms.Label();
            this.ilceComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.kullaniciAdiText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 160);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 62;
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(178, 308);
            this.cinsiyetComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(133, 24);
            this.cinsiyetComboBox.TabIndex = 61;
            this.cinsiyetComboBox.Text = "Erkek";
            // 
            // ilComboBox
            // 
            this.ilComboBox.FormattingEnabled = true;
            this.ilComboBox.Location = new System.Drawing.Point(178, 188);
            this.ilComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ilComboBox.Name = "ilComboBox";
            this.ilComboBox.Size = new System.Drawing.Size(133, 24);
            this.ilComboBox.TabIndex = 60;
            this.ilComboBox.SelectedIndexChanged += new System.EventHandler(this.ilComboBox_SelectedIndexChanged);
            // 
            // adresText
            // 
            this.adresText.Location = new System.Drawing.Point(178, 338);
            this.adresText.Margin = new System.Windows.Forms.Padding(4);
            this.adresText.Multiline = true;
            this.adresText.Name = "adresText";
            this.adresText.Size = new System.Drawing.Size(220, 82);
            this.adresText.TabIndex = 58;
            // 
            // epostaText
            // 
            this.epostaText.Location = new System.Drawing.Point(178, 277);
            this.epostaText.Margin = new System.Windows.Forms.Padding(4);
            this.epostaText.Name = "epostaText";
            this.epostaText.Size = new System.Drawing.Size(132, 22);
            this.epostaText.TabIndex = 57;
            // 
            // telefonText
            // 
            this.telefonText.Location = new System.Drawing.Point(178, 248);
            this.telefonText.Margin = new System.Windows.Forms.Padding(4);
            this.telefonText.Name = "telefonText";
            this.telefonText.Size = new System.Drawing.Size(132, 22);
            this.telefonText.TabIndex = 56;
            // 
            // adSoyadText
            // 
            this.adSoyadText.Location = new System.Drawing.Point(178, 131);
            this.adSoyadText.Margin = new System.Windows.Forms.Padding(4);
            this.adSoyadText.Name = "adSoyadText";
            this.adSoyadText.Size = new System.Drawing.Size(132, 22);
            this.adSoyadText.TabIndex = 54;
            // 
            // tcText
            // 
            this.tcText.Location = new System.Drawing.Point(178, 102);
            this.tcText.Margin = new System.Windows.Forms.Padding(4);
            this.tcText.Name = "tcText";
            this.tcText.Size = new System.Drawing.Size(132, 22);
            this.tcText.TabIndex = 53;
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "1274298004_Floppy-64.png";
            this.btnKaydet.Location = new System.Drawing.Point(178, 457);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(116, 24);
            this.btnKaydet.TabIndex = 52;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 345);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 282);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "E Posta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "İl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Adı Soyadı ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tc Kimlik ";
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "1274298505_cancel.png";
            this.btnCikis.Location = new System.Drawing.Point(322, 457);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(116, 24);
            this.btnCikis.TabIndex = 40;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 25);
            this.label12.TabIndex = 64;
            this.label12.Text = "Personel Ekle";
            // 
            // ilceComboBox
            // 
            this.ilceComboBox.FormattingEnabled = true;
            this.ilceComboBox.Location = new System.Drawing.Point(178, 217);
            this.ilceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ilceComboBox.Name = "ilceComboBox";
            this.ilceComboBox.Size = new System.Drawing.Size(133, 24);
            this.ilceComboBox.TabIndex = 66;
            this.ilceComboBox.SelectedIndexChanged += new System.EventHandler(this.ilceComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "İlçe";
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(178, 74);
            this.sifreText.Margin = new System.Windows.Forms.Padding(4);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.Size = new System.Drawing.Size(132, 22);
            this.sifreText.TabIndex = 70;
            // 
            // kullaniciAdiText
            // 
            this.kullaniciAdiText.Location = new System.Drawing.Point(178, 45);
            this.kullaniciAdiText.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciAdiText.Name = "kullaniciAdiText";
            this.kullaniciAdiText.Size = new System.Drawing.Size(132, 22);
            this.kullaniciAdiText.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Şifre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 45);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Kullanıcı Adı";
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(462, 529);
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
            this.Name = "PersonelEkle";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox ilceComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreText;
        public System.Windows.Forms.TextBox kullaniciAdiText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
    }
}