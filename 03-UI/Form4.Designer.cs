namespace _03_UI
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKalori = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniOgun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOgunSil = new System.Windows.Forms.Button();
            this.btnYemekSil = new System.Windows.Forms.Button();
            this.dgvOgunler = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGunSonuRaporu = new System.Windows.Forms.Button();
            this.btnKiyasRaporu = new System.Windows.Forms.Button();
            this.btnYemekCesidiRaporu = new System.Windows.Forms.Button();
            this.btnOguneYemekEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnYemekKaydet = new System.Windows.Forms.Button();
            this.txtPorsiyon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKalori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(872, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalori Takip";
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.Location = new System.Drawing.Point(93, 28);
            this.lblKalori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(38, 15);
            this.lblKalori.TabIndex = 1;
            this.lblKalori.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaloriniz :";
            // 
            // btnYeniOgun
            // 
            this.btnYeniOgun.Location = new System.Drawing.Point(336, 368);
            this.btnYeniOgun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniOgun.Name = "btnYeniOgun";
            this.btnYeniOgun.Size = new System.Drawing.Size(171, 38);
            this.btnYeniOgun.TabIndex = 10;
            this.btnYeniOgun.Text = "ÖĞÜN EKLE";
            this.btnYeniOgun.UseVisualStyleBackColor = true;
            this.btnYeniOgun.Click += new System.EventHandler(this.btnYeniOgun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOgunSil);
            this.groupBox2.Controls.Add(this.btnYemekSil);
            this.groupBox2.Controls.Add(this.dgvOgunler);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(7, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(839, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bugün Aldığın Öğünler Listesi";
            // 
            // btnOgunSil
            // 
            this.btnOgunSil.Location = new System.Drawing.Point(227, 232);
            this.btnOgunSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOgunSil.Name = "btnOgunSil";
            this.btnOgunSil.Size = new System.Drawing.Size(82, 38);
            this.btnOgunSil.TabIndex = 2;
            this.btnOgunSil.Text = "ÖĞÜN SİL";
            this.btnOgunSil.UseVisualStyleBackColor = true;
            this.btnOgunSil.Click += new System.EventHandler(this.btnOgunSil_Click);
            // 
            // btnYemekSil
            // 
            this.btnYemekSil.Location = new System.Drawing.Point(684, 233);
            this.btnYemekSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYemekSil.Name = "btnYemekSil";
            this.btnYemekSil.Size = new System.Drawing.Size(144, 38);
            this.btnYemekSil.TabIndex = 4;
            this.btnYemekSil.Text = "ÖĞÜNDEN YEMEK SİL";
            this.btnYemekSil.UseVisualStyleBackColor = true;
            this.btnYemekSil.Click += new System.EventHandler(this.btnYemekSil_Click);
            // 
            // dgvOgunler
            // 
            this.dgvOgunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunler.Location = new System.Drawing.Point(8, 15);
            this.dgvOgunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOgunler.MultiSelect = false;
            this.dgvOgunler.Name = "dgvOgunler";
            this.dgvOgunler.ReadOnly = true;
            this.dgvOgunler.RowHeadersWidth = 51;
            this.dgvOgunler.RowTemplate.Height = 29;
            this.dgvOgunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunler.Size = new System.Drawing.Size(304, 213);
            this.dgvOgunler.TabIndex = 1;
            this.dgvOgunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgunler_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(499, 213);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGunSonuRaporu
            // 
            this.btnGunSonuRaporu.Location = new System.Drawing.Point(7, 412);
            this.btnGunSonuRaporu.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunSonuRaporu.Name = "btnGunSonuRaporu";
            this.btnGunSonuRaporu.Size = new System.Drawing.Size(152, 38);
            this.btnGunSonuRaporu.TabIndex = 6;
            this.btnGunSonuRaporu.Text = "Gün Sonu Raporu";
            this.btnGunSonuRaporu.UseVisualStyleBackColor = true;
            this.btnGunSonuRaporu.Click += new System.EventHandler(this.btnGunSonuRaporu_Click);
            // 
            // btnKiyasRaporu
            // 
            this.btnKiyasRaporu.Location = new System.Drawing.Point(7, 368);
            this.btnKiyasRaporu.Margin = new System.Windows.Forms.Padding(2);
            this.btnKiyasRaporu.Name = "btnKiyasRaporu";
            this.btnKiyasRaporu.Size = new System.Drawing.Size(152, 38);
            this.btnKiyasRaporu.TabIndex = 5;
            this.btnKiyasRaporu.Text = "Kıyas Raporu";
            this.btnKiyasRaporu.UseVisualStyleBackColor = true;
            this.btnKiyasRaporu.Click += new System.EventHandler(this.btnKiyasRaporu_Click);
            // 
            // btnYemekCesidiRaporu
            // 
            this.btnYemekCesidiRaporu.Location = new System.Drawing.Point(7, 458);
            this.btnYemekCesidiRaporu.Margin = new System.Windows.Forms.Padding(2);
            this.btnYemekCesidiRaporu.Name = "btnYemekCesidiRaporu";
            this.btnYemekCesidiRaporu.Size = new System.Drawing.Size(152, 38);
            this.btnYemekCesidiRaporu.TabIndex = 7;
            this.btnYemekCesidiRaporu.Text = "Yemek Çeşidi Raporu";
            this.btnYemekCesidiRaporu.UseVisualStyleBackColor = true;
            this.btnYemekCesidiRaporu.Click += new System.EventHandler(this.btnYemekCesidiRaporu_Click);
            // 
            // btnOguneYemekEkle
            // 
            this.btnOguneYemekEkle.Location = new System.Drawing.Point(336, 412);
            this.btnOguneYemekEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnOguneYemekEkle.Name = "btnOguneYemekEkle";
            this.btnOguneYemekEkle.Size = new System.Drawing.Size(171, 38);
            this.btnOguneYemekEkle.TabIndex = 11;
            this.btnOguneYemekEkle.Text = "ÖĞÜNE YEMEK EKLE";
            this.btnOguneYemekEkle.UseVisualStyleBackColor = true;
            this.btnOguneYemekEkle.Click += new System.EventHandler(this.btnOguneYemekEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnYemekKaydet);
            this.groupBox3.Controls.Add(this.txtPorsiyon);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbYemek);
            this.groupBox3.Location = new System.Drawing.Point(511, 362);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(334, 151);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğün Bilgileri Gir";
            this.groupBox3.Visible = false;
            // 
            // btnYemekKaydet
            // 
            this.btnYemekKaydet.Location = new System.Drawing.Point(205, 98);
            this.btnYemekKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnYemekKaydet.Name = "btnYemekKaydet";
            this.btnYemekKaydet.Size = new System.Drawing.Size(119, 38);
            this.btnYemekKaydet.TabIndex = 14;
            this.btnYemekKaydet.Text = "Yemek Kaydet";
            this.btnYemekKaydet.UseVisualStyleBackColor = true;
            this.btnYemekKaydet.Click += new System.EventHandler(this.btnYemekKaydet_Click);
            // 
            // txtPorsiyon
            // 
            this.txtPorsiyon.Location = new System.Drawing.Point(75, 64);
            this.txtPorsiyon.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorsiyon.Name = "txtPorsiyon";
            this.txtPorsiyon.Size = new System.Drawing.Size(249, 23);
            this.txtPorsiyon.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Porsiyon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yemek:";
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Location = new System.Drawing.Point(75, 28);
            this.cmbYemek.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(249, 23);
            this.cmbYemek.TabIndex = 12;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(100, 499);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(60, 38);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(7, 499);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(88, 38);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Uygulamayı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYeniOgun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOguneYemekEkle);
            this.Controls.Add(this.btnYemekCesidiRaporu);
            this.Controls.Add(this.btnKiyasRaporu);
            this.Controls.Add(this.btnGunSonuRaporu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblKalori;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnGunSonuRaporu;
        private Button btnKiyasRaporu;
        private Button btnYemekCesidiRaporu;
        private Button btnOguneYemekEkle;
        private GroupBox groupBox3;
        private Button btnYemekKaydet;
        private TextBox txtPorsiyon;
        private Label label6;
        private Label label5;
        private ComboBox cmbYemek;
        private Button btnYeniOgun;
        private DataGridView dgvOgunler;
        private Button btnCikis;
        private Button btnKapat;
        private Button btnOgunSil;
        private Button btnYemekSil;
    }
}