namespace Gunluk1._0WF
{
    partial class Form1
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
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.rtxtIcerik = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lstAranan = new System.Windows.Forms.ListBox();
            this.btnAramaIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılarım";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaslik.Location = new System.Drawing.Point(548, 78);
            this.txtBaslik.Margin = new System.Windows.Forms.Padding(6);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(893, 29);
            this.txtBaslik.TabIndex = 1;
            this.txtBaslik.TextChanged += new System.EventHandler(this.txtBaslik_TextChanged);
            // 
            // rtxtIcerik
            // 
            this.rtxtIcerik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtIcerik.Location = new System.Drawing.Point(548, 129);
            this.rtxtIcerik.Margin = new System.Windows.Forms.Padding(6);
            this.rtxtIcerik.Name = "rtxtIcerik";
            this.rtxtIcerik.Size = new System.Drawing.Size(893, 559);
            this.rtxtIcerik.TabIndex = 2;
            this.rtxtIcerik.Text = "";
            this.rtxtIcerik.TextChanged += new System.EventHandler(this.rtxtIcerik_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKaydet.Location = new System.Drawing.Point(548, 702);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(6);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(424, 91);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSil.Location = new System.Drawing.Point(1021, 702);
            this.btnSil.Margin = new System.Windows.Forms.Padding(6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(424, 91);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(187, 65);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(50, 42);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstNotlar
            // 
            this.lstNotlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 24;
            this.lstNotlar.Location = new System.Drawing.Point(63, 129);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(363, 556);
            this.lstNotlar.TabIndex = 6;
            this.lstNotlar.SelectedIndexChanged += new System.EventHandler(this.lstNotlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 710);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ara";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAra.Location = new System.Drawing.Point(67, 740);
            this.txtAra.Margin = new System.Windows.Forms.Padding(6);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(180, 29);
            this.txtAra.TabIndex = 8;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAra.Location = new System.Drawing.Point(268, 730);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(131, 51);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lstAranan
            // 
            this.lstAranan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAranan.FormattingEnabled = true;
            this.lstAranan.ItemHeight = 24;
            this.lstAranan.Location = new System.Drawing.Point(63, 129);
            this.lstAranan.Name = "lstAranan";
            this.lstAranan.Size = new System.Drawing.Size(363, 556);
            this.lstAranan.TabIndex = 10;
            // 
            // btnAramaIptal
            // 
            this.btnAramaIptal.Location = new System.Drawing.Point(63, 779);
            this.btnAramaIptal.Name = "btnAramaIptal";
            this.btnAramaIptal.Size = new System.Drawing.Size(184, 40);
            this.btnAramaIptal.TabIndex = 11;
            this.btnAramaIptal.Text = "ARAMA İPTAL";
            this.btnAramaIptal.UseVisualStyleBackColor = true;
            this.btnAramaIptal.Visible = false;
            this.btnAramaIptal.Click += new System.EventHandler(this.btnAramaIptal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btnAramaIptal);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNotlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rtxtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAranan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.RichTextBox rtxtIcerik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListBox lstAranan;
        private System.Windows.Forms.Button btnAramaIptal;
    }
}

