namespace CafeOtomasyon
{
    partial class frmSiparisGoster
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
            this.dgvSiparisGoster = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisGoster
            // 
            this.dgvSiparisGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisGoster.Location = new System.Drawing.Point(179, 67);
            this.dgvSiparisGoster.Name = "dgvSiparisGoster";
            this.dgvSiparisGoster.Size = new System.Drawing.Size(446, 291);
            this.dgvSiparisGoster.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.BackgroundImage = global::CafeOtomasyon.Properties.Resources.sonButonpng;
            this.btnListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(68, 103);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(105, 42);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmSiparisGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 465);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgvSiparisGoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSiparisGoster";
            this.Text = "frmSiparisGoster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisGoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSiparisGoster;
        private System.Windows.Forms.Button btnListele;
    }
}