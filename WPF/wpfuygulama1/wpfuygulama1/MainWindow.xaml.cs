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
using System.Windows.Threading;
namespace wpfuygulama1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer zamanlayici = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    
           
     

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Canvas.SetLeft(ellipse1, Canvas.GetLeft(ellipse1) - 1); 

            }
            else if(e.Key==Key.Up)
            {
                Canvas.SetTop(ellipse1, Canvas.GetTop(ellipse1) - 1);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            zamanlayici.Tick += new EventHandler(zamanlayici_tick);
            zamanlayici.Interval = new TimeSpan(0, 0, 2);
            zamanlayici.Start();
        }

        private void zamanlayici_tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
        }
     

       
       
    }
}
