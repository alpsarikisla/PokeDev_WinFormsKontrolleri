using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAcessLayer;

namespace WinFormsKontrolleri
{
    public partial class ComboBoxDataBound : Form
    {
        public ComboBoxDataBound()
        {
            InitializeComponent();
        }

        private void ComboBoxDataBound_Load(object sender, EventArgs e)
        {
            ComboboxDoldur4();
        }

        

        private void ComboboxDoldur1()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-6NIP90O\SQLEXPRESS; Initial Catalog=DersOrnek; Integrated Security=True";
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti;
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "SELECT ID, Isim FROM Sehirler";
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString(1));
            }
            baglanti.Close();
        }

        private void ComboboxDoldur2()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-6NIP90O\SQLEXPRESS; Initial Catalog=DersOrnek; Integrated Security=True";
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti;
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "SELECT ID, Isim FROM Sehirler";
            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            while (reader.Read())
            {
                var Sehir = new {Text = reader.GetString(1), Value= reader.GetInt32(0)};
                comboBox1.Items.Add(Sehir);
            }
            baglanti.Close();
        }

        private void ComboboxDoldur3()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-6NIP90O\SQLEXPRESS; Initial Catalog=DersOrnek; Integrated Security=True";
            baglanti.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID, Isim FROM Sehirler", baglanti);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBox1.DisplayMember = "Isim";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        private void ComboboxDoldur4()
        {
            DataModel dm = new DataModel();
            comboBox1.DisplayMember = "Isim";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dm.GetSehirs();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            string veri = "";
            veri += "Selected Value = " + comboBox1.SelectedValue;
            veri += "\nSelected Index = " + comboBox1.SelectedIndex;
            veri += "\nSelected Text = " + comboBox1.Text;
            veri += "\nSelected Item = " + comboBox1.SelectedItem.ToString();
            MessageBox.Show(veri);
        }
    }
}
