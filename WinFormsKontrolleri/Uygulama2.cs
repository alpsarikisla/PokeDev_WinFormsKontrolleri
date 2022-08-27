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
    public partial class Uygulama2 : Form
    {
        public Uygulama2()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (cb_islem.SelectedItem != null)
            {
                double s1 = Convert.ToDouble(tb_sayi1.Text);
                double s2 = Convert.ToDouble(tb_sayi2.Text);
                if (cb_islem.Text == "Topla")
                {
                    tb_Sonuc.Text = (s1 + s2).ToString();
                }
                if (cb_islem.Text == "Çıkar")
                {
                    tb_Sonuc.Text = (s1 - s2).ToString();
                }
                if (cb_islem.Text == "Çarp")
                {
                    tb_Sonuc.Text = (s1 * s2).ToString();
                }
                if (cb_islem.Text == "Böl")
                {
                    tb_Sonuc.Text = (s1 / s2).ToString();
                }
            }
            else
            {
                MessageBox.Show("İşlem Seçilmedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
