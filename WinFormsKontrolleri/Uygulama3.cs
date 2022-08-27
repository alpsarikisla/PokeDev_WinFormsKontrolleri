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
    public partial class Uygulama3 : Form
    {
        public Uygulama3()
        {
            InitializeComponent();
            //comboBox1.Items.Add("Napin Emirhan?");
        }

        private void Uygulama3_Load(object sender, EventArgs e)
        {
            gb_vatandas.Visible = gb_Yabanci.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gb_vatandas.Visible = true;
                gb_Yabanci.Visible = false;
            }
            else
            {
                gb_vatandas.Visible = false;
                gb_Yabanci.Visible = true;
            }
        }
    }
}
