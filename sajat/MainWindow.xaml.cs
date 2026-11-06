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

namespace sajat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Szin
    {
        public int Szám { get; set; }
        public String Szín { get; set; }

        public Szin(int szám, String szín)
        {
            Szám = szám;
            Szín = szín;
        }
    }
    public partial class MainWindow : Window
    {
        List<Szin> szinek = new List<Szin>();
        public MainWindow()
        {
            InitializeComponent();
            szinek.Add(new Szin(30, "Piros"));
            szinek.Add(new Szin(33, "Kék"));
            dataGrid.ItemsSource = szinek;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            szinek.Add(new Szin((int)slider.Value, comboBox.Text));
            dataGrid.Items.Refresh();
        }

        private void kilepes(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void torles(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null && dataGrid.SelectedItem is Szin)
            {
                szinek.Remove((Szin)dataGrid.SelectedItem);
                dataGrid.Items.Refresh();
            }
        }
    }
}