namespace WinFormsKontrolleri
{
    partial class Uygulama1
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
            this.tb_Sayi1 = new System.Windows.Forms.TextBox();
            this.tb_Sayi2 = new System.Windows.Forms.TextBox();
            this.tb_Sonuc = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fark = new System.Windows.Forms.Button();
            this.btn_Carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Sayi1
            // 
            this.tb_Sayi1.Location = new System.Drawing.Point(78, 26);
            this.tb_Sayi1.Name = "tb_Sayi1";
            this.tb_Sayi1.Size = new System.Drawing.Size(110, 20);
            this.tb_Sayi1.TabIndex = 0;
            // 
            // tb_Sayi2
            // 
            this.tb_Sayi2.Location = new System.Drawing.Point(78, 52);
            this.tb_Sayi2.Name = "tb_Sayi2";
            this.tb_Sayi2.Size = new System.Drawing.Size(110, 20);
            this.tb_Sayi2.TabIndex = 0;
            // 
            // tb_Sonuc
            // 
            this.tb_Sonuc.Location = new System.Drawing.Point(78, 108);
            this.tb_Sonuc.Name = "tb_Sonuc";
            this.tb_Sonuc.Size = new System.Drawing.Size(110, 20);
            this.tb_Sonuc.TabIndex = 0;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(78, 78);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(23, 23);
            this.btn_topla.TabIndex = 1;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sonuç";
            // 
            // btn_Fark
            // 
            this.btn_Fark.Location = new System.Drawing.Point(107, 79);
            this.btn_Fark.Name = "btn_Fark";
            this.btn_Fark.Size = new System.Drawing.Size(23, 23);
            this.btn_Fark.TabIndex = 3;
            this.btn_Fark.Text = "-";
            this.btn_Fark.UseVisualStyleBackColor = true;
            this.btn_Fark.Click += new System.EventHandler(this.btn_Fark_Click);
            // 
            // btn_Carp
            // 
            this.btn_Carp.Location = new System.Drawing.Point(136, 79);
            this.btn_Carp.Name = "btn_Carp";
            this.btn_Carp.Size = new System.Drawing.Size(23, 23);
            this.btn_Carp.TabIndex = 4;
            this.btn_Carp.Text = "x";
            this.btn_Carp.UseVisualStyleBackColor = true;
            this.btn_Carp.Click += new System.EventHandler(this.btn_Carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(165, 79);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(23, 23);
            this.btn_bol.TabIndex = 5;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // Uygulama1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_Carp);
            this.Controls.Add(this.btn_Fark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.tb_Sonuc);
            this.Controls.Add(this.tb_Sayi2);
            this.Controls.Add(this.tb_Sayi1);
            this.Name = "Uygulama1";
            this.Text = "Uygulama1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Sayi1;
        private System.Windows.Forms.TextBox tb_Sayi2;
        private System.Windows.Forms.TextBox tb_Sonuc;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fark;
        private System.Windows.Forms.Button btn_Carp;
        private System.Windows.Forms.Button btn_bol;
    }
}