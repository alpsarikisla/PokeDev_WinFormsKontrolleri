namespace WinFormsKontrolleri
{
    partial class TextBoxKontrolu
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
            this.tb_Standart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_genislik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_enabled = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sinirli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mtb_kimlik = new System.Windows.Forms.MaskedTextBox();
            this.nu_Adet = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nu_Adet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Standart
            // 
            this.tb_Standart.Location = new System.Drawing.Point(120, 38);
            this.tb_Standart.Name = "tb_Standart";
            this.tb_Standart.Size = new System.Drawing.Size(100, 20);
            this.tb_Standart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Standart";
            // 
            // tb_genislik
            // 
            this.tb_genislik.Location = new System.Drawing.Point(120, 64);
            this.tb_genislik.Name = "tb_genislik";
            this.tb_genislik.Size = new System.Drawing.Size(250, 20);
            this.tb_genislik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genişlik";
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(120, 90);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(100, 20);
            this.tb_sifre.TabIndex = 2;
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre";
            // 
            // tb_enabled
            // 
            this.tb_enabled.Enabled = false;
            this.tb_enabled.Location = new System.Drawing.Point(120, 116);
            this.tb_enabled.Name = "tb_enabled";
            this.tb_enabled.Size = new System.Drawing.Size(100, 20);
            this.tb_enabled.TabIndex = 3;
            this.tb_enabled.Text = "Alp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enabled";
            // 
            // tb_sinirli
            // 
            this.tb_sinirli.Location = new System.Drawing.Point(120, 142);
            this.tb_sinirli.MaxLength = 5;
            this.tb_sinirli.Name = "tb_sinirli";
            this.tb_sinirli.Size = new System.Drawing.Size(100, 20);
            this.tb_sinirli.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sınırlı Karakter";
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(120, 168);
            this.tb_Adres.Multiline = true;
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Adres.Size = new System.Drawing.Size(250, 75);
            this.tb_Adres.TabIndex = 5;
            this.tb_Adres.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adres";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Alp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Read Only";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(120, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Character Casing";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0,0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Right To Left";
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(120, 341);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(100, 20);
            this.mtb_telefon.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kimlik No:";
            // 
            // mtb_kimlik
            // 
            this.mtb_kimlik.Location = new System.Drawing.Point(120, 367);
            this.mtb_kimlik.Mask = "99999999999";
            this.mtb_kimlik.Name = "mtb_kimlik";
            this.mtb_kimlik.Size = new System.Drawing.Size(100, 20);
            this.mtb_kimlik.TabIndex = 10;
            // 
            // nu_Adet
            // 
            this.nu_Adet.Location = new System.Drawing.Point(120, 393);
            this.nu_Adet.Name = "nu_Adet";
            this.nu_Adet.Size = new System.Drawing.Size(120, 20);
            this.nu_Adet.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "NumericUpDown";
            // 
            // TextBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 522);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nu_Adet);
            this.Controls.Add(this.mtb_kimlik);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtb_telefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_genislik);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_enabled);
            this.Controls.Add(this.tb_sinirli);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tb_Standart);
            this.Name = "TextBoxKontrolu";
            this.Text = "TextBoxKontrolu";
            ((System.ComponentModel.ISupportInitialize)(this.nu_Adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Standart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_genislik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_enabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sinirli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtb_kimlik;
        private System.Windows.Forms.NumericUpDown nu_Adet;
        private System.Windows.Forms.Label label12;
    }
}