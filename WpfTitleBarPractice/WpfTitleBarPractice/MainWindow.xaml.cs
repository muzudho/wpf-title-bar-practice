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

        /// <summary>
        /// [標準クロームのウィンドウ]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StandardChromeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new StandardChromeWindowView();
            subWindow.Show();
        }

        /// <summary>
        /// [クローム無しウィンドウ]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new NoChromeWindowView();
            subWindow.Show();
        }
    }
}
