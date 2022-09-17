namespace WinFormsKontrolleri
{
    partial class RichTextBoxVeDialogPencereleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RichTextBoxVeDialogPencereleri));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Yeni = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Ac = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Yazdir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_Cikis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TSB_yeni = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ac = new System.Windows.Forms.ToolStripButton();
            this.TSB_Kaydet = new System.Windows.Forms.ToolStripButton();
            this.TSB_FarkliKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TSCB_Size = new System.Windows.Forms.ToolStripComboBox();
            this.TSCB_FontFamily = new System.Windows.Forms.ToolStripComboBox();
            this.TSB_Bold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_FontAyari = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RenkAyari = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Yeni,
            this.TSMI_Ac,
            this.TSMI_Kaydet,
            this.TSMI_FarkliKaydet,
            this.toolStripSeparator1,
            this.TSMI_Yazdir,
            this.toolStripSeparator2,
            this.TSMI_Cikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_Yeni
            // 
            this.TSMI_Yeni.Name = "TSMI_Yeni";
            this.TSMI_Yeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMI_Yeni.Size = new System.Drawing.Size(213, 22);
            this.TSMI_Yeni.Text = "Yeni";
            // 
            // TSMI_Ac
            // 
            this.TSMI_Ac.Name = "TSMI_Ac";
            this.TSMI_Ac.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMI_Ac.Size = new System.Drawing.Size(213, 22);
            this.TSMI_Ac.Text = "Aç";
            this.TSMI_Ac.Click += new System.EventHandler(this.TSMI_Ac_Click);
            // 
            // TSMI_Kaydet
            // 
            this.TSMI_Kaydet.Name = "TSMI_Kaydet";
            this.TSMI_Kaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMI_Kaydet.Size = new System.Drawing.Size(213, 22);
            this.TSMI_Kaydet.Text = "Kaydet";
            this.TSMI_Kaydet.Click += new System.EventHandler(this.TSMI_Kaydet_Click);
            // 
            // TSMI_FarkliKaydet
            // 
            this.TSMI_FarkliKaydet.Name = "TSMI_FarkliKaydet";
            this.TSMI_FarkliKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMI_FarkliKaydet.Size = new System.Drawing.Size(213, 22);
            this.TSMI_FarkliKaydet.Text = "Farklı Kaydet";
            this.TSMI_FarkliKaydet.Click += new System.EventHandler(this.TSMI_FarkliKaydet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // TSMI_Yazdir
            // 
            this.TSMI_Yazdir.Name = "TSMI_Yazdir";
            this.TSMI_Yazdir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TSMI_Yazdir.Size = new System.Drawing.Size(213, 22);
            this.TSMI_Yazdir.Text = "Yazdır";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // TSMI_Cikis
            // 
            this.TSMI_Cikis.Name = "TSMI_Cikis";
            this.TSMI_Cikis.Size = new System.Drawing.Size(213, 22);
            this.TSMI_Cikis.Text = "Çıkış";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_yeni,
            this.TSB_Ac,
            this.TSB_Kaydet,
            this.TSB_FarkliKaydet,
            this.toolStripSeparator3,
            this.TSCB_Size,
            this.TSCB_FontFamily,
            this.TSB_Bold,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(906, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(906, 510);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // TSB_yeni
            // 
            this.TSB_yeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_yeni.Image = ((System.Drawing.Image)(resources.GetObject("TSB_yeni.Image")));
            this.TSB_yeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_yeni.Name = "TSB_yeni";
            this.TSB_yeni.Size = new System.Drawing.Size(23, 22);
            this.TSB_yeni.Text = "toolStripButton1";
            // 
            // TSB_Ac
            // 
            this.TSB_Ac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Ac.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ac.Image")));
            this.TSB_Ac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ac.Name = "TSB_Ac";
            this.TSB_Ac.Size = new System.Drawing.Size(23, 22);
            this.TSB_Ac.Text = "toolStripButton2";
            this.TSB_Ac.Click += new System.EventHandler(this.TSMI_Ac_Click);
            // 
            // TSB_Kaydet
            // 
            this.TSB_Kaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Kaydet.Image")));
            this.TSB_Kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Kaydet.Name = "TSB_Kaydet";
            this.TSB_Kaydet.Size = new System.Drawing.Size(23, 22);
            this.TSB_Kaydet.Text = "toolStripButton3";
            this.TSB_Kaydet.Click += new System.EventHandler(this.TSMI_Kaydet_Click);
            // 
            // TSB_FarkliKaydet
            // 
            this.TSB_FarkliKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_FarkliKaydet.Image = ((System.Drawing.Image)(resources.GetObject("TSB_FarkliKaydet.Image")));
            this.TSB_FarkliKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_FarkliKaydet.Name = "TSB_FarkliKaydet";
            this.TSB_FarkliKaydet.Size = new System.Drawing.Size(23, 22);
            this.TSB_FarkliKaydet.Text = "toolStripButton4";
            this.TSB_FarkliKaydet.Click += new System.EventHandler(this.TSMI_FarkliKaydet_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TSCB_Size
            // 
            this.TSCB_Size.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "70"});
            this.TSCB_Size.Name = "TSCB_Size";
            this.TSCB_Size.Size = new System.Drawing.Size(75, 25);
            this.TSCB_Size.SelectedIndexChanged += new System.EventHandler(this.TSCB_Size_SelectedIndexChanged);
            this.TSCB_Size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSCB_Size_KeyDown);
            // 
            // TSCB_FontFamily
            // 
            this.TSCB_FontFamily.Name = "TSCB_FontFamily";
            this.TSCB_FontFamily.Size = new System.Drawing.Size(121, 25);
            // 
            // TSB_Bold
            // 
            this.TSB_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Bold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSB_Bold.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Bold.Image")));
            this.TSB_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Bold.Name = "TSB_Bold";
            this.TSB_Bold.Size = new System.Drawing.Size(23, 22);
            this.TSB_Bold.Text = "B";
            this.TSB_Bold.Click += new System.EventHandler(this.TSB_Bold_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "I";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "U";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_FontAyari,
            this.TSMI_RenkAyari});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // TSMI_FontAyari
            // 
            this.TSMI_FontAyari.Name = "TSMI_FontAyari";
            this.TSMI_FontAyari.Size = new System.Drawing.Size(180, 22);
            this.TSMI_FontAyari.Text = "Font Ayarı";
            this.TSMI_FontAyari.Click += new System.EventHandler(this.TSMI_FontAyari_Click);
            // 
            // TSMI_RenkAyari
            // 
            this.TSMI_RenkAyari.Name = "TSMI_RenkAyari";
            this.TSMI_RenkAyari.Size = new System.Drawing.Size(180, 22);
            this.TSMI_RenkAyari.Text = "Renk Ayarı";
            this.TSMI_RenkAyari.Click += new System.EventHandler(this.TSMI_RenkAyari_Click);
            // 
            // RichTextBoxVeDialogPencereleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 559);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RichTextBoxVeDialogPencereleri";
            this.Text = "Editör Şevket";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Yeni;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Ac;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kaydet;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Yazdir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Cikis;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_yeni;
        private System.Windows.Forms.ToolStripButton TSB_Ac;
        private System.Windows.Forms.ToolStripButton TSB_Kaydet;
        private System.Windows.Forms.ToolStripButton TSB_FarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripComboBox TSCB_Size;
        private System.Windows.Forms.ToolStripComboBox TSCB_FontFamily;
        private System.Windows.Forms.ToolStripButton TSB_Bold;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_FontAyari;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RenkAyari;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}