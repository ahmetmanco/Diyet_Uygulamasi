namespace _03_UI
{
    partial class Form3
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
            this.frm3_btnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıtlı E-posta adresin ile giriş yap";
            // 
            // frm3_btnGirisYap
            // 
            this.frm3_btnGirisYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.frm3_btnGirisYap.Location = new System.Drawing.Point(50, 179);
            this.frm3_btnGirisYap.Margin = new System.Windows.Forms.Padding(2);
            this.frm3_btnGirisYap.Name = "frm3_btnGirisYap";
            this.frm3_btnGirisYap.Size = new System.Drawing.Size(276, 28);
            this.frm3_btnGirisYap.TabIndex = 3;
            this.frm3_btnGirisYap.Text = "Giriş Yap";
            this.frm3_btnGirisYap.UseVisualStyleBackColor = false;
            this.frm3_btnGirisYap.Click += new System.EventHandler(this.frm3_btnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Posta";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(117, 80);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(210, 23);
            this.txtEposta.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(117, 118);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(210, 23);
            this.txtSifre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre ";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(49, 236);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(276, 28);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 368);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.frm3_btnGirisYap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Giris Yap";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button frm3_btnGirisYap;
        private Label label2;
        private TextBox txtEposta;
        private TextBox txtSifre;
        private Label label3;
        private Button btnGeriDon;
    }
}