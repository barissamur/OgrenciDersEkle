namespace Cevap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenciListesi = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersler = new System.Windows.Forms.Button();
            this.btnOgrenciyeDersEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(179, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üniversite Ana Sayfasına Hoşgeldiniz";
            // 
            // btnOgrenciListesi
            // 
            this.btnOgrenciListesi.Location = new System.Drawing.Point(289, 224);
            this.btnOgrenciListesi.Name = "btnOgrenciListesi";
            this.btnOgrenciListesi.Size = new System.Drawing.Size(186, 78);
            this.btnOgrenciListesi.TabIndex = 1;
            this.btnOgrenciListesi.Text = "Öğrenci Listesi";
            this.btnOgrenciListesi.UseVisualStyleBackColor = true;
            this.btnOgrenciListesi.Click += new System.EventHandler(this.btnOgrenciListesi_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(289, 313);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(186, 78);
            this.btnOgrenciEkle.TabIndex = 2;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(550, 313);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(186, 78);
            this.btnDersEkle.TabIndex = 3;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersler
            // 
            this.btnDersler.Location = new System.Drawing.Point(550, 224);
            this.btnDersler.Name = "btnDersler";
            this.btnDersler.Size = new System.Drawing.Size(186, 78);
            this.btnDersler.TabIndex = 4;
            this.btnDersler.Text = "Ders Listesi";
            this.btnDersler.UseVisualStyleBackColor = true;
            this.btnDersler.Click += new System.EventHandler(this.btnDersler_Click);
            // 
            // btnOgrenciyeDersEkle
            // 
            this.btnOgrenciyeDersEkle.Location = new System.Drawing.Point(385, 428);
            this.btnOgrenciyeDersEkle.Name = "btnOgrenciyeDersEkle";
            this.btnOgrenciyeDersEkle.Size = new System.Drawing.Size(255, 70);
            this.btnOgrenciyeDersEkle.TabIndex = 5;
            this.btnOgrenciyeDersEkle.Text = "Öğrenciye Ders Ekle";
            this.btnOgrenciyeDersEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciyeDersEkle.Click += new System.EventHandler(this.btnOgrenciyeDersEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1024, 615);
            this.Controls.Add(this.btnOgrenciyeDersEkle);
            this.Controls.Add(this.btnDersler);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.btnOgrenciListesi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnOgrenciListesi;
        private Button btnOgrenciEkle;
        private Button btnDersEkle;
        private Button btnDersler;
        private Button btnOgrenciyeDersEkle;
    }
}