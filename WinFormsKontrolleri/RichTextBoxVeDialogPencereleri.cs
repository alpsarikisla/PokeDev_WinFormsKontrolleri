using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKontrolleri
{
    public partial class RichTextBoxVeDialogPencereleri : Form
    {
        string FilePath = "";
        public RichTextBoxVeDialogPencereleri()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Metin Belgesi|*.txt|Tüm Dosyalar|*.*";
            saveFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf|Tüm Dosyalar|*.*";
            TSCB_Size.Text = richTextBox1.Font.Size.ToString();

            FontFamily[] fonts = FontFamily.Families;
            foreach (FontFamily family in fonts)
            {
                TSCB_FontFamily.Items.Add(family.Name);
            }
            TSCB_FontFamily.SelectedItem = richTextBox1.Font.FontFamily.Name; 
        }

        private void TSMI_Ac_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                FilePath = openFileDialog1.FileName;
                FileInfo fi = new FileInfo(FilePath);
                this.Text += " - " + fi.Name;
            }
        }

        private void TSMI_Kaydet_Click(object sender, EventArgs e)
        {
            if (FilePath != "")
            {
                richTextBox1.SaveFile(FilePath);
                FilePath = saveFileDialog1.FileName;
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti","Kayıt Başarılı");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    FilePath = saveFileDialog1.FileName;
                    FileInfo fi = new FileInfo(FilePath);
                    this.Text += " - " + fi.Name;
                    MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "Kayıt Başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi kullanıcı tarafından iptal edildi", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSMI_FarkliKaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                FilePath = saveFileDialog1.FileName;
                FileInfo fi = new FileInfo(FilePath);
                this.Text += " - " + fi.Name;
                MessageBox.Show("Kayıt Başarıyla Gerçekleşti", "Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt işlemi kullanıcı tarafından iptal edildi", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSCB_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != null)
            {
                float size = (float)TSCB_Size.SelectedIndex;
                Font fnt = new Font(richTextBox1.Font.FontFamily, size);
                richTextBox1.SelectionFont = fnt;
            }
            else
            {
                float size = (float)TSCB_Size.SelectedIndex;
                Font fnt = new Font(richTextBox1.Font.FontFamily, size);
                richTextBox1.Font = fnt;
            }
        }

        private void TSCB_Size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                float size = float.Parse(TSCB_Size.Text);
                Font fnt = new Font(richTextBox1.Font.FontFamily, size);
                richTextBox1.Font = fnt;
            }
        }

        private void TSB_Bold_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void TSMI_FontAyari_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void TSMI_RenkAyari_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
    }
}
