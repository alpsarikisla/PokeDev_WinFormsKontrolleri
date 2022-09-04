namespace WinFormsKontrolleri
{
    partial class ListBoxKontrolu
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
            this.lb_liste = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_metin = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_goster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_liste
            // 
            this.lb_liste.FormattingEnabled = true;
            this.lb_liste.Location = new System.Drawing.Point(12, 12);
            this.lb_liste.Name = "lb_liste";
            this.lb_liste.Size = new System.Drawing.Size(254, 420);
            this.lb_liste.TabIndex = 0;
            this.lb_liste.DoubleClick += new System.EventHandler(this.lb_liste_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eleman:";
            // 
            // tb_metin
            // 
            this.tb_metin.Location = new System.Drawing.Point(275, 28);
            this.tb_metin.Name = "tb_metin";
            this.tb_metin.Size = new System.Drawing.Size(240, 20);
            this.tb_metin.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(440, 54);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(275, 409);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(75, 23);
            this.btn_goster.TabIndex = 4;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // ListBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_metin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_liste);
            this.Name = "ListBoxKontrolu";
            this.Text = "ListBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_liste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_metin;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_goster;
    }
}