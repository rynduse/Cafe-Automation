namespace CafeOtomasyon
{
    partial class frmPersonel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSifreIslemi = new System.Windows.Forms.Button();
            this.btnGunlukCiro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnMasalar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 38);
            this.panel1.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(161, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(639, 409);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CafeOtomasyon.Properties.Resources.icons8_cancel_96__1_;
            this.pictureBox2.Location = new System.Drawing.Point(761, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "X Cafe";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btnSifreIslemi);
            this.panel2.Controls.Add(this.btnGunlukCiro);
            this.panel2.Controls.Add(this.btnMasalar);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 412);
            this.panel2.TabIndex = 9;
            // 
            // btnSifreIslemi
            // 
            this.btnSifreIslemi.BackColor = System.Drawing.Color.Transparent;
            this.btnSifreIslemi.BackgroundImage = global::CafeOtomasyon.Properties.Resources.sonButonpng;
            this.btnSifreIslemi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSifreIslemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreIslemi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreIslemi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSifreIslemi.Location = new System.Drawing.Point(12, 146);
            this.btnSifreIslemi.Name = "btnSifreIslemi";
            this.btnSifreIslemi.Size = new System.Drawing.Size(130, 56);
            this.btnSifreIslemi.TabIndex = 2;
            this.btnSifreIslemi.Text = "Sipariş Göster";
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
            this.btnGunlukCiro.Location = new System.Drawing.Point(12, 257);
            this.btnGunlukCiro.Name = "btnGunlukCiro";
            this.btnGunlukCiro.Size = new System.Drawing.Size(130, 56);
            this.btnGunlukCiro.TabIndex = 1;
            this.btnGunlukCiro.Text = "Giriş Sayfası";
            this.btnGunlukCiro.UseVisualStyleBackColor = false;
            this.btnGunlukCiro.Click += new System.EventHandler(this.btnGunlukCiro_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dgvMenu);
            this.panel3.Location = new System.Drawing.Point(161, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 412);
            this.panel3.TabIndex = 10;
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(21, 19);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(606, 381);
            this.dgvMenu.TabIndex = 0;
            // 
            // btnMasalar
            // 
            this.btnMasalar.BackColor = System.Drawing.Color.Transparent;
            this.btnMasalar.BackgroundImage = global::CafeOtomasyon.Properties.Resources.sonButonpng;
            this.btnMasalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasalar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasalar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMasalar.Location = new System.Drawing.Point(12, 53);
            this.btnMasalar.Name = "btnMasalar";
            this.btnMasalar.Size = new System.Drawing.Size(130, 56);
            this.btnMasalar.TabIndex = 0;
            this.btnMasalar.Text = "Masalar";
            this.btnMasalar.UseVisualStyleBackColor = false;
            this.btnMasalar.Click += new System.EventHandler(this.btnMasalar_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPersonel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSifreIslemi;
        private System.Windows.Forms.Button btnGunlukCiro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnMasalar;
    }
}