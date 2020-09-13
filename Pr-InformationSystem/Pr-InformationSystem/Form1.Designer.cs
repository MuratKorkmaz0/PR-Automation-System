using System;

namespace Pr_InformationSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1Adı = new System.Windows.Forms.ListBox();
            this.listBox2Marka = new System.Windows.Forms.ListBox();
            this.listBox3Fiyat = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Ad = new System.Windows.Forms.TextBox();
            this.textBox2Marka = new System.Windows.Forms.TextBox();
            this.textBox3Fiyat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1Adı
            // 
            this.listBox1Adı.FormattingEnabled = true;
            this.listBox1Adı.ItemHeight = 14;
            this.listBox1Adı.Location = new System.Drawing.Point(244, 224);
            this.listBox1Adı.Name = "listBox1Adı";
            this.listBox1Adı.Size = new System.Drawing.Size(295, 298);
            this.listBox1Adı.TabIndex = 3;
            this.listBox1Adı.SelectedIndexChanged += new System.EventHandler(this.listBox1Adı_SelectedIndexChanged);
            // 
            // listBox2Marka
            // 
            this.listBox2Marka.FormattingEnabled = true;
            this.listBox2Marka.ItemHeight = 14;
            this.listBox2Marka.Location = new System.Drawing.Point(582, 224);
            this.listBox2Marka.Name = "listBox2Marka";
            this.listBox2Marka.Size = new System.Drawing.Size(186, 298);
            this.listBox2Marka.TabIndex = 4;
            // 
            // listBox3Fiyat
            // 
            this.listBox3Fiyat.FormattingEnabled = true;
            this.listBox3Fiyat.ItemHeight = 14;
            this.listBox3Fiyat.Location = new System.Drawing.Point(811, 224);
            this.listBox3Fiyat.Name = "listBox3Fiyat";
            this.listBox3Fiyat.Size = new System.Drawing.Size(138, 298);
            this.listBox3Fiyat.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(244, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tüm Ürünler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marka Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(806, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fiyat Giriniz";
            // 
            // textBox1Ad
            // 
            this.textBox1Ad.Location = new System.Drawing.Point(244, 193);
            this.textBox1Ad.Name = "textBox1Ad";
            this.textBox1Ad.Size = new System.Drawing.Size(271, 19);
            this.textBox1Ad.TabIndex = 16;
            this.textBox1Ad.TextChanged += new System.EventHandler(this.textBox1Ad_TextChanged);
            // 
            // textBox2Marka
            // 
            this.textBox2Marka.Location = new System.Drawing.Point(582, 193);
            this.textBox2Marka.Name = "textBox2Marka";
            this.textBox2Marka.Size = new System.Drawing.Size(165, 19);
            this.textBox2Marka.TabIndex = 17;
            // 
            // textBox3Fiyat
            // 
            this.textBox3Fiyat.Location = new System.Drawing.Point(811, 193);
            this.textBox3Fiyat.Name = "textBox3Fiyat";
            this.textBox3Fiyat.Size = new System.Drawing.Size(123, 19);
            this.textBox3Fiyat.TabIndex = 18;
            this.textBox3Fiyat.Text = "0.0₺";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 664);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsil);
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Controls.Add(this.btnguncelle);
            this.panel2.Location = new System.Drawing.Point(0, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 524);
            this.panel2.TabIndex = 21;
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImage = global::Pr_InformationSystem.Properties.Resources.icons8_trash_150;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(-1, 178);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(157, 159);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Image = global::Pr_InformationSystem.Properties.Resources.icons8_save_128;
            this.btnKaydet.Location = new System.Drawing.Point(-2, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(158, 147);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackgroundImage = global::Pr_InformationSystem.Properties.Resources.icons8_refresh_128;
            this.btnguncelle.FlatAppearance.BorderSize = 0;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.Location = new System.Drawing.Point(8, 355);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(129, 141);
            this.btnguncelle.TabIndex = 11;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pr_InformationSystem.Properties.Resources.pr_ico;
            this.pictureBox1.Location = new System.Drawing.Point(44, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 86);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(198, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 664);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(201, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(928, 664);
            this.panel4.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Pr_InformationSystem.Properties.Resources.icons8_power_off_button_20;
            this.button2.Location = new System.Drawing.Point(1094, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 28);
            this.button2.TabIndex = 12;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1128, 664);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3Fiyat);
            this.Controls.Add(this.textBox2Marka);
            this.Controls.Add(this.textBox1Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox3Fiyat);
            this.Controls.Add(this.listBox2Marka);
            this.Controls.Add(this.listBox1Adı);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "16630110004_Murat_Korkmaz_GorselProgramlama1Odevi2020";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listBox1Adı_SelectedIndexChanged(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion
        private System.Windows.Forms.ListBox listBox1Adı;
        private System.Windows.Forms.ListBox listBox2Marka;
        private System.Windows.Forms.ListBox listBox3Fiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Ad;
        private System.Windows.Forms.TextBox textBox2Marka;
        private System.Windows.Forms.TextBox textBox3Fiyat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

