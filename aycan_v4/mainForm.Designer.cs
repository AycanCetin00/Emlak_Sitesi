namespace aycan_v4
{
    partial class mainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addHome = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(969, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "kiralık evleri listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLoadKiralik_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 86);
            this.button2.TabIndex = 2;
            this.button2.Text = "satılık evleri listele";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnLoadSatilik_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(72, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 62);
            this.button4.TabIndex = 17;
            this.button4.Text = "sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addHome
            // 
            this.addHome.BackColor = System.Drawing.Color.LightCoral;
            this.addHome.Location = new System.Drawing.Point(536, 31);
            this.addHome.Name = "addHome";
            this.addHome.Size = new System.Drawing.Size(192, 86);
            this.addHome.TabIndex = 18;
            this.addHome.Text = "Yeni ev ekle";
            this.addHome.UseVisualStyleBackColor = false;
            this.addHome.Click += new System.EventHandler(this.addHome_Click);
            // 
            // duzenle
            // 
            this.duzenle.Location = new System.Drawing.Point(345, 412);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(194, 62);
            this.duzenle.TabIndex = 19;
            this.duzenle.Text = "Düzenle";
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 546);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.addHome);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button addHome;
        private System.Windows.Forms.Button duzenle;
    }
}

