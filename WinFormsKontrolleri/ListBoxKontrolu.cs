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
    public partial class ListBoxKontrolu : Form
    {
        public ListBoxKontrolu()
        {
            InitializeComponent();
            lb_liste.Items.Add("Eleman 1");
            lb_liste.Items.Add("Eleman 2");
            lb_liste.Items.Add("Eleman 3");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            lb_liste.Items.Add(tb_metin.Text);
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lb_liste.SelectedItem.ToString());
        }

        private void lb_liste_DoubleClick(object sender, EventArgs e)
        {
            if (lb_liste.SelectedItem != null)
            {
                MessageBox.Show(lb_liste.SelectedItem.ToString());
            }
        }
    }
}
