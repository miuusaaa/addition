namespace Adisyon
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
            label1 = new Label();
            label2 = new Label();
            txtBoxKullaniciAdi = new TextBox();
            txtBoxSifre = new TextBox();
            BtnGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(178, 78);
            label1.Name = "label1";
            label1.Size = new Size(211, 45);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(190, 156);
            label2.Name = "label2";
            label2.Size = new Size(99, 45);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // txtBoxKullaniciAdi
            // 
            txtBoxKullaniciAdi.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBoxKullaniciAdi.Location = new Point(423, 73);
            txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            txtBoxKullaniciAdi.Size = new Size(167, 50);
            txtBoxKullaniciAdi.TabIndex = 2;
            // 
            // txtBoxSifre
            // 
            txtBoxSifre.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtBoxSifre.Location = new Point(423, 156);
            txtBoxSifre.Name = "txtBoxSifre";
            txtBoxSifre.Size = new Size(167, 50);
            txtBoxSifre.TabIndex = 3;
            // 
            // BtnGiris
            // 
            BtnGiris.AutoSize = true;
            BtnGiris.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnGiris.Location = new Point(266, 258);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(238, 111);
            BtnGiris.TabIndex = 4;
            BtnGiris.Text = "Giriş";
            BtnGiris.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnGiris.UseMnemonic = false;
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGiris);
            Controls.Add(txtBoxSifre);
            Controls.Add(txtBoxKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBoxKullaniciAdi;
        private TextBox txtBoxSifre;
        private Button BtnGiris;
    }
}
