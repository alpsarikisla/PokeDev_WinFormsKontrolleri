namespace WinFormsKontrolleri
{
    partial class Uygulama2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sayi1 = new System.Windows.Forms.TextBox();
            this.tb_sayi2 = new System.Windows.Forms.TextBox();
            this.tb_Sonuc = new System.Windows.Forms.TextBox();
            this.cb_islem = new System.Windows.Forms.ComboBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı2 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "İşlem =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sonuç =";
            // 
            // tb_sayi1
            // 
            this.tb_sayi1.Location = new System.Drawing.Point(96, 19);
            this.tb_sayi1.Name = "tb_sayi1";
            this.tb_sayi1.Size = new System.Drawing.Size(121, 20);
            this.tb_sayi1.TabIndex = 4;
            // 
            // tb_sayi2
            // 
            this.tb_sayi2.Location = new System.Drawing.Point(96, 45);
            this.tb_sayi2.Name = "tb_sayi2";
            this.tb_sayi2.Size = new System.Drawing.Size(121, 20);
            this.tb_sayi2.TabIndex = 4;
            // 
            // tb_Sonuc
            // 
            this.tb_Sonuc.Location = new System.Drawing.Point(96, 127);
            this.tb_Sonuc.Name = "tb_Sonuc";
            this.tb_Sonuc.Size = new System.Drawing.Size(121, 20);
            this.tb_Sonuc.TabIndex = 4;
            // 
            // cb_islem
            // 
            this.cb_islem.FormattingEnabled = true;
            this.cb_islem.Items.AddRange(new object[] {
            "Topla",
            "Çıkar",
            "Çarp",
            "Böl"});
            this.cb_islem.Location = new System.Drawing.Point(96, 71);
            this.cb_islem.Name = "cb_islem";
            this.cb_islem.Size = new System.Drawing.Size(121, 21);
            this.cb_islem.TabIndex = 5;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(96, 98);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(121, 23);
            this.btn_hesapla.TabIndex = 6;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // Uygulama2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.cb_islem);
            this.Controls.Add(this.tb_Sonuc);
            this.Controls.Add(this.tb_sayi2);
            this.Controls.Add(this.tb_sayi1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Uygulama2";
            this.Text = "Uygulama2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sayi1;
        private System.Windows.Forms.TextBox tb_sayi2;
        private System.Windows.Forms.TextBox tb_Sonuc;
        private System.Windows.Forms.ComboBox cb_islem;
        private System.Windows.Forms.Button btn_hesapla;
    }
}