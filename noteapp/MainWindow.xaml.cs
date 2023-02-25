using System.IO;
using System.Windows;
using System.Windows.Input;

namespace noteapp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window {
        public MainWindow() {
        InitializeComponent();
        filenames();
        dt1.ItemsSource = upload1;
            }
        public string[] upload1;
        public void filenames() {
        string[] Names = Directory.GetFiles("Notes/");
        upload1 = new string[Names.Length];
        int counter = 0;
        foreach(string i in Names) {
        string[] tmp0 = i.Split("/");
        string[] tmp1 = tmp0[1].Split(".");
        upload1[counter] = tmp1[0];
        counter++;
            }
            }

        private void Savefunc(object sender,RoutedEventArgs e) {
        try {
        filename.Text=dt1.SelectedItem.ToString();
        string filetosave = $"Notes/{filename.Text}.txt";
        StreamWriter sw = new StreamWriter(filetosave);
        sw.WriteLine(tb1.Text);
        sw.Close();
        filenames();
        dt1.ItemsSource = upload1;
            } catch(IOException a) { MessageBox.Show("File cannot be saved because "+a); }
            }

        private void Openfunc(object sender,RoutedEventArgs e) {
        try {
        filename.Text = dt1.SelectedItem.ToString();
        string filetopen = $"Notes/{dt1.SelectedItem as string}.txt";
        filename.Text = $"{dt1.SelectedItem as string}";
        StreamReader sr = new StreamReader(filetopen);
        tb1.Text = sr.ReadToEnd();
        sr.Close();
        filenames();
        dt1.ItemsSource = upload1;
            } catch(IOException a) { MessageBox.Show("File cannot be opened because " +a); }
            }

        private void Deletefunc(object sender,RoutedEventArgs e) {
        try {
        filename.Text = dt1.SelectedItem.ToString();
        string filetodelete = $"Notes/{dt1.SelectedItem as string}.txt";
        File.Delete(filetodelete);
        MessageBox.Show("Your note has been succesfully deleted");
        filenames();
        dt1.ItemsSource = upload1;
        tb1.Text = "";
        filename.Text = "";
            } catch(IOException a) { MessageBox.Show("File cannot be deleted because " +a); }
            }

        private void Newfunc(object sender,RoutedEventArgs e) {
        try {
        string filetocreate = $"Notes/{filename.Text}.txt";
        File.Create(filetocreate);
        filenames();
        dt1.ItemsSource = upload1;
        tb1.Text = "";
        filename.Text = "";
            } catch(IOException a) { MessageBox.Show("File cannot be created because " + a); }
            }
        }
    }
