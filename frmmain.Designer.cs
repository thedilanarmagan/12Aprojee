namespace kutpro
{
    partial class frmmain
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
            this.btnOgrenciler = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnKitapTur = new System.Windows.Forms.Button();
            this.btnOduncİs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciler
            // 
            this.btnOgrenciler.Image = global::kutpro.Properties.Resources.student;
            this.btnOgrenciler.Location = new System.Drawing.Point(41, 26);
            this.btnOgrenciler.Name = "btnOgrenciler";
            this.btnOgrenciler.Size = new System.Drawing.Size(125, 160);
            this.btnOgrenciler.TabIndex = 0;
            this.btnOgrenciler.Text = "Öğrenciler";
            this.btnOgrenciler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOgrenciler.UseVisualStyleBackColor = true;
            this.btnOgrenciler.Click += new System.EventHandler(this.btnOgrenciler_Click);
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.Image = global::kutpro.Properties.Resources.Everaldo_Desktoon_Library_128;
            this.btnKitaplar.Location = new System.Drawing.Point(172, 26);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(125, 160);
            this.btnKitaplar.TabIndex = 0;
            this.btnKitaplar.Text = "Kitaplar";
            this.btnKitaplar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitaplar.UseVisualStyleBackColor = true;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnKitapTur
            // 
            this.btnKitapTur.Image = global::kutpro.Properties.Resources.Asset_2;
            this.btnKitapTur.Location = new System.Drawing.Point(41, 192);
            this.btnKitapTur.Name = "btnKitapTur";
            this.btnKitapTur.Size = new System.Drawing.Size(125, 160);
            this.btnKitapTur.TabIndex = 0;
            this.btnKitapTur.Text = "Kitap Türleri";
            this.btnKitapTur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapTur.UseVisualStyleBackColor = true;
            this.btnKitapTur.Click += new System.EventHandler(this.btnKitapTur_Click);
            // 
            // btnOduncİs
            // 
            this.btnOduncİs.Image = global::kutpro.Properties.Resources.borrow;
            this.btnOduncİs.Location = new System.Drawing.Point(172, 192);
            this.btnOduncİs.Name = "btnOduncİs";
            this.btnOduncİs.Size = new System.Drawing.Size(125, 160);
            this.btnOduncİs.TabIndex = 0;
            this.btnOduncİs.Text = "Ödünç İşlemleri";
            this.btnOduncİs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOduncİs.UseVisualStyleBackColor = true;
            this.btnOduncİs.Click += new System.EventHandler(this.btnOduncİs_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 384);
            this.Controls.Add(this.btnOduncİs);
            this.Controls.Add(this.btnKitapTur);
            this.Controls.Add(this.btnKitaplar);
            this.Controls.Add(this.btnOgrenciler);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciler;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnKitapTur;
        private System.Windows.Forms.Button btnOduncİs;
    }
}

