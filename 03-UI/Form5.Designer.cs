namespace _03_UI
{
    partial class Form5
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
            this.gbOgunEkle = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.txtPorsiyon = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            this.cmbTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOgunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOgunEkle
            // 
            this.gbOgunEkle.Controls.Add(this.btnGeriDon);
            this.gbOgunEkle.Controls.Add(this.txtPorsiyon);
            this.gbOgunEkle.Controls.Add(this.btnKaydet);
            this.gbOgunEkle.Controls.Add(this.cmbYemek);
            this.gbOgunEkle.Controls.Add(this.cmbTipi);
            this.gbOgunEkle.Controls.Add(this.label4);
            this.gbOgunEkle.Controls.Add(this.label1);
            this.gbOgunEkle.Controls.Add(this.dtpTarih);
            this.gbOgunEkle.Controls.Add(this.label3);
            this.gbOgunEkle.Controls.Add(this.label2);
            this.gbOgunEkle.Location = new System.Drawing.Point(12, 12);
            this.gbOgunEkle.Name = "gbOgunEkle";
            this.gbOgunEkle.Size = new System.Drawing.Size(459, 278);
            this.gbOgunEkle.TabIndex = 0;
            this.gbOgunEkle.TabStop = false;
            this.gbOgunEkle.Text = "Öğün Ekleme Paneli";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(186, 226);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(120, 41);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // txtPorsiyon
            // 
            this.txtPorsiyon.Location = new System.Drawing.Point(116, 184);
            this.txtPorsiyon.Name = "txtPorsiyon";
            this.txtPorsiyon.Size = new System.Drawing.Size(316, 27);
            this.txtPorsiyon.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(312, 226);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 41);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Location = new System.Drawing.Point(116, 138);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(316, 28);
            this.cmbYemek.TabIndex = 3;
            // 
            // cmbTipi
            // 
            this.cmbTipi.FormattingEnabled = true;
            this.cmbTipi.Location = new System.Drawing.Point(116, 89);
            this.cmbTipi.Name = "cmbTipi";
            this.cmbTipi.Size = new System.Drawing.Size(316, 28);
            this.cmbTipi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Porsiyon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yemek:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(116, 38);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(316, 27);
            this.dtpTarih.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğün Tipi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 300);
            this.Controls.Add(this.gbOgunEkle);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.gbOgunEkle.ResumeLayout(false);
            this.gbOgunEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbOgunEkle;
        private Button btnKaydet;
        private ComboBox cmbTipi;
        private DateTimePicker dtpTarih;
        private Label label3;
        private Label label2;
        private TextBox txtPorsiyon;
        private ComboBox cmbYemek;
        private Label label4;
        private Label label1;
        private Button btnGeriDon;
    }
}