namespace CafeOtomasyon
{
    partial class frmYoneticiPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelYonetici = new System.Windows.Forms.Panel();
            this.btnSifreIslemi = new System.Windows.Forms.Button();
            this.btnGunlukCiro = new System.Windows.Forms.Button();
            this.btnYeniUrunKayit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 38);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yönetici Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btnSifreIslemi);
            this.panel2.Controls.Add(this.btnGunlukCiro);
            this.panel2.Controls.Add(this.btnYeniUrunKayit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 496);
            this.panel2.TabIndex = 6;
            // 
            // panelYonetici
            // 
            this.panelYonetici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelYonetici.Location = new System.Drawing.Point(167, 38);
            this.panelYonetici.Name = "panelYonetici";
            this.panelYonetici.Size = new System.Drawing.Size(721, 496);
            this.panelYonetici.TabIndex = 7;
            // 
            // btnSifreIslemi
            // 
            this.btnSifreIslemi.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreIslemi.BackgroundImage = global::CafeOtomasyon.Properties.Resources.sonButonpng;
            this.btnSifreIslemi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreIslemi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreIslemi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSifreIslemi.Location = new System.Drawing.Point(0, 278);
            this.btnSifreIslemi.Name = "btnSifreIslemi";
            this.btnSifreIslemi.Size = new System.Drawing.Size(161, 56);
            this.btnSifreIslemi.TabIndex = 2;
            this.btnSifreIslemi.Text = "Şifre İşlemi";
            this.btnSifreIslemi.UseVisualStyleBackColor = false;
            this.btnSifreIslemi.Click += new System.EventHandler(this.btnSifreIslemi_Click);
            // 
            // btnGunlukCiro
            // 
            this.btnGunlukCiro.BackColor = System.Drawing.Color.Transparent;
            this.btnGunlukCiro.BackgroundImage = global::CafeOtomasyon.Properties.Resources.sonButonpng;
            this.btnGunlukCiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGunlukCiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunlukCiro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunlukCiro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGunlukCiro.Location = new System.Drawing.Point(0, 187);
            this.btnGunlukCiro.Name = "btnGunlukCiro";
            this.btnGunlukCiro.Size = new System.Drawing.Size(161, 56);
            this.btnGunlukCiro.TabIndex = 1;
            this.btnGunlukCiro.Text = "Günlük Ciro";
            this.btnGunlukCiro.UseVisualStyleBackColor = false;
            this.btnGunlukCiro.Click += new System.EventHandler(this.btnGunlukCiro_Click);
            // 
            // btnYeniUrunKayit
            // 
            this.btnYeniUrunKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniUrunKayit.BackgroundImage = global::CafeOtomasyon.Properties.Resources.sonButonpng;
            this.btnYeniUrunKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniUrunKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniUrunKayit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUrunKayit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnYeniUrunKayit.Location = new System.Drawing.Point(0, 105);
            this.btnYeniUrunKayit.Name = "btnYeniUrunKayit";
            this.btnYeniUrunKayit.Size = new System.Drawing.Size(161, 56);
            this.btnYeniUrunKayit.TabIndex = 0;
            this.btnYeniUrunKayit.Text = "Yeni Urun Kayit";
            this.btnYeniUrunKayit.UseVisualStyleBackColor = false;
            this.btnYeniUrunKayit.Click += new System.EventHandler(this.btnYeniUrunKayit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CafeOtomasyon.Properties.Resources.icons8_admin_settings_male_96;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeOtomasyon.Properties.Resources.icons8_cancel_96__1_;
            this.pictureBox1.Location = new System.Drawing.Point(852, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmYoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 534);
            this.Controls.Add(this.panelYonetici);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYoneticiPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYoneticiPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSifreIslemi;
        private System.Windows.Forms.Button btnGunlukCiro;
        private System.Windows.Forms.Button btnYeniUrunKayit;
        private System.Windows.Forms.Panel panelYonetici;
    }
}