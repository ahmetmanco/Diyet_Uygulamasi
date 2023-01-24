namespace _03_UI
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpGunSonuRaporu = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGunSonuRaporu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(515, 1015);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpGunSonuRaporu
            // 
            this.grpGunSonuRaporu.Controls.Add(this.btnGeriDon);
            this.grpGunSonuRaporu.Controls.Add(this.dataGridView1);
            this.grpGunSonuRaporu.Location = new System.Drawing.Point(14, 16);
            this.grpGunSonuRaporu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGunSonuRaporu.Name = "grpGunSonuRaporu";
            this.grpGunSonuRaporu.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpGunSonuRaporu.Size = new System.Drawing.Size(521, 1043);
            this.grpGunSonuRaporu.TabIndex = 1;
            this.grpGunSonuRaporu.TabStop = false;
            this.grpGunSonuRaporu.Text = "Gün Sonu Raporu";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.Location = new System.Drawing.Point(6, 524);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(504, 64);
            this.btnGeriDon.TabIndex = 1;
            this.btnGeriDon.Text = "G E R İ  D Ö N";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 617);
            this.Controls.Add(this.grpGunSonuRaporu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form6";
            this.Text = "Gün Sonu Raporu";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGunSonuRaporu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpGunSonuRaporu;
        private Button btnGeriDon;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Colum1;
        private DataGridViewTextBoxColumn Column2;
    }
}