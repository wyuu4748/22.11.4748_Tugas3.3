namespace AplikasiLatihanTiga3
{
    partial class frmLatihanTiga3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lsPekerjaan = new System.Windows.Forms.ListBox();
            this.cmbPendidikan = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pendidikan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pekerjaan";
            // 
            // txtPesan1
            // 
            this.txtPesan1.Enabled = false;
            this.txtPesan1.Location = new System.Drawing.Point(3, 55);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(427, 20);
            this.txtPesan1.TabIndex = 6;
            // 
            // txtPesan2
            // 
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(3, 29);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(427, 20);
            this.txtPesan2.TabIndex = 7;
            // 
            // txtPesan3
            // 
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(3, 3);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(427, 20);
            this.txtPesan3.TabIndex = 8;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(427, 22);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(72, 174);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.txtPesan3);
            this.flowLayoutPanel3.Controls.Add(this.txtPesan2);
            this.flowLayoutPanel3.Controls.Add(this.txtPesan1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 187);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(437, 75);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.btnOk);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(8, 268);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(437, 33);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // lsPekerjaan
            // 
            this.lsPekerjaan.FormattingEnabled = true;
            this.lsPekerjaan.Items.AddRange(new object[] {
            "Pedagang",
            "PNS",
            "Dosen",
            "Swasta",
            "ABRI"});
            this.lsPekerjaan.Location = new System.Drawing.Point(3, 56);
            this.lsPekerjaan.Name = "lsPekerjaan";
            this.lsPekerjaan.Size = new System.Drawing.Size(352, 95);
            this.lsPekerjaan.TabIndex = 5;
            // 
            // cmbPendidikan
            // 
            this.cmbPendidikan.FormattingEnabled = true;
            this.cmbPendidikan.Items.AddRange(new object[] {
            "SD",
            "SMP",
            "SMA",
            "Diploma",
            "Sarjana",
            "Pascasarjana"});
            this.cmbPendidikan.Location = new System.Drawing.Point(3, 29);
            this.cmbPendidikan.Name = "cmbPendidikan";
            this.cmbPendidikan.Size = new System.Drawing.Size(352, 21);
            this.cmbPendidikan.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(3, 3);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(352, 20);
            this.txtNama.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.txtNama);
            this.flowLayoutPanel2.Controls.Add(this.cmbPendidikan);
            this.flowLayoutPanel2.Controls.Add(this.lsPekerjaan);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(86, 9);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(359, 172);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(72, 19);
            this.flowLayoutPanel5.TabIndex = 14;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label2);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(69, 19);
            this.flowLayoutPanel6.TabIndex = 15;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label3);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(73, 15);
            this.flowLayoutPanel7.TabIndex = 16;
            // 
            // frmLatihanTiga3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 309);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmLatihanTiga3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Latihan 3.3 (Desain Menggunakan Komponen Layout)";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ListBox lsPekerjaan;
        private System.Windows.Forms.ComboBox cmbPendidikan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
    }
}

