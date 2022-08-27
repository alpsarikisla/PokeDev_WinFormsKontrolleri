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
    public partial class Uygulama1 : Form
    {
        public Uygulama1()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(tb_Sayi1.Text);
            int sayi2 = Convert.ToInt32(tb_Sayi2.Text);
            int sonuc = sayi1 + sayi2;
            tb_Sonuc.Text = sonuc.ToString();
        }

        private void btn_Fark_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb_Sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_Sayi2.Text);
            tb_Sonuc.Text = (sayi1 - sayi2).ToString();
        }

        private void btn_Carp_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb_Sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_Sayi2.Text);
            tb_Sonuc.Text = (sayi1 * sayi2).ToString();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb_Sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_Sayi2.Text);
            tb_Sonuc.Text = (sayi1 / sayi2).ToString();
        }
    }
}
