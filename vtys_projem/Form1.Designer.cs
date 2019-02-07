namespace vtys_projem
{
    partial class form_giris
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
            this.btn_giris = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_tcno = new System.Windows.Forms.TextBox();
            this.rb_ogrenci = new System.Windows.Forms.RadioButton();
            this.rb_hoca = new System.Windows.Forms.RadioButton();
            this.rb_personel = new System.Windows.Forms.RadioButton();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(-2, 232);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(364, 90);
            this.btn_giris.TabIndex = 0;
            this.btn_giris.Text = "Giris";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sifre.Location = new System.Drawing.Point(-2, 135);
            this.tb_sifre.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tb_sifre.Multiline = true;
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(364, 45);
            this.tb_sifre.TabIndex = 1;
            this.tb_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_tcno
            // 
            this.tb_tcno.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_tcno.Location = new System.Drawing.Point(-2, 45);
            this.tb_tcno.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.tb_tcno.Multiline = true;
            this.tb_tcno.Name = "tb_tcno";
            this.tb_tcno.Size = new System.Drawing.Size(364, 45);
            this.tb_tcno.TabIndex = 1;
            this.tb_tcno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rb_ogrenci
            // 
            this.rb_ogrenci.AutoSize = true;
            this.rb_ogrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_ogrenci.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_ogrenci.Location = new System.Drawing.Point(12, 12);
            this.rb_ogrenci.Name = "rb_ogrenci";
            this.rb_ogrenci.Size = new System.Drawing.Size(78, 22);
            this.rb_ogrenci.TabIndex = 2;
            this.rb_ogrenci.TabStop = true;
            this.rb_ogrenci.Text = "Ogrenci";
            this.rb_ogrenci.UseVisualStyleBackColor = true;
            // 
            // rb_hoca
            // 
            this.rb_hoca.AutoSize = true;
            this.rb_hoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_hoca.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_hoca.Location = new System.Drawing.Point(285, 12);
            this.rb_hoca.Name = "rb_hoca";
            this.rb_hoca.Size = new System.Drawing.Size(62, 22);
            this.rb_hoca.TabIndex = 4;
            this.rb_hoca.TabStop = true;
            this.rb_hoca.Text = "Hoca";
            this.rb_hoca.UseVisualStyleBackColor = true;
            // 
            // rb_personel
            // 
            this.rb_personel.AutoSize = true;
            this.rb_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_personel.ForeColor = System.Drawing.SystemColors.Control;
            this.rb_personel.Location = new System.Drawing.Point(137, 12);
            this.rb_personel.Name = "rb_personel";
            this.rb_personel.Size = new System.Drawing.Size(85, 22);
            this.rb_personel.TabIndex = 5;
            this.rb_personel.TabStop = true;
            this.rb_personel.Text = "Personel";
            this.rb_personel.UseVisualStyleBackColor = true;
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(310, 295);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(45, 22);
            this.btn_cıkıs.TabIndex = 6;
            this.btn_cıkıs.Text = "X";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // form_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 321);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.rb_personel);
            this.Controls.Add(this.rb_hoca);
            this.Controls.Add(this.rb_ogrenci);
            this.Controls.Add(this.tb_tcno);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.btn_giris);
            this.Name = "form_giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_tcno;
        private System.Windows.Forms.RadioButton rb_ogrenci;
        private System.Windows.Forms.RadioButton rb_hoca;
        private System.Windows.Forms.RadioButton rb_personel;
        private System.Windows.Forms.Button btn_cıkıs;

    }
}

