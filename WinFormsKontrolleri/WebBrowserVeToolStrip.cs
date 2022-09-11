using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKontrolleri
{
    public partial class WebBrowserVeToolStrip : Form
    {
        public WebBrowserVeToolStrip()
        {
            InitializeComponent();
        }

        private void WebBrowserVeToolStrip_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://www.google.com");
        }

        private void TSTB_Adres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TSTB_Adres.Text.Length != 0)
                {
                    webBrowser1.Url = new Uri(TSTB_Adres.Text);
                }
            }
        }
    }
}
