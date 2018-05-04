using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace veritabani1_baglan_oku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            SqlConnection baglanti = new Connectionyapici().baglantiyagec();
            SqlCommand komut = new SqlCommand();
            SqlDataReader oku;
            
            baglanti.Open();

            komut.Connection = baglanti;
            komut.CommandText = "select * from ogrenciler order by ogadsoyad asc";
            oku = komut.ExecuteReader();


            while (oku.Read()) 
            {
                comboBox1.Items.Add(oku["ogadsoyad"].ToString());
            }
            oku.Close();
            baglanti.Close();

        }
    }
}
