namespace WinFormsKontrolleri
{
    partial class WebBrowserVeToolStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserVeToolStrip));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kapat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_Geri = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ileri = new System.Windows.Forms.ToolStripButton();
            this.TSB_Anasayfa = new System.Windows.Forms.ToolStripButton();
            this.TSTB_Adres = new System.Windows.Forms.ToolStripTextBox();
            this.TSB_Ayarlar = new System.Windows.Forms.ToolStripButton();
            this.TSB_Yenile = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Kapat});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // TSMI_Kapat
            // 
            this.TSMI_Kapat.Name = "TSMI_Kapat";
            this.TSMI_Kapat.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.TSMI_Kapat.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Kapat.Text = "Kapat";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Anasayfa,
            this.TSB_Geri,
            this.TSB_Ileri,
            this.TSB_Yenile,
            this.TSTB_Adres,
            this.TSB_Ayarlar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_Geri
            // 
            this.TSB_Geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Geri.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Geri.Image")));
            this.TSB_Geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Geri.Name = "TSB_Geri";
            this.TSB_Geri.Size = new System.Drawing.Size(23, 22);
            this.TSB_Geri.Text = "toolStripButton1";
            // 
            // TSB_Ileri
            // 
            this.TSB_Ileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Ileri.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ileri.Image")));
            this.TSB_Ileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ileri.Name = "TSB_Ileri";
            this.TSB_Ileri.Size = new System.Drawing.Size(23, 22);
            this.TSB_Ileri.Text = "toolStripButton2";
            // 
            // TSB_Anasayfa
            // 
            this.TSB_Anasayfa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Anasayfa.Image")));
            this.TSB_Anasayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Anasayfa.Name = "TSB_Anasayfa";
            this.TSB_Anasayfa.Size = new System.Drawing.Size(23, 22);
            this.TSB_Anasayfa.Text = "toolStripButton3";
            // 
            // TSTB_Adres
            // 
            this.TSTB_Adres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTB_Adres.Name = "TSTB_Adres";
            this.TSTB_Adres.Size = new System.Drawing.Size(700, 25);
            this.TSTB_Adres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TSTB_Adres_KeyDown);
            // 
            // TSB_Ayarlar
            // 
            this.TSB_Ayarlar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSB_Ayarlar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Ayarlar.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ayarlar.Image")));
            this.TSB_Ayarlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ayarlar.Name = "TSB_Ayarlar";
            this.TSB_Ayarlar.Size = new System.Drawing.Size(23, 22);
            this.TSB_Ayarlar.Text = "toolStripButton1";
            // 
            // TSB_Yenile
            // 
            this.TSB_Yenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Yenile.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Yenile.Image")));
            this.TSB_Yenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Yenile.Name = "TSB_Yenile";
            this.TSB_Yenile.Size = new System.Drawing.Size(23, 22);
            this.TSB_Yenile.Text = "toolStripButton1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 49);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1022, 610);
            this.webBrowser1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1022, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // WebBrowserVeToolStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 659);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WebBrowserVeToolStrip";
            this.Text = "Mahmut Browser";
            this.Load += new System.EventHandler(this.WebBrowserVeToolStrip_Load);
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
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kapat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Anasayfa;
        private System.Windows.Forms.ToolStripButton TSB_Geri;
        private System.Windows.Forms.ToolStripButton TSB_Ileri;
        private System.Windows.Forms.ToolStripButton TSB_Yenile;
        private System.Windows.Forms.ToolStripTextBox TSTB_Adres;
        private System.Windows.Forms.ToolStripButton TSB_Ayarlar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}