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
using Microsoft.Win32;
using System.IO;
namespace Wpf_menu
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

        private void ac_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opendialog = new OpenFileDialog();
            opendialog.Filter = "Metin Dosyalari|*.txt|" + "Tüm Dosyalar|*.*";
            if (opendialog.ShowDialog() == true)
            {
               String Dosyadi= opendialog.FileName;
              TextReader dosya= File.OpenText(Dosyadi);
             String x= dosya.ReadToEnd();
             textBox1.Text = x;
             dosya.Close();

            }
        }

        private void elli_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void yetmisbes_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.75;
        }

        private void kaydet_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
           savedialog.Filter = "Metin Dosyalari|*.txt|" + "Tüm Dosyalar|*.*";
           savedialog.Title = "kaydet penceresi";
           savedialog.DefaultExt = "*.txt";

           if (savedialog.ShowDialog() == true)
           {
               String dosyaadi = savedialog.FileName;
               TextWriter dosya = File.CreateText(dosyaadi);
               dosya.Write(textBox1.Text);
               dosya.Close();



           }
        }
    }
}
