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
    public partial class ComboBoxKontrolu : Form
    {
        public ComboBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show("Value = " + comboBox1.SelectedValue + "\nIndex = " + comboBox1.SelectedIndex +"\nSelected Item = " + comboBox1.SelectedItem.ToString() + "\nText=" + comboBox1.Text, "Seçilen Eleman");
            }
            else
            {
                MessageBox.Show("Seçim Yapmadınız", "Hata");
            }
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_secilen.Text = cb_sehir.SelectedItem.ToString();
        }
    }
}
