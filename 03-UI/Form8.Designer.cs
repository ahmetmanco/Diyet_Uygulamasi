namespace _03_UI
{
    partial class Form8
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
            this.dgvEnCok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYemekKiyas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.cmbYemekler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekKiyas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEnCok
            // 
            this.dgvEnCok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnCok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnCok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCok.Location = new System.Drawing.Point(12, 237);
            this.dgvEnCok.Name = "dgvEnCok";
            this.dgvEnCok.RowTemplate.Height = 25;
            this.dgvEnCok.Size = new System.Drawing.Size(495, 179);
            this.dgvEnCok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "En Çok Yenen Yemekler";
            // 
            // dgvYemekKiyas
            // 
            this.dgvYemekKiyas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYemekKiyas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekKiyas.Location = new System.Drawing.Point(12, 32);
            this.dgvYemekKiyas.Name = "dgvYemekKiyas";
            this.dgvYemekKiyas.Size = new System.Drawing.Size(495, 150);
            this.dgvYemekKiyas.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yemeklerin Kıyas Raporu";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(432, 441);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(75, 23);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // cmbYemekler
            // 
            this.cmbYemekler.FormattingEnabled = true;
            this.cmbYemekler.Location = new System.Drawing.Point(281, 441);
            this.cmbYemekler.Name = "cmbYemekler";
            this.cmbYemekler.Size = new System.Drawing.Size(121, 23);
            this.cmbYemekler.TabIndex = 3;
            this.cmbYemekler.SelectedIndexChanged += new System.EventHandler(this.cmbYemekler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kıyaslamak İstediğiniz Yemeği Seçiniz:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYemekler);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvYemekKiyas);
            this.Controls.Add(this.dgvEnCok);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekKiyas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvEnCok;
        private Label label1;
        private DataGridView dgvYemekKiyas;
        private Label label2;
        private Button btnGeriDon;
        private ComboBox cmbYemekler;
        private Label label3;
    }
}