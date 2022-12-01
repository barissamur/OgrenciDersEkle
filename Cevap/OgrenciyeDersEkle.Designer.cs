namespace Cevap
{
    partial class OgrenciyeDersEkle
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lboxOgrenciler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxDersler = new System.Windows.Forms.ListBox();
            this.btnDersiEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lboxOgrenciler);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lboxDersler);
            this.splitContainer1.Panel2.Controls.Add(this.btnDersiEkle);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 607);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // lboxOgrenciler
            // 
            this.lboxOgrenciler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lboxOgrenciler.FormattingEnabled = true;
            this.lboxOgrenciler.ItemHeight = 20;
            this.lboxOgrenciler.Location = new System.Drawing.Point(0, 56);
            this.lboxOgrenciler.Name = "lboxOgrenciler";
            this.lboxOgrenciler.Size = new System.Drawing.Size(1021, 244);
            this.lboxOgrenciler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // lboxDersler
            // 
            this.lboxDersler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lboxDersler.FormattingEnabled = true;
            this.lboxDersler.ItemHeight = 20;
            this.lboxDersler.Location = new System.Drawing.Point(0, 59);
            this.lboxDersler.Name = "lboxDersler";
            this.lboxDersler.Size = new System.Drawing.Size(1021, 244);
            this.lboxDersler.TabIndex = 3;
            // 
            // btnDersiEkle
            // 
            this.btnDersiEkle.Location = new System.Drawing.Point(899, 7);
            this.btnDersiEkle.Name = "btnDersiEkle";
            this.btnDersiEkle.Size = new System.Drawing.Size(94, 29);
            this.btnDersiEkle.TabIndex = 2;
            this.btnDersiEkle.Text = "Dersi Ekle";
            this.btnDersiEkle.UseVisualStyleBackColor = true;
            this.btnDersiEkle.Click += new System.EventHandler(this.btnDersiEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Listesi";
            // 
            // OgrenciyeDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 607);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OgrenciyeDersEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Öğrenciye Ders Ekle";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox lboxOgrenciler;
        private Label label1;
        private Button btnDersiEkle;
        private Label label2;
        private ListBox lboxDersler;
    }
}