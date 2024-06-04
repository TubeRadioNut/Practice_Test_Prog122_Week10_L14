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

namespace Practice_Test_Prog122_Week10_L14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//<--don't delete this
            lbDisplayMovie.ItemsSource = Data.Movies;

        }

        private void btnAddMovie_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            string rating = txtRating.Text;
            Data.AddMovie(title, director, rating);
            
        }

        private void btnOpenDisplayWindow_Click(object sender, RoutedEventArgs e)
        {
             DisplayWindow displaywindow = new DisplayWindow();
             displaywindow.Show();
        }
    }
}