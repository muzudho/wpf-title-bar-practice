namespace WpfTitleBarPractice
{
    using System.Windows;
    using WpfTitleBarPractice.Views;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DefaultWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new StandardChromeWindowView();
            subWindow.Show();
        }
    }
}
