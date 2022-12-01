namespace Cevap
{
    partial class OgrenciListesi
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
            this.dgvOgrenciDersleri = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOgrenciler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgrenciBilgi = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciDersleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenciDersleri
            // 
            this.dgvOgrenciDersleri.AllowUserToAddRows = false;
            this.dgvOgrenciDersleri.AllowUserToDeleteRows = false;
            this.dgvOgrenciDersleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgrenciDersleri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgrenciDersleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciDersleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvOgrenciDersleri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOgrenciDersleri.Location = new System.Drawing.Point(0, 164);
            this.dgvOgrenciDersleri.Name = "dgvOgrenciDersleri";
            this.dgvOgrenciDersleri.ReadOnly = true;
            this.dgvOgrenciDersleri.RowHeadersWidth = 51;
            this.dgvOgrenciDersleri.RowTemplate.Height = 29;
            this.dgvOgrenciDersleri.Size = new System.Drawing.Size(800, 392);
            this.dgvOgrenciDersleri.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DersAdi";
            this.Column1.HeaderText = "Ders Adı";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cmbOgrenciler
            // 
            this.cmbOgrenciler.FormattingEnabled = true;
            this.cmbOgrenciler.Location = new System.Drawing.Point(291, 33);
            this.cmbOgrenciler.Name = "cmbOgrenciler";
            this.cmbOgrenciler.Size = new System.Drawing.Size(399, 28);
            this.cmbOgrenciler.TabIndex = 1;
            this.cmbOgrenciler.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Seçiniz :";
            // 
            // lblOgrenciBilgi
            // 
            this.lblOgrenciBilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOgrenciBilgi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOgrenciBilgi.Location = new System.Drawing.Point(12, 102);
            this.lblOgrenciBilgi.Name = "lblOgrenciBilgi";
            this.lblOgrenciBilgi.Size = new System.Drawing.Size(776, 40);
            this.lblOgrenciBilgi.TabIndex = 3;
            this.lblOgrenciBilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ders Kodu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.lblOgrenciBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOgrenciler);
            this.Controls.Add(this.dgvOgrenciDersleri);
            this.Name = "OgrenciListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğrenci Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciDersleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOgrenciDersleri;
        private ComboBox cmbOgrenciler;
        private Label label1;
        private Label lblOgrenciBilgi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}