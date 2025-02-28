namespace NotDefteri
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
            this.components = new System.ComponentModel.Container();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPdfKaydet = new System.Windows.Forms.Button();
            this.lblKarakterSayisi = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYeni.Location = new System.Drawing.Point(285, 3);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(94, 36);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnAc
            // 
            this.btnAc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAc.Location = new System.Drawing.Point(3, 3);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(93, 36);
            this.btnAc.TabIndex = 1;
            this.btnAc.Text = "Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(0, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1830, 836);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKaydet.Location = new System.Drawing.Point(195, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 36);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCikis.Location = new System.Drawing.Point(99, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 36);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.btnRenk);
            this.panel1.Controls.Add(this.btnPdfKaydet);
            this.panel1.Controls.Add(this.lblKarakterSayisi);
            this.panel1.Controls.Add(this.btnFont);
            this.panel1.Controls.Add(this.btnAc);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 40);
            this.panel1.TabIndex = 5;

            // 
            // btnPdfKaydet
            // 
            this.btnPdfKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPdfKaydet.BackColor = System.Drawing.Color.Cyan;
            this.btnPdfKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfKaydet.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPdfKaydet.Location = new System.Drawing.Point(585, 3);
            this.btnPdfKaydet.Name = "btnPdfKaydet";
            this.btnPdfKaydet.Size = new System.Drawing.Size(105, 36);
            this.btnPdfKaydet.TabIndex = 7;
            this.btnPdfKaydet.Text = "PDF KAydet";
            this.btnPdfKaydet.UseVisualStyleBackColor = false;
            this.btnPdfKaydet.Click += new System.EventHandler(this.btnPdfKaydet_Click);
            // 
            // lblKarakterSayisi
            // 
            this.lblKarakterSayisi.AutoSize = true;
            this.lblKarakterSayisi.Location = new System.Drawing.Point(796, 9);
            this.lblKarakterSayisi.Name = "lblKarakterSayisi";
            this.lblKarakterSayisi.Size = new System.Drawing.Size(0, 16);
            this.lblKarakterSayisi.TabIndex = 5;
            // 
            // btnFont
            // 
            this.btnFont.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFont.Location = new System.Drawing.Point(385, 4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(94, 36);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "Yazı Tipi";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRenk.Location = new System.Drawing.Point(485, 3);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(94, 36);
            this.btnRenk.TabIndex = 5;
            this.btnRenk.Text = "Renk";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "NoteX";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblKarakterSayisi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPdfKaydet;
    }
}

