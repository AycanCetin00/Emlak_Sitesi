namespace aycan_v4
{
    partial class addHome
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
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.txtDepozito = new System.Windows.Forms.TextBox();
            this.rbtnSatilik = new System.Windows.Forms.RadioButton();
            this.rbtnKiralik = new System.Windows.Forms.RadioButton();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtYapimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnAddEv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mttxtAlani = new System.Windows.Forms.MaskedTextBox();
            this.nmrKatNumarasi = new System.Windows.Forms.NumericUpDown();
            this.nmrOdaSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.cmbSemt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKatNumarasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOdaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(278, 295);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 29;
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(95, 337);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(100, 22);
            this.txtKira.TabIndex = 28;
            // 
            // txtDepozito
            // 
            this.txtDepozito.Location = new System.Drawing.Point(95, 301);
            this.txtDepozito.Name = "txtDepozito";
            this.txtDepozito.Size = new System.Drawing.Size(100, 22);
            this.txtDepozito.TabIndex = 27;
            // 
            // rbtnSatilik
            // 
            this.rbtnSatilik.AutoSize = true;
            this.rbtnSatilik.Location = new System.Drawing.Point(289, 269);
            this.rbtnSatilik.Name = "rbtnSatilik";
            this.rbtnSatilik.Size = new System.Drawing.Size(64, 20);
            this.rbtnSatilik.TabIndex = 26;
            this.rbtnSatilik.TabStop = true;
            this.rbtnSatilik.Text = "Satılık";
            this.rbtnSatilik.UseVisualStyleBackColor = true;
            this.rbtnSatilik.CheckedChanged += new System.EventHandler(this.rbtnSatilik_CheckedChanged);
            // 
            // rbtnKiralik
            // 
            this.rbtnKiralik.AutoSize = true;
            this.rbtnKiralik.Checked = true;
            this.rbtnKiralik.Location = new System.Drawing.Point(131, 269);
            this.rbtnKiralik.Name = "rbtnKiralik";
            this.rbtnKiralik.Size = new System.Drawing.Size(64, 20);
            this.rbtnKiralik.TabIndex = 25;
            this.rbtnKiralik.TabStop = true;
            this.rbtnKiralik.Text = "Kiralık";
            this.rbtnKiralik.UseVisualStyleBackColor = true;
            this.rbtnKiralik.CheckedChanged += new System.EventHandler(this.rbtnKiralik_CheckedChanged);
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(131, 218);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(88, 20);
            this.chkAktif.TabIndex = 24;
            this.chkAktif.Text = "Aktif/Pasif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(131, 179);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 24);
            this.cmbTur.TabIndex = 23;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // txtYapimTarihi
            // 
            this.txtYapimTarihi.Location = new System.Drawing.Point(131, 151);
            this.txtYapimTarihi.Name = "txtYapimTarihi";
            this.txtYapimTarihi.Size = new System.Drawing.Size(200, 22);
            this.txtYapimTarihi.TabIndex = 22;
            // 
            // btnAddEv
            // 
            this.btnAddEv.Location = new System.Drawing.Point(311, 506);
            this.btnAddEv.Name = "btnAddEv";
            this.btnAddEv.Size = new System.Drawing.Size(178, 57);
            this.btnAddEv.TabIndex = 17;
            this.btnAddEv.Text = "KAYDET";
            this.btnAddEv.UseVisualStyleBackColor = true;
            this.btnAddEv.Click += new System.EventHandler(this.btnAddEv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbSemt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mttxtAlani);
            this.groupBox1.Controls.Add(this.nmrKatNumarasi);
            this.groupBox1.Controls.Add(this.nmrOdaSayisi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtKira);
            this.groupBox1.Controls.Add(this.txtDepozito);
            this.groupBox1.Controls.Add(this.rbtnSatilik);
            this.groupBox1.Controls.Add(this.txtYapimTarihi);
            this.groupBox1.Controls.Add(this.rbtnKiralik);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.chkAktif);
            this.groupBox1.Location = new System.Drawing.Point(44, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 430);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 35;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mttxtAlani
            // 
            this.mttxtAlani.Location = new System.Drawing.Point(137, 114);
            this.mttxtAlani.Mask = "00000";
            this.mttxtAlani.Name = "mttxtAlani";
            this.mttxtAlani.Size = new System.Drawing.Size(100, 22);
            this.mttxtAlani.TabIndex = 34;
            this.mttxtAlani.Text = "00";
            this.mttxtAlani.ValidatingType = typeof(int);
            // 
            // nmrKatNumarasi
            // 
            this.nmrKatNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrKatNumarasi.Location = new System.Drawing.Point(137, 69);
            this.nmrKatNumarasi.Name = "nmrKatNumarasi";
            this.nmrKatNumarasi.Size = new System.Drawing.Size(91, 30);
            this.nmrKatNumarasi.TabIndex = 33;
            // 
            // nmrOdaSayisi
            // 
            this.nmrOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmrOdaSayisi.Location = new System.Drawing.Point(137, 33);
            this.nmrOdaSayisi.Name = "nmrOdaSayisi";
            this.nmrOdaSayisi.Size = new System.Drawing.Size(91, 30);
            this.nmrOdaSayisi.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Oda Sayısı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(441, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 403);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(125, 507);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(138, 57);
            this.btnGeri.TabIndex = 31;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // cmbSemt
            // 
            this.cmbSemt.FormattingEnabled = true;
            this.cmbSemt.Location = new System.Drawing.Point(120, 239);
            this.cmbSemt.Name = "cmbSemt";
            this.cmbSemt.Size = new System.Drawing.Size(258, 24);
            this.cmbSemt.TabIndex = 32;
            this.cmbSemt.Text = "İlçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Kat no:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "metrekare:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Yapım tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ev Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Kiralık/Satılık";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fiyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Kira:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Depozito:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Semt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Kira fiyatı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 376);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(98, 376);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "00";
            // 
            // addHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1144, 604);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddEv);
            this.Name = "addHome";
            this.Text = "addHome";
            this.Load += new System.EventHandler(this.addHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKatNumarasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOdaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.TextBox txtDepozito;
        private System.Windows.Forms.RadioButton rbtnSatilik;
        private System.Windows.Forms.RadioButton rbtnKiralik;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.DateTimePicker txtYapimTarihi;
        private System.Windows.Forms.Button btnAddEv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.NumericUpDown nmrOdaSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbSemt;
        private System.Windows.Forms.NumericUpDown nmrKatNumarasi;
        private System.Windows.Forms.MaskedTextBox mttxtAlani;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}