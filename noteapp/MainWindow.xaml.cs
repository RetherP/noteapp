using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace noteapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            filenames();
            dt1.ItemsSource = upload1;
        }
        public string[] upload1;
        public void filenames()
        {
            string[] Names = Directory.GetFiles("Notes/");
            upload1 = new string[Names.Length];
            int counter = 0;
            foreach (string i in Names)
            {
                string[] tmp0 = i.Split("/");
                string[] tmp1 = tmp0[1].Split(".");
                upload1[counter] = tmp1[0];
                counter++;
            }
        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            tb1.Text = "";
        }

        private void Savefunc(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(filename.Text);
            sw.WriteLine(tb1.Text);
            sw.Close();
        }

        private void Openfunc(object sender, RoutedEventArgs e)
        {

        }

        private void Deletefunc(object sender, RoutedEventArgs e)
        {

        }

        private void Newfunc(object sender, RoutedEventArgs e)
        {

        }
    }
}
