namespace vtys_projem
{
    partial class Form2
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
            this.tabc = new System.Windows.Forms.TabControl();
            this.tabp_dersonay = new System.Windows.Forms.TabPage();
            this.pnl_dersonay = new System.Windows.Forms.Panel();
            this.dgv_dersonay = new System.Windows.Forms.DataGridView();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.tabp_derssecme = new System.Windows.Forms.TabPage();
            this.pnl_derssecme = new System.Windows.Forms.Panel();
            this.dgv_derssecme = new System.Windows.Forms.DataGridView();
            this.lb_dersler = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl_danısman = new System.Windows.Forms.Panel();
            this.cb_danısman = new System.Windows.Forms.ComboBox();
            this.btn_danısman = new System.Windows.Forms.Button();
            this.btn_cık = new System.Windows.Forms.Button();
            this.tabc.SuspendLayout();
            this.tabp_dersonay.SuspendLayout();
            this.pnl_dersonay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dersonay)).BeginInit();
            this.tabp_derssecme.SuspendLayout();
            this.pnl_derssecme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_derssecme)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.pnl_danısman.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabc
            // 
            this.tabc.Controls.Add(this.tabp_dersonay);
            this.tabc.Controls.Add(this.tabp_derssecme);
            this.tabc.Controls.Add(this.tabPage1);
            this.tabc.Location = new System.Drawing.Point(12, 12);
            this.tabc.Name = "tabc";
            this.tabc.SelectedIndex = 0;
            this.tabc.Size = new System.Drawing.Size(710, 430);
            this.tabc.TabIndex = 0;
            // 
            // tabp_dersonay
            // 
            this.tabp_dersonay.Controls.Add(this.pnl_dersonay);
            this.tabp_dersonay.Location = new System.Drawing.Point(4, 22);
            this.tabp_dersonay.Name = "tabp_dersonay";
            this.tabp_dersonay.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_dersonay.Size = new System.Drawing.Size(702, 404);
            this.tabp_dersonay.TabIndex = 0;
            this.tabp_dersonay.Text = "Ders Onay";
            this.tabp_dersonay.UseVisualStyleBackColor = true;
            // 
            // pnl_dersonay
            // 
            this.pnl_dersonay.Controls.Add(this.dgv_dersonay);
            this.pnl_dersonay.Controls.Add(this.btn_onayla);
            this.pnl_dersonay.Location = new System.Drawing.Point(2, 3);
            this.pnl_dersonay.Name = "pnl_dersonay";
            this.pnl_dersonay.Size = new System.Drawing.Size(699, 400);
            this.pnl_dersonay.TabIndex = 2;
            // 
            // dgv_dersonay
            // 
            this.dgv_dersonay.AllowUserToDeleteRows = false;
            this.dgv_dersonay.AllowUserToResizeColumns = false;
            this.dgv_dersonay.AllowUserToResizeRows = false;
            this.dgv_dersonay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dersonay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dersonay.Location = new System.Drawing.Point(4, 3);
            this.dgv_dersonay.Name = "dgv_dersonay";
            this.dgv_dersonay.Size = new System.Drawing.Size(690, 349);
            this.dgv_dersonay.TabIndex = 2;
            // 
            // btn_onayla
            // 
            this.btn_onayla.Location = new System.Drawing.Point(4, 358);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(690, 40);
            this.btn_onayla.TabIndex = 1;
            this.btn_onayla.Text = "Tumunu Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // tabp_derssecme
            // 
            this.tabp_derssecme.Controls.Add(this.pnl_derssecme);
            this.tabp_derssecme.Location = new System.Drawing.Point(4, 22);
            this.tabp_derssecme.Name = "tabp_derssecme";
            this.tabp_derssecme.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_derssecme.Size = new System.Drawing.Size(702, 404);
            this.tabp_derssecme.TabIndex = 1;
            this.tabp_derssecme.Text = "Ders Secme";
            this.tabp_derssecme.UseVisualStyleBackColor = true;
            // 
            // pnl_derssecme
            // 
            this.pnl_derssecme.Controls.Add(this.dgv_derssecme);
            this.pnl_derssecme.Controls.Add(this.lb_dersler);
            this.pnl_derssecme.Location = new System.Drawing.Point(1, 2);
            this.pnl_derssecme.Name = "pnl_derssecme";
            this.pnl_derssecme.Size = new System.Drawing.Size(700, 401);
            this.pnl_derssecme.TabIndex = 0;
            // 
            // dgv_derssecme
            // 
            this.dgv_derssecme.AllowUserToAddRows = false;
            this.dgv_derssecme.AllowUserToDeleteRows = false;
            this.dgv_derssecme.AllowUserToResizeColumns = false;
            this.dgv_derssecme.AllowUserToResizeRows = false;
            this.dgv_derssecme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_derssecme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_derssecme.Location = new System.Drawing.Point(211, 4);
            this.dgv_derssecme.Name = "dgv_derssecme";
            this.dgv_derssecme.ReadOnly = true;
            this.dgv_derssecme.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_derssecme.ShowCellToolTips = false;
            this.dgv_derssecme.ShowEditingIcon = false;
            this.dgv_derssecme.Size = new System.Drawing.Size(484, 392);
            this.dgv_derssecme.TabIndex = 6;
            // 
            // lb_dersler
            // 
            this.lb_dersler.FormattingEnabled = true;
            this.lb_dersler.Location = new System.Drawing.Point(5, 4);
            this.lb_dersler.Name = "lb_dersler";
            this.lb_dersler.Size = new System.Drawing.Size(200, 394);
            this.lb_dersler.TabIndex = 5;
            this.lb_dersler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_dersler_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnl_danısman);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(702, 404);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Danısman Secme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl_danısman
            // 
            this.pnl_danısman.Controls.Add(this.cb_danısman);
            this.pnl_danısman.Controls.Add(this.btn_danısman);
            this.pnl_danısman.Location = new System.Drawing.Point(4, 4);
            this.pnl_danısman.Name = "pnl_danısman";
            this.pnl_danısman.Size = new System.Drawing.Size(697, 399);
            this.pnl_danısman.TabIndex = 2;
            // 
            // cb_danısman
            // 
            this.cb_danısman.FormattingEnabled = true;
            this.cb_danısman.Location = new System.Drawing.Point(28, 27);
            this.cb_danısman.Name = "cb_danısman";
            this.cb_danısman.Size = new System.Drawing.Size(121, 21);
            this.cb_danısman.TabIndex = 1;
            // 
            // btn_danısman
            // 
            this.btn_danısman.Location = new System.Drawing.Point(28, 66);
            this.btn_danısman.Name = "btn_danısman";
            this.btn_danısman.Size = new System.Drawing.Size(121, 23);
            this.btn_danısman.TabIndex = 0;
            this.btn_danısman.Text = "danısman";
            this.btn_danısman.UseVisualStyleBackColor = true;
            this.btn_danısman.Click += new System.EventHandler(this.btn_danısman_Click);
            // 
            // btn_cık
            // 
            this.btn_cık.Location = new System.Drawing.Point(703, 0);
            this.btn_cık.Name = "btn_cık";
            this.btn_cık.Size = new System.Drawing.Size(30, 28);
            this.btn_cık.TabIndex = 8;
            this.btn_cık.Text = "X";
            this.btn_cık.UseVisualStyleBackColor = true;
            this.btn_cık.Click += new System.EventHandler(this.btn_cık_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cık);
            this.Controls.Add(this.tabc);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabc.ResumeLayout(false);
            this.tabp_dersonay.ResumeLayout(false);
            this.pnl_dersonay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dersonay)).EndInit();
            this.tabp_derssecme.ResumeLayout(false);
            this.pnl_derssecme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_derssecme)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.pnl_danısman.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabc;
        private System.Windows.Forms.TabPage tabp_dersonay;
        private System.Windows.Forms.TabPage tabp_derssecme;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Panel pnl_dersonay;
        private System.Windows.Forms.Panel pnl_derssecme;
        private System.Windows.Forms.Button btn_cık;
        private System.Windows.Forms.ListBox lb_dersler;
        private System.Windows.Forms.DataGridView dgv_derssecme;
        private System.Windows.Forms.DataGridView dgv_dersonay;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_danısman;
        private System.Windows.Forms.ComboBox cb_danısman;
        private System.Windows.Forms.Panel pnl_danısman;
    }
}