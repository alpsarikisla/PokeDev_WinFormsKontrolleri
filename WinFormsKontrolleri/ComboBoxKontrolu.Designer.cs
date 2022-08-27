namespace WinFormsKontrolleri
{
    partial class ComboBoxKontrolu
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Goster = new System.Windows.Forms.Button();
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standart ComboBox:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Web Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı",
            "Grafik Tasarım",
            "MS Office"});
            this.comboBox1.Location = new System.Drawing.Point(126, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_Goster
            // 
            this.btn_Goster.Location = new System.Drawing.Point(253, 32);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(75, 23);
            this.btn_Goster.TabIndex = 2;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.UseVisualStyleBackColor = true;
            this.btn_Goster.Click += new System.EventHandler(this.btn_Goster_Click);
            // 
            // cb_sehir
            // 
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Adana",
            "Bursa",
            "Eskişehir",
            "Kütahya"});
            this.cb_sehir.Location = new System.Drawing.Point(126, 59);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(121, 21);
            this.cb_sehir.TabIndex = 3;
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.cb_sehir_SelectedIndexChanged);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Location = new System.Drawing.Point(253, 117);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(0, 13);
            this.lbl_secilen.TabIndex = 4;
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 112);
            this.Controls.Add(this.lbl_secilen);
            this.Controls.Add(this.cb_sehir);
            this.Controls.Add(this.btn_Goster);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Goster;
        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Label lbl_secilen;
    }
}