using System.Windows;
using System.Windows.Input;


namespace WPF_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            tbURL_1.Text = "Введите URL";
            tbURL_2.Text = "Введите URL";
            tbURL_3.Text = "Введите URL";
        }
        
        private void bStart_1_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MainVM;
            if (dc == null) return;
            dc.loadImage_1();

        }

        private void bStart_2_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MainVM;
            if (dc == null) return;
            dc.loadImage_2();
        }

        private void bStart_3_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MainVM;
            if (dc == null) return;
            dc.loadImage_3();
        }
        private void all_start_Click(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MainVM;
            if (dc == null) return;
            dc.loadImage_1();
            dc.loadImage_2();
            dc.loadImage_3();

        }

        
        

        private void bStop_1_Click(object sender, RoutedEventArgs e)
        {

            
        }
        
        private void bStop_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bStop_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tbURL_1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbURL_1.Text = "";
        }

        private void tbURL_2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbURL_2.Text = "";
        }

        private void tbURL_3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbURL_3.Text = "";
        }

        
    }
}
    

